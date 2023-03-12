using _Scripts.UserControlSystem.UI.Model;
using UnityEngine;
using Zenject;

namespace _Scripts
{
    [CreateAssetMenu(fileName = nameof(AssetsInstaller), menuName = "Installers/" + nameof(AssetsInstaller))]
    public class AssetsInstaller: ScriptableObjectInstaller<AssetsInstaller>
    {
        [SerializeField] private AssetsContext _legacyContext;
        [SerializeField] private Vector3Value _groundClicksRMB;
        [SerializeField] private AttackableValue _attackableClicksRMB;
        [SerializeField] private SelectableValue _selectables;
        public override void InstallBindings()
        {
            Container.BindInstances(_legacyContext, _groundClicksRMB,
                _attackableClicksRMB, _selectables);
        }
    }
}