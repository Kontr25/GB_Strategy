using System;
using _Scripts.Abstraction;
using UnityEngine;

namespace _Scripts.UserControlSystem.UI.Model
{
    [CreateAssetMenu(fileName = nameof(SelectableValue), menuName = "Strategy Game/" + nameof(SelectableValue), order = 0)]
    public class SelectableValue :  ScriptableObjectValueBase<ISelectable>
    {
        
    }
}