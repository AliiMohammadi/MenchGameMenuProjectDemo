using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Menu
{
    /// <summary>
    /// ااین کلاس برای کنترل صفحه های منو اصلی
    /// برای نمایش دادنشون و غیر فعال کردنشون 
    /// مثلا برای نمایش پنل تنظیمات باید تابع مربوطه را فراخوااند.
    /// </summary>
    public class MenuPanelManager : MonoBehaviour
    {
        [HideInInspector]
        public static MenuPanelManager MenuPanels;

        [SerializeField]
        private GameObject MainPanel;
        [SerializeField]
        private GameObject SettingPanel;
        [SerializeField]
        private GameObject ChatsPanel;
        [SerializeField]
        private GameObject OnlineLobbyPanel;
        [SerializeField]
        private GameObject OfflineLobbyPanel;

        [SerializeField]
        private GameObject ShopCashPanel;
        [SerializeField]
        private GameObject ShopDicePanel;
        [SerializeField]
        private GameObject ShopLogoPanel;

        void Start()
        {
            MenuPanels = this;
        }

        public void ShowMainMenu()
        {
            SettingPanel.SetActive(false);
            ChatsPanel.SetActive(false);
            OnlineLobbyPanel.SetActive(false);
            OfflineLobbyPanel.SetActive(false);
            MainPanel.SetActive(true);
        }
        public void ShowSettingsPanel()
        {
            SettingPanel.SetActive(true);
        }
        public void ShowChatsPanel()
        {
            SettingPanel.SetActive(false);
            ChatsPanel.SetActive(true);
            OnlineLobbyPanel.SetActive(false);
            OfflineLobbyPanel.SetActive(false);
            MainPanel.SetActive(false);
        }
        public void ShowOfflineLobbyPanel()
        {
            OfflineLobbyPanel.SetActive(true);
        }
        public void ShowOnlineLobbyPanel()
        {
            OfflineLobbyPanel.SetActive(true);
        }

        // پنجره های مربوط به بخش فروشگا
        public void ShowCashPanel()
        {
            ShopCashPanel.SetActive(true);
            ShopDicePanel.SetActive(false);
            ShopLogoPanel.SetActive(false);
        }
        public void ShowDicePanel()
        {
            ShopCashPanel.SetActive(false);
            ShopDicePanel.SetActive(true);
            ShopLogoPanel.SetActive(false);
        }
        public void ShowLogoPanel()
        {
            ShopCashPanel.SetActive(false);
            ShopDicePanel.SetActive(false);
            ShopLogoPanel.SetActive(true);
        }
    }
}
