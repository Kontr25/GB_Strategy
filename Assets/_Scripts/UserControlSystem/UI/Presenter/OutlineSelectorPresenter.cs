using _Scripts.Abstraction;
using _Scripts.UserControlSystem.UI.Model;
using _Scripts.UserControlSystem.UI.View;
using UnityEngine;
public class OutlineSelectorPresenter : MonoBehaviour
{
    [SerializeField] private SelectableValue _selectable;
    
    private OutlineSelector[] _outlineSelectors;
    private ISelectable _currentSelectable;
    private void Start()
    {
        _selectable.OnSelected += onSelected;
    }
    private void onSelected(ISelectable selectable)
    {
        if (_currentSelectable == selectable)
        {
            return;
        }
        
        SetSelected(_outlineSelectors, false);
        _outlineSelectors = null;
        
        if (selectable != null)
        {
            _outlineSelectors = (selectable as Component).GetComponentsInParent<OutlineSelector>();
            SetSelected(_outlineSelectors, true);
        }
        else
        {
            if (_outlineSelectors != null)
            {
                SetSelected(_outlineSelectors, false);
            }
        }

        _currentSelectable = selectable;
        
        static void SetSelected(OutlineSelector[] selectors, bool value)
        {
            if (selectors != null)
            {
                for (int i = 0; i < selectors.Length; i++)
                {
                    selectors[i].SetSelected(value);
                }
            }
        }
    }
}
