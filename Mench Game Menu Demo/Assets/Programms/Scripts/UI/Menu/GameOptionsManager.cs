using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameOption
{
    public class GameOptionsManager : MonoBehaviour
    {
        [HideInInspector]
        public static GameOptionsManager Gamesettings;

        /// <summary>
        /// اطلاعات سیو بازی 
        /// </summary>
        public GameSetting GameOptions;

        void Start()
        {
            Gamesettings = this;
            Refresh();
        }

        void LoadSavedSettingData()
        {
            GameOptions = GameSetting.GetSavedSettings();
            Debug.Log("Setting Data Loaded.");
        }

        /// <summary>
        /// ذخیره داده های حال در حافظه
        /// </summary>
        public void SaveCurrentSettingData()
        {
            GameSetting.SaveSetting(GameOptions);
        }

        public void Refresh()
        {
            LoadSavedSettingData();
        }
    }
}
