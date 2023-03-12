using System.Collections.Generic;
using _Scripts.Abstraction;
using UnityEngine;

namespace _Scripts.Core
{
    public class Unit : MonoBehaviour, ISelectable, IAttackable
    {
        public float Health => _health;
        public float MaxHealth => _maxHealth;
        public Sprite Icon => _icon;
        public Transform PivotPoint => _transform;
        
        [SerializeField] private Transform _transform;
        [SerializeField] private float _maxHealth = 1000f;
        [SerializeField] private Sprite _icon;

        private float _health = 1000f;
        private void Start()
        {
            _health = _maxHealth;
        }
        
        public void onSelected(ISelectable selected)
        {
            throw new System.NotImplementedException();
        }
    }
}