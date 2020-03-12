using System;
using UnityEngine;

namespace Base.Assets
{
    public class BaseMenu
    {
        private bool _initialized = false;
        private bool _initialVisibility = false;
        private String _name;
        private GameObject _menuObject;

        public BaseMenu(string name, GameObject menuObject,  bool initialVisibility)
        {
            _name = name;
            _menuObject = menuObject;
            _initialVisibility = initialVisibility;
            _initialized = true;
        }
        public BaseMenu(string name, bool initialVisibility)
        {
            _name = name;
            _initialVisibility = initialVisibility;
        }
        
        public BaseMenu(string name)
        {
            _name = name;
        }

        public GameObject GetMenuObject
        {
            get
            {
                if (initialized)
                {
                    throw new UnityException("Menu Item not found");
                }
                return _menuObject;
            }
            set => _menuObject = value;
        }

        public string GetName()
        {
            return _name;
        }

        public void ShowMenuIfNotVisible()
        {
            if (_initialized && !IsMenuShow())
            {
                _menuObject.SetActive(true);
                Debug.Log("shown menu \"" + GetName() + "\" successfully");
            }
        }

        public void HideMenuIfVisible()
        {
            if (_initialized && IsMenuShow())
            {
                _menuObject.SetActive(false);
                Debug.Log("hide menu \"" + GetName() + "\" successfully");
            }
        }

        public bool IsMenuShow()
        {
            return _menuObject.activeSelf;
        }

        public bool initialized
        {
            get => _initialized;
            set => _initialized = value;
        }

        public void Initialize()
        {
            if (!initialized)
            {
                _menuObject = GameObject.Find(_name);
                if (_menuObject == null)
                {
                    throw new UnityException("Menu Item not found");
                }

                if (!_initialVisibility)
                {
                    _menuObject.SetActive(false);
                }
                _initialized = true;
            }
        }
    }
}