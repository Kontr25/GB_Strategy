using UnityEngine;

namespace _Scripts.Abstraction.Commands.CommandsInterfaces
{
    public interface IMoveCommand: ICommand
    {
        public Vector3 Target { get; }
    }
}