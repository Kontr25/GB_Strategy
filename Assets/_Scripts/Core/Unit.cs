using System.Collections.Generic;
using _Scripts.Abstraction;
using UnityEngine;

namespace _Scripts.Core
{
    public class Unit : MonoBehaviour, IHighlightable, ISelectable
    {
        public float Health => _health;
        public float MaxHealth => _maxHealth;
        public Sprite Icon => _icon;
        
        public List<Outline> Outlines => _outlines;
        
        [SerializeField] private float _maxHealth = 1000f;
        [SerializeField] private Sprite _icon;
        [SerializeField] private List<Outline> _outlines;

        private float _health = 1000f;
        private void Start()
        {
            _health = _maxHealth;
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