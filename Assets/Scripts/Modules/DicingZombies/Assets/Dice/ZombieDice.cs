using System.Collections.Generic;
using Base.Assets.Dice;
using UnityEngine;

namespace Modules.DicingZombies.Assets.Dice
{
    public class ZombieDice : IDice<ZombieDiceSideValue>
    {
        private Dictionary<DiceSidesNameEnum, ZombieDiceSideValue> diceSideValues = new Dictionary<DiceSidesNameEnum, ZombieDiceSideValue>();
        private GameObject _representation;
        private ZombieDiceSideValue _diceSideValue;
        public ZombieDice(ZombieDiceColorEnum color, GameObject representation)
        {
            switch (color)
            {
                case ZombieDiceColorEnum.Green:
                    CreateGreenDice();
                    break;
                case ZombieDiceColorEnum.Yellow:
                    CreateYellowDice();
                    break;
                case ZombieDiceColorEnum.Red:
                    CreateRedDice();
                    break;
            }

            representation.AddComponent<Diceable>();
            _representation = representation;
        }

        private void CreateGreenDice()
        {
            diceSideValues.Add(DiceSidesNameEnum.Ceiling,
                new ZombieDiceSideValue(ZombieDiceColorEnum.Green, ZombieDiceValueEnum.Hit));
            diceSideValues.Add(DiceSidesNameEnum.East,
                new ZombieDiceSideValue(ZombieDiceColorEnum.Green, ZombieDiceValueEnum.Escape));
            diceSideValues.Add(DiceSidesNameEnum.West,
                new ZombieDiceSideValue(ZombieDiceColorEnum.Green, ZombieDiceValueEnum.Escape));
            diceSideValues.Add(DiceSidesNameEnum.North,
                new ZombieDiceSideValue(ZombieDiceColorEnum.Green, ZombieDiceValueEnum.Brain));
            diceSideValues.Add(DiceSidesNameEnum.South,
                new ZombieDiceSideValue(ZombieDiceColorEnum.Green, ZombieDiceValueEnum.Brain));
            diceSideValues.Add(DiceSidesNameEnum.Floor,
                new ZombieDiceSideValue(ZombieDiceColorEnum.Green, ZombieDiceValueEnum.Brain));
        }

        private void CreateYellowDice()
        {
            diceSideValues.Add(DiceSidesNameEnum.Ceiling,
                new ZombieDiceSideValue(ZombieDiceColorEnum.Yellow, ZombieDiceValueEnum.Hit));
            diceSideValues.Add(DiceSidesNameEnum.East,
                new ZombieDiceSideValue(ZombieDiceColorEnum.Yellow, ZombieDiceValueEnum.Escape));
            diceSideValues.Add(DiceSidesNameEnum.West,
                new ZombieDiceSideValue(ZombieDiceColorEnum.Yellow, ZombieDiceValueEnum.Escape));
            diceSideValues.Add(DiceSidesNameEnum.North,
                new ZombieDiceSideValue(ZombieDiceColorEnum.Yellow, ZombieDiceValueEnum.Brain));
            diceSideValues.Add(DiceSidesNameEnum.South,
                new ZombieDiceSideValue(ZombieDiceColorEnum.Yellow, ZombieDiceValueEnum.Brain));
            diceSideValues.Add(DiceSidesNameEnum.Floor,
                new ZombieDiceSideValue(ZombieDiceColorEnum.Yellow, ZombieDiceValueEnum.Hit));
        }

        private void CreateRedDice()
        {
            diceSideValues.Add(DiceSidesNameEnum.Ceiling,
                new ZombieDiceSideValue(ZombieDiceColorEnum.Red, ZombieDiceValueEnum.Brain));
            diceSideValues.Add(DiceSidesNameEnum.East,
                new ZombieDiceSideValue(ZombieDiceColorEnum.Red, ZombieDiceValueEnum.Hit));
            diceSideValues.Add(DiceSidesNameEnum.West,
                new ZombieDiceSideValue(ZombieDiceColorEnum.Red, ZombieDiceValueEnum.Hit));
            diceSideValues.Add(DiceSidesNameEnum.North,
                new ZombieDiceSideValue(ZombieDiceColorEnum.Red, ZombieDiceValueEnum.Escape));
            diceSideValues.Add(DiceSidesNameEnum.South,
                new ZombieDiceSideValue(ZombieDiceColorEnum.Red, ZombieDiceValueEnum.Escape));
            diceSideValues.Add(DiceSidesNameEnum.Floor,
                new ZombieDiceSideValue(ZombieDiceColorEnum.Red, ZombieDiceValueEnum.Hit));
        }

        public void SetDiceThrowResult(DiceSidesNameEnum diceSidesNameEnum)
        {
            _diceSideValue =  diceSideValues[diceSidesNameEnum];
        }

        public GameObject GetRepresentation()
        {
            return _representation;
        }

        public ZombieDiceSideValue GetDiceValue()
        {
            return _diceSideValue;
        }
    }
}