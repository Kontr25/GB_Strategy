using System.Collections.Generic;
using System.Linq;
using _Scripts.Abstraction;
using UnityEngine;

namespace _Scripts.UserControlSystem.UI.Presenter
{
    public class MouseInteractionPresenter : MonoBehaviour
    {
        [SerializeField] private Camera _camera;
        [SerializeField] private SelectableValue _selectedObject;

        private List<IHighlightable> _highlightables = new List<IHighlightable>();

        private void Update()
        {
            if (!Input.GetMouseButtonUp(0))
            {
                return;
            }

            DisableAllSelection();
            var hits = Physics.RaycastAll(_camera.ScreenPointToRay(Input.mousePosition));
            if (hits.Length == 0)
            {
                return;
            }

            var selectable = hits
                .Select(hit => hit.collider.GetComponentInParent<ISelectable>())
                .FirstOrDefault(c => c != null);
            _selectedObject.SetValue(selectable);
            
            var highlightable = hits
                .Select(hit => hit.collider.GetComponentInParent<IHighlightable>())
                .FirstOrDefault(c => c != null);
            EnableSelectionOn(highlightable);
        }

        private void DisableAllSelection()
        {
            if (_highlightables.Count > 0)
            {
                for (int i = 0; i < _highlightables.Count; i++)
                {
                    _highlightables[i].Highlight();
                }
                _highlightables.Clear();
            }
        }
        
        private void EnableSelectionOn(IHighlightable highlightable)
        {
            if (highlightable != null)
            {
                _highlightables.Add(highlightable);
                highlightable.Highlight();
            }
        }
    }
}