using UnityEngine;

namespace _Scripts.Abstraction.Commands.CommandsInterfaces
{
    public interface IProduceUnitCommand : ICommand
    {
        GameObject UnitPrefab { get; }
    }
}