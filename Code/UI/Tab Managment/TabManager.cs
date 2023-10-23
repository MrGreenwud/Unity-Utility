using System;
using System.Collections.Generic;
using UnityEngine;

namespace Green.Tool.Utility.UI.TabManagment
{
    public class TabManager : MonoBehaviour
    {
        [SerializeField] private Tab[] m_Tabs;

        public Tab CurrentOpenTab { get; private set; }

        public void SwichTab(Tab tab)
        {
            if (tab == null)
                throw new ArgumentNullException();

            if (CurrentOpenTab != null)
                CurrentOpenTab.Close();

            if (tab == CurrentOpenTab)
            {
                CurrentOpenTab = null;
                return;
            }

            CurrentOpenTab = tab;
            CurrentOpenTab.Open();
        }

        public T GetTab<T>() where T : Tab
        {
            foreach (Tab tab in m_Tabs)
                if (tab is T tTab)
                    return tTab;

            Debug.LogWarning($"Try to get non-existent tab: {typeof(T)}!");
            return null;
        }
    }
}