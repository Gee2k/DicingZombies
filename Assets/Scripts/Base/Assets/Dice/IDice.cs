using UnityEngine;

namespace Base.Assets.Dice
{
    public interface IDice<T>
    {
        T GetValueForSide(SidesEnum sidesEnum);
        
        GameObject GetRepresentation();
    }
}