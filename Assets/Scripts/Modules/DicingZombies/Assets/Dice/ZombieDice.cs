using System.Collections.Generic;
using Base.Assets.Dice;
using UnityEngine;

namespace Modules.DicingZombies.Assets.Dice
{
    public class ZombieDice : IDice<ZombieDiceSideValue>
    {
        private Dictionary<SidesEnum, ZombieDiceSideValue> diceSideValues = new Dictionary<SidesEnum, ZombieDiceSideValue>();
        private GameObject _representation;
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
            diceSideValues.Add(SidesEnum.Ceiling,
                new ZombieDiceSideValue(ZombieDiceSideColorEnum.Green, ZombieDiceValueEnum.Hit));
            diceSideValues.Add(SidesEnum.East,
                new ZombieDiceSideValue(ZombieDiceSideColorEnum.Green, ZombieDiceValueEnum.Escape));
            diceSideValues.Add(SidesEnum.West,
                new ZombieDiceSideValue(ZombieDiceSideColorEnum.Green, ZombieDiceValueEnum.Escape));
            diceSideValues.Add(SidesEnum.North,
                new ZombieDiceSideValue(ZombieDiceSideColorEnum.Green, ZombieDiceValueEnum.Brain));
            diceSideValues.Add(SidesEnum.South,
                new ZombieDiceSideValue(ZombieDiceSideColorEnum.Green, ZombieDiceValueEnum.Brain));
            diceSideValues.Add(SidesEnum.Floor,
                new ZombieDiceSideValue(ZombieDiceSideColorEnum.Green, ZombieDiceValueEnum.Brain));
        }

        private void createYellowDice()
        {
            diceSideValues.Add(SidesEnum.Ceiling,
                new ZombieDiceSideValue(ZombieDiceSideColorEnum.Yellow, ZombieDiceValueEnum.Hit));
            diceSideValues.Add(SidesEnum.East,
                new ZombieDiceSideValue(ZombieDiceSideColorEnum.Yellow, ZombieDiceValueEnum.Escape));
            diceSideValues.Add(SidesEnum.West,
                new ZombieDiceSideValue(ZombieDiceSideColorEnum.Yellow, ZombieDiceValueEnum.Escape));
            diceSideValues.Add(SidesEnum.North,
                new ZombieDiceSideValue(ZombieDiceSideColorEnum.Yellow, ZombieDiceValueEnum.Brain));
            diceSideValues.Add(SidesEnum.South,
                new ZombieDiceSideValue(ZombieDiceSideColorEnum.Yellow, ZombieDiceValueEnum.Brain));
            diceSideValues.Add(SidesEnum.Floor,
                new ZombieDiceSideValue(ZombieDiceSideColorEnum.Yellow, ZombieDiceValueEnum.Hit));
        }

        private void createRedDice()
        {
            diceSideValues.Add(SidesEnum.Ceiling,
                new ZombieDiceSideValue(ZombieDiceSideColorEnum.Red, ZombieDiceValueEnum.Brain));
            diceSideValues.Add(SidesEnum.East,
                new ZombieDiceSideValue(ZombieDiceSideColorEnum.Red, ZombieDiceValueEnum.Hit));
            diceSideValues.Add(SidesEnum.West,
                new ZombieDiceSideValue(ZombieDiceSideColorEnum.Red, ZombieDiceValueEnum.Hit));
            diceSideValues.Add(SidesEnum.North,
                new ZombieDiceSideValue(ZombieDiceSideColorEnum.Red, ZombieDiceValueEnum.Escape));
            diceSideValues.Add(SidesEnum.South,
                new ZombieDiceSideValue(ZombieDiceSideColorEnum.Red, ZombieDiceValueEnum.Escape));
            diceSideValues.Add(SidesEnum.Floor,
                new ZombieDiceSideValue(ZombieDiceSideColorEnum.Red, ZombieDiceValueEnum.Hit));
        }

        ZombieDiceSideValue IDice<ZombieDiceSideValue>.GetValueForSide(SidesEnum sidesEnum)
        {
            return diceSideValues[sidesEnum];
        }

        public GameObject GetRepresentation()
        {
            return _representation;
        }
    }
}