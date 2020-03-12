using System;
using System.Collections.Generic;
using Base.Assets;
using UnityEngine;

namespace Base
{
    public class MenuManager
    {
        private Dictionary<String, BaseMenu> _menus = new Dictionary<string, BaseMenu>();

        private Dictionary<String, GameObject> cachedMenus = new Dictionary<string, GameObject>();

        //deactivate all Menus when not needed
        public MenuManager()
        {
            foreach (GameObject gameObject in GameObject.FindGameObjectsWithTag("initiallyHidden"))
            {
                gameObject.SetActive(false);
                cachedMenus.Add(gameObject.name, gameObject);
                Debug.Log("caching menu \"" + gameObject.name);
            }
        }

        //add menu item
        public void AddMenus(List<BaseMenu> menus)
        {
            foreach (BaseMenu menu in menus)
            {
                AddMenu(menu);
            }
        }

        public void AddMenu(BaseMenu menu)
        {
            try
            {
                _menus.Add(menu.GetName(), menu);
                Debug.Log("added menu \"" + menu.GetName() + "\" successfully");
            }
            catch (Exception e)
            {
                Debug.Log("menu \"" + menu.GetName() + "\" already added to menuManager");
            }
        }

        public GameObject GetMenuLogic(string menuName)
        {
            try
            {
                return cachedMenus[menuName];
            }
            catch (Exception e)
            {
                throw new UnityException("menu \"" + menuName + "\" not found in menuManager");
            }
        }

        //show specific menus
        public void showMenu(String name)
        {
            _menus[name].ShowMenuIfNotVisible();
        }

        //hide specific menu
        public void hideMenu(String name)
        {
            _menus[name].HideMenuIfVisible();
        }

        public void InitializeMenus()
        {
            foreach (var menu in _menus)
            {
                Debug.Log("initializing: " + menu.Key);
                //check if menu go was already read and cached
                if (!menu.Value.initialized)
                {
                    try
                    {
                        //read value from dict throws exception if not in dict
                        GameObject go = cachedMenus[menu.Key];
                        menu.Value.GetMenuObject = go;
                        menu.Value.initialized = true;
                    }
                    catch (Exception e)
                    {
                        Debug.Log(menu.Key + " is not cached, initializing");
                        menu.Value.Initialize();
                    }
                    Debug.Log(menu.Key + " is already, initializing");
                }
            }
        }
    }
}