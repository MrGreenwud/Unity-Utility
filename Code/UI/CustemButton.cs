using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Green.Tool.Utility.UI
{
    public class CustemButton : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
    {
        public UnityEvent OnEnter;
        public UnityEvent OnExit;

        [Space(15)]

        public UnityEvent OnRightClick;
        public UnityEvent OnLeftClick;
        public UnityEvent OnMidelClick;

        public void OnPointerClick(PointerEventData eventData)
        {
            if (eventData.button == PointerEventData.InputButton.Right)
                OnRightClick?.Invoke();
            else if (eventData.button == PointerEventData.InputButton.Left)
                OnLeftClick?.Invoke();
            else if (eventData.button == PointerEventData.InputButton.Middle)
                OnMidelClick?.Invoke();
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            OnEnter?.Invoke();
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            OnExit?.Invoke();
        }
    }
}