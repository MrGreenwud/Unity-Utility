using System;
using UnityEngine;

namespace Green.Tool.Utility.UI.TabManagment
{
    [RequireComponent(typeof(TabModel), typeof(TabView))]
    public class Tab : MonoBehaviour
    {
        private TabModel m_TabModel;
        private TabView m_TabView;

        private void Awake()
        {
            m_TabModel = GetComponent<TabModel>();
            m_TabView = GetComponent<TabView>();
        }

        private void OnEnable()
        {
            OpenAddListener(m_TabView.Show);
            CloseAddListener(m_TabView.Hide);
        }

        private void OnDisable()
        {
            OpenRemoveListener(m_TabView.Show);
            CloseRemoveListener(m_TabView.Hide);
        }

        public void Open() => m_TabModel.Open();

        public void Close() => m_TabModel.Close();

        public void OpenAddListener(Action action) => m_TabModel.OnOpen += action;
        public void OpenRemoveListener(Action action) => m_TabModel.OnOpen -= action;

        public void CloseAddListener(Action action) => m_TabModel.OnClose += action;
        public void CloseRemoveListener(Action action) => m_TabModel.OnClose -= action;
    }
}