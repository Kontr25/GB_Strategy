using System.Collections.Generic;
using _Scripts.Abstraction;
using _Scripts.Abstraction.Commands;
using _Scripts.Abstraction.Commands.CommandsInterfaces;
using UnityEngine;
using Random = UnityEngine.Random;

namespace _Scripts.Core
{
    public class MainBuilding : CommandExecutorBase<IProduceUnitCommand>, ISelectable, IAttackable
    {
        public float Health => _health;
        public float MaxHealth => _maxHealth;
        public Transform PivotPoint => _transform;
        public Sprite Icon => _icon;

        [SerializeField] private Transform _transform;
        [SerializeField] private Transform _unitsParent;
        [SerializeField] private float _maxHealth = 1000f;
        [SerializeField] private Sprite _icon;

        private float _health = 1000f;
        
        public void onSelected(ISelectable selected)
        {
            
        }

        public override void ExecuteSpecificCommand(IProduceUnitCommand command)
        {
            Vector3 randomPosition = new Vector3(Random.Range(-10f, 10f), 0, Random.Range(-10f, 10f));
            Instantiate(command.UnitPrefab, randomPosition, Quaternion.identity, _unitsParent);
        }
    }
}