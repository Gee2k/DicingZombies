using System;

namespace Play.DicingZombies
{
    public class ZombieDiceSideValue : DiceSideValue
    {
        private ZombieDiceSideColorEnum _color;
        private ZombieDiceValueEnum _zombieDiceValueEnum;

        public ZombieDiceSideValue(ZombieDiceSideColorEnum color, ZombieDiceValueEnum value) : base()
        {
            this._color = color;
            this._zombieDiceValueEnum = value;
        }

        public ZombieDiceSideColorEnum getColor()
        {
            return this._color;
        }

        public ZombieDiceValueEnum getValue()
        {
            return this._zombieDiceValueEnum;
        }
    }
}