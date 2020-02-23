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
        public ZombieDice(ZombieDiceSideColorEnum color, GameObject representation)
        {
            switch (color)
            {
                case ZombieDiceSideColorEnum.Green:
                    createGreenDice();
                    break;
                case ZombieDiceSideColorEnum.Yellow:
                    createYellowDice();
                    break;
                case ZombieDiceSideColorEnum.Red:
                    createRedDice();
                    break;
            }

            representation.AddComponent<Diceable>();
            _representation = representation;
        }

        private void createGreenDice()
        {
            diceSideValues.Add(DiceSidesNameEnum.Ceiling,
                new ZombieDiceSideValue(ZombieDiceSideColorEnum.Green, ZombieDiceValueEnum.Hit));
            diceSideValues.Add(DiceSidesNameEnum.East,
                new ZombieDiceSideValue(ZombieDiceSideColorEnum.Green, ZombieDiceValueEnum.Escape));
            diceSideValues.Add(DiceSidesNameEnum.West,
                new ZombieDiceSideValue(ZombieDiceSideColorEnum.Green, ZombieDiceValueEnum.Escape));
            diceSideValues.Add(DiceSidesNameEnum.North,
                new ZombieDiceSideValue(ZombieDiceSideColorEnum.Green, ZombieDiceValueEnum.Brain));
            diceSideValues.Add(DiceSidesNameEnum.South,
                new ZombieDiceSideValue(ZombieDiceSideColorEnum.Green, ZombieDiceValueEnum.Brain));
            diceSideValues.Add(DiceSidesNameEnum.Floor,
                new ZombieDiceSideValue(ZombieDiceSideColorEnum.Green, ZombieDiceValueEnum.Brain));
        }

        private void createYellowDice()
        {
            diceSideValues.Add(DiceSidesNameEnum.Ceiling,
                new ZombieDiceSideValue(ZombieDiceSideColorEnum.Yellow, ZombieDiceValueEnum.Hit));
            diceSideValues.Add(DiceSidesNameEnum.East,
                new ZombieDiceSideValue(ZombieDiceSideColorEnum.Yellow, ZombieDiceValueEnum.Escape));
            diceSideValues.Add(DiceSidesNameEnum.West,
                new ZombieDiceSideValue(ZombieDiceSideColorEnum.Yellow, ZombieDiceValueEnum.Escape));
            diceSideValues.Add(DiceSidesNameEnum.North,
                new ZombieDiceSideValue(ZombieDiceSideColorEnum.Yellow, ZombieDiceValueEnum.Brain));
            diceSideValues.Add(DiceSidesNameEnum.South,
                new ZombieDiceSideValue(ZombieDiceSideColorEnum.Yellow, ZombieDiceValueEnum.Brain));
            diceSideValues.Add(DiceSidesNameEnum.Floor,
                new ZombieDiceSideValue(ZombieDiceSideColorEnum.Yellow, ZombieDiceValueEnum.Hit));
        }

        private void createRedDice()
        {
            diceSideValues.Add(DiceSidesNameEnum.Ceiling,
                new ZombieDiceSideValue(ZombieDiceSideColorEnum.Red, ZombieDiceValueEnum.Brain));
            diceSideValues.Add(DiceSidesNameEnum.East,
                new ZombieDiceSideValue(ZombieDiceSideColorEnum.Red, ZombieDiceValueEnum.Hit));
            diceSideValues.Add(DiceSidesNameEnum.West,
                new ZombieDiceSideValue(ZombieDiceSideColorEnum.Red, ZombieDiceValueEnum.Hit));
            diceSideValues.Add(DiceSidesNameEnum.North,
                new ZombieDiceSideValue(ZombieDiceSideColorEnum.Red, ZombieDiceValueEnum.Escape));
            diceSideValues.Add(DiceSidesNameEnum.South,
                new ZombieDiceSideValue(ZombieDiceSideColorEnum.Red, ZombieDiceValueEnum.Escape));
            diceSideValues.Add(DiceSidesNameEnum.Floor,
                new ZombieDiceSideValue(ZombieDiceSideColorEnum.Red, ZombieDiceValueEnum.Hit));
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