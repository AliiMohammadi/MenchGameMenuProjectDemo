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

        public SnapScroll Snapscroll;

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
        private GameObject ProfilePanel;
        [SerializeField]
        private GameObject DailyQuestsPanel;

        [SerializeField]
        private GameObject ShopCashPanel;
        [SerializeField]
        private GameObject ShopDicePanel;
        [SerializeField]
        private GameObject ShopLogoPanel;

        [SerializeField]
        private GameObject LeaderBoardPanel;


        void Start()
        {
            MenuPanels = this;
        }
        /// <summary>
        /// این تابعه وضعیت اینام پنجره هارو داخل کلاس اصلی منو قرار میده
        /// </summary>
        /// <param name="windwostate"></param>
        void ChangeWindowState(GameMenu.GameWindwos windwostate)
        {
            GameMenu.Gamemenu.CurrentWindow = windwostate;
        }

        //این قسمت توابع نمایش پتجره های منوی اصلی هست
        //با این توابع میشود پنجره هارو نمایش داد یا بستشون
        //دکمه ها از این توابع عمومی استفاده مکینن برای باز و بسته کردن پنجره ها
        public void ShowMainMenu()
        {
            SettingPanel.SetActive(false);
            ChatsPanel.SetActive(false);
            OnlineLobbyPanel.SetActive(false);
            OfflineLobbyPanel.SetActive(false);
            ProfilePanel.SetActive(false);
            DailyQuestsPanel.SetActive(false);
            MainPanel.SetActive(true);

            Snapscroll.SetTargetContent(1);

            ChangeWindowState(GameMenu.GameWindwos.Main);
        }
        public void ShowSettingsPanel()
        {
            SettingPanel.SetActive(true);
            ChangeWindowState(GameMenu.GameWindwos.Setting);
        }
        public void ShowChatsPanel()
        {
            SettingPanel.SetActive(false);
            ChatsPanel.SetActive(true);
            OnlineLobbyPanel.SetActive(false);
            OfflineLobbyPanel.SetActive(false);
            DailyQuestsPanel.SetActive(false);
            ProfilePanel.SetActive(false);
            MainPanel.SetActive(false);
            ChangeWindowState(GameMenu.GameWindwos.Chats);
        }
        public void ShowProfilePanel()
        {
            SettingPanel.SetActive(false);
            ChatsPanel.SetActive(false);
            OnlineLobbyPanel.SetActive(false);
            OfflineLobbyPanel.SetActive(false);
            DailyQuestsPanel.SetActive(false);
            MainPanel.SetActive(false);
            ProfilePanel.SetActive(true);
            ChangeWindowState(GameMenu.GameWindwos.Profile);
        }
        public void ShowOfflineLobbyPanel()
        {
            OfflineLobbyPanel.SetActive(true);
            ChangeWindowState(GameMenu.GameWindwos.OfflineLobby);
        }
        public void ShowOnlineLobbyPanel()
        {
            OfflineLobbyPanel.SetActive(true);
            ChangeWindowState(GameMenu.GameWindwos.OnlineLobby);
        }
        public void ShowDailyQuestsPanel()
        {
            DailyQuestsPanel.SetActive(true);
            ChangeWindowState(GameMenu.GameWindwos.DailyQuests);
        }

        // پنجره های مربوط به بخش فروشگاه
        public void ShowShopPanel()
        {
            Snapscroll.SetTargetContent(0);

            SettingPanel.SetActive(false);
            ChatsPanel.SetActive(false);
            OnlineLobbyPanel.SetActive(false);
            OfflineLobbyPanel.SetActive(false);
            ProfilePanel.SetActive(false);
            DailyQuestsPanel.SetActive(false);

            ChangeWindowState(GameMenu.GameWindwos.CashShop);
        }

        public void ShowCashPanel()
        {
            Snapscroll.SetTargetContent(0);

            SettingPanel.SetActive(false);
            ChatsPanel.SetActive(false);
            OnlineLobbyPanel.SetActive(false);
            DailyQuestsPanel.SetActive(false);
            OfflineLobbyPanel.SetActive(false);
            ProfilePanel.SetActive(false);

            ShopCashPanel.SetActive(true);
            ShopDicePanel.SetActive(false);
            ShopLogoPanel.SetActive(false);

            ChangeWindowState(GameMenu.GameWindwos.CashShop);
        }
        public void ShowDicePanel()
        {
            Snapscroll.SetTargetContent(0);

            SettingPanel.SetActive(false);
            ChatsPanel.SetActive(false);
            OnlineLobbyPanel.SetActive(false);
            DailyQuestsPanel.SetActive(false);
            OfflineLobbyPanel.SetActive(false);
            ProfilePanel.SetActive(false);

            ShopCashPanel.SetActive(false);
            ShopDicePanel.SetActive(true);
            ShopLogoPanel.SetActive(false);

            ChangeWindowState(GameMenu.GameWindwos.DiecShop);
        }
        public void ShowLogoPanel()
        {
            Snapscroll.SetTargetContent(0);

            SettingPanel.SetActive(false);
            ChatsPanel.SetActive(false);
            OnlineLobbyPanel.SetActive(false);
            OfflineLobbyPanel.SetActive(false);
            ProfilePanel.SetActive(false);
            DailyQuestsPanel.SetActive(false);

            ShopCashPanel.SetActive(false);
            ShopDicePanel.SetActive(false);
            ShopLogoPanel.SetActive(true);

            ChangeWindowState(GameMenu.GameWindwos.LogoShop);
        }

        //پنجره های مربوط به لیدر برد
        public void ShowLeaderBoardPanel()
        {
            Snapscroll.SetTargetContent(2);

            SettingPanel.SetActive(false);
            ChatsPanel.SetActive(false);
            OnlineLobbyPanel.SetActive(false);
            OfflineLobbyPanel.SetActive(false);
            ProfilePanel.SetActive(false);

            ShopCashPanel.SetActive(false);
            ShopDicePanel.SetActive(false);
            ShopLogoPanel.SetActive(false);
            LeaderBoardPanel.SetActive(true);

            ChangeWindowState(GameMenu.GameWindwos.LeaderBoard);
        }
    }
}
