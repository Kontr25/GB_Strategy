using System.Collections.Generic;
using _Scripts.Abstraction;
using _Scripts.Abstraction.Commands;
using _Scripts.Abstraction.Commands.CommandsInterfaces;
using UnityEngine;
using Random = UnityEngine.Random;

namespace _Scripts.Core
{
    public class MainBuilding : CommandExecutorBase<IProduceUnitCommand>, IHighlightable, ISelectable
    {
        public float Health => _health;
        public float MaxHealth => _maxHealth;
        public Sprite Icon => _icon;

        public List<Outline> Outlines => _outlines;
        
        [SerializeField] private Transform _unitsParent;

        [SerializeField] private float _maxHealth = 1000f;
        [SerializeField] private Sprite _icon;
        [SerializeField] private List<Outline> _outlines;

        private float _health = 1000f;
        
        public void Highlight()
        {
            for (int i = 0; i < _outlines.Count; i++)
            {
                _outlines[i].enabled = !_outlines[i].enabled;
            }
        }
        
        public void onSelected(ISelectable selected)
        {
            throw new System.NotImplementedException();
        }

        public override void ExecuteSpecificCommand(IProduceUnitCommand command)
        {
            Vector3 randomPosition = new Vector3(Random.Range(-10f, 10f), 0, Random.Range(-10f, 10f));
            Instantiate(command.UnitPrefab, randomPosition, Quaternion.identity, _unitsParent);
        }
    }
}