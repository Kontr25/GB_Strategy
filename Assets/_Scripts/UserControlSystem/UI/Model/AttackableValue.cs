using _Scripts.Abstraction;
using UnityEngine;

namespace _Scripts.UserControlSystem.UI.Model
{
    [CreateAssetMenu(fileName = nameof(AttackableValue), menuName = "Strategy Game/" + nameof(AttackableValue))]
    public class AttackableValue :  ScriptableObjectValueBase<IAttackable>
    {
        
    }
}