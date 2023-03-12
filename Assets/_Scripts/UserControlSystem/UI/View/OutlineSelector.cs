using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace _Scripts.UserControlSystem.UI.View
{
    public class OutlineSelector : MonoBehaviour
    {
        [SerializeField] private List<Outline> _outlineComponents;
        private bool _isSelectedCache;

        private void Start() => DisableOutline();
        public void SetSelected(bool isSelected)
        {
            if (isSelected == _isSelectedCache)
            {
                return;
            }

            if (isSelected)
            {
                EnableOutline();
            }
            else
            {
                DisableOutline();
            }
            _isSelectedCache = isSelected;
        }

        private void EnableOutline()
        {
            for (int i = 0; i < _outlineComponents.Count; i++)
            {
                _outlineComponents[i].enabled = true;
            }
        }
        
        
        private void DisableOutline()
        {
            for (int i = 0; i < _outlineComponents.Count; i++)
            {
                _outlineComponents[i].enabled = false;
            }
        }
    }
}