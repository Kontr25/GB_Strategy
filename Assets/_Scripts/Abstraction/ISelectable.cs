using UnityEngine;

namespace _Scripts.Abstraction
{
    public interface ISelectable : IHealthHolder
    {
        Transform PivotPoint { get; }
        Sprite Icon { get; }
        void onSelected(ISelectable selected);
    }
}