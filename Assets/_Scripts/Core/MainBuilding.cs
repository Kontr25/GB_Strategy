using System;
using System.Collections.Generic;
using _Scripts.Abstraction;
using UnityEngine;
using Random = UnityEngine.Random;

namespace _Scripts.Core
{
    public class MainBuilding : MonoBehaviour, IUnitProducer, IHighlightable, ISelectable
    {
        public float Health => _health;
        public float MaxHealth => _maxHealth;
        public Sprite Icon => _icon;

        public List<Outline> Outlines => _outlines;
        
        [SerializeField] private GameObject _unitPrefab;
        [SerializeField] private Transform _unitsParent;

        [SerializeField] private float _maxHealth = 1000f;
        [SerializeField] private Sprite _icon;
        [SerializeField] private List<Outline> _outlines;

        private float _health = 1000f;

        public void ProduceUnit()
        {
            Vector3 randomPosition = new Vector3(Random.Range(-10f, 10f), 0, Random.Range(-10f, 10f));
            Instantiate(_unitPrefab, randomPosition, Quaternion.identity, _unitsParent);
        }
        
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
    }
}