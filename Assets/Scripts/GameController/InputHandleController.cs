using UnityEngine;
using UnityEngine.EventSystems;

namespace GameController
{
    public class InputHandleController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {
        [SerializeField] private Camera _camera;

        private TowerController _selectedTowerController;

        public void OnPointerDown(PointerEventData eventData)
        {
            if (Physics.Raycast(_camera.ScreenPointToRay(Input.mousePosition), out RaycastHit hit))
            {
                if (hit.transform.TryGetComponent(out TowerController towerController))
                {
                    _selectedTowerController = towerController;
                }
            }
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            if (Physics.Raycast(_camera.ScreenPointToRay(Input.mousePosition), out RaycastHit hit))
            {
                if (hit.transform.TryGetComponent(out TowerController towerController) &&
                    _selectedTowerController != null &&
                    towerController != _selectedTowerController)
                {
                    _selectedTowerController.Attack(towerController);
                }
            }
        }
    }
}