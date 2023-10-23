using System;
using UnityEngine;

namespace Green.Tool.Utility.UI.TabManagment
{
    public class TabModel : MonoBehaviour
    {
        public event Action OnOpen;
        public event Action OnClose;

        public void Open()
        {
            Opened();
            OnOpen?.Invoke();
        }

        public void Close()
        {
            Closed();
            OnClose?.Invoke();
        }

        protected virtual void Opened() { }
        protected virtual void Closed() { }
    }
}
