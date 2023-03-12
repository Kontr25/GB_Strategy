using System;
using _Scripts.Abstraction.Commands.CommandsInterfaces;
using _Scripts.UserControlSystem.CommandRealization;
using _Scripts.Utils;
using Zenject;

namespace _Scripts.UserControlSystem.UI.Model.CommandCreators
{
    public class StopCommandCommandCreator : CommandCreatorBase<IStopCommand>
    {
        [Inject] private AssetsContext _context;
        protected override void classSpecificCommandCreation(Action<IStopCommand> creationCallback)
        {
            creationCallback?.Invoke(_context.Inject(new
                StopCommand()));
        }
    }
}