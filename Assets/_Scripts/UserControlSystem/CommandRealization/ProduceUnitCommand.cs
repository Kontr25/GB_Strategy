using _Scripts.Abstraction.Commands.CommandsInterfaces;
using _Scripts.Utils;
using UnityEngine;

public class ProduceUnitCommand : IProduceUnitCommand
{
    public GameObject UnitPrefab => _unitPrefab;
    [InjectAsset("Chomper")] private GameObject _unitPrefab;
}