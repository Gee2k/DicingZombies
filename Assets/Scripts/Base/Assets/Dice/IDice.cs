using UnityEngine;

namespace Base.Assets.Dice
{
    public interface IDice<DICE_VALUE>
    {
        // T GetValueForSide(SidesEnum sidesEnum);
        
        GameObject GetRepresentation();

        DICE_VALUE GetDiceValue();

        void SetDiceThrowResult(DiceSidesNameEnum diceSidesNameEnum);
    }
}