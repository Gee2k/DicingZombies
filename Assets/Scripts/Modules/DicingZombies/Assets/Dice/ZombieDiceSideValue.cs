namespace Modules.DicingZombies.Assets.Dice
{
    public class ZombieDiceSideValue : DiceSideValue
    {
        private ZombieDiceColorEnum _color;
        private ZombieDiceValueEnum _zombieDiceValueEnum;

        public ZombieDiceSideValue(ZombieDiceColorEnum color, ZombieDiceValueEnum value) : base()
        {
            this._color = color;
            this._zombieDiceValueEnum = value;
        }

        public ZombieDiceColorEnum getColor()
        {
            return this._color;
        }

        public ZombieDiceValueEnum getValue()
        {
            return this._zombieDiceValueEnum;
        }
    }
}