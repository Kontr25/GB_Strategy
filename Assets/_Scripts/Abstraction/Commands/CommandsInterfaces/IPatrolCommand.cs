using UnityEngine;

namespace _Scripts.Abstraction.Commands.CommandsInterfaces
{
    public interface IPatrolCommand: ICommand
    {
        public Vector3 From { get; }
        public Vector3 To { get; }
    }
}