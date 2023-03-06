using UnityEngine;

namespace _Scripts.Abstraction
{
    public interface ISelectable
    {
        float Health { get; }
        float MaxHealth { get; }
        Sprite Icon { get; }
        void onSelected(ISelectable selected);
    }
}