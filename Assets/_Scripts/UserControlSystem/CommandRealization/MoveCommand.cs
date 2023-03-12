using _Scripts.Abstraction.Commands.CommandsInterfaces;
using UnityEngine;

namespace _Scripts.UserControlSystem.CommandRealization
{
    public class MoveCommand : IMoveCommand
    {
        public Vector3 Target { get; }
        public MoveCommand(Vector3 target)
        {
            Target = target;
        }
    }
}