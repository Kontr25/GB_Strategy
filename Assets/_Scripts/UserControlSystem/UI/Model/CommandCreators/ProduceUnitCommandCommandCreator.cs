using System;
using _Scripts.Abstraction.Commands.CommandsInterfaces;
using _Scripts.UserControlSystem.CommandRealization;
using _Scripts.Utils;
using Zenject;
public class ProduceUnitCommandCommandCreator : CommandCreatorBase<IProduceUnitCommand>
{
    [Inject] private AssetsContext _context;
    protected override void classSpecificCommandCreation(Action<IProduceUnitCommand> creationCallback)
    {
        creationCallback?.Invoke(_context.Inject(new
            ProduceUnitCommandHeir()));
    }
}