using _Scripts.Abstraction.Commands.CommandsInterfaces;
using UnityEngine;

namespace _Scripts.UserControlSystem.CommandRealization
{
    public class PatrolCommand : IPatrolCommand
    {
        public PatrolCommand(Vector3 pivotPointPosition, Vector3 groundClick)
        {
            From = pivotPointPosition;
            To = groundClick;
        }

        public Vector3 From { get; }
        public Vector3 To { get; }
    }
}