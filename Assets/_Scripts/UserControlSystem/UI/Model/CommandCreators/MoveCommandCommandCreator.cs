using System;
using _Scripts.Abstraction.Commands.CommandsInterfaces;
using _Scripts.UserControlSystem.CommandRealization;
using _Scripts.UserControlSystem.UI.Model;
using _Scripts.Utils;
using UnityEngine;
using Zenject;
public class MoveCommandCommandCreator : CommandCreatorBase<IMoveCommand>
{
    [Inject] private AssetsContext _context;
    
    private Action<IMoveCommand> _creationCallback;
    
    [Inject]
    private void Init(Vector3Value groundClicks)
    {
        groundClicks.OnSelected += onNewValue;
    }
    private void onNewValue(Vector3 groundClick)
    {
        _creationCallback?.Invoke(_context.Inject(new
            MoveCommand(groundClick)));
        _creationCallback = null;
    }
    protected override void
        classSpecificCommandCreation(Action<IMoveCommand> creationCallback)
    {
        _creationCallback = creationCallback;
    }
    public override void ProcessCancel()
    {
        base.ProcessCancel();
        _creationCallback = null;
    }
}
