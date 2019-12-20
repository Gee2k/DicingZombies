using System;

namespace Play.ZombieDice
{
    public class ZombieDiceSideValue : DiceSideValue
    {
        private String _color;
        private ZombieDiceValueEnum _zombieDiceValueEnum;

        public String getColor()
        {
            return this._color;
        }

        public ZombieDiceValueEnum getValue()
        {
            return this._zombieDiceValueEnum;
        }
    }
}