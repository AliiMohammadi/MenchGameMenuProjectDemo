using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GameOption
{
    /// <summary>
    /// اسکریپت جهت گزاشتن تنظیمات بازی و یا ذخیره تنظیمات جدید.
    /// این کلاس میتواند بدون محدودیت بر هر سینی اضافه شود
    /// </summary>
    public class GameOptionsManager : MonoBehaviour
    {
        [Header("Setting UI elements refrences.")]
        [SerializeField]
        private Scrollbar MusicVolumElement;
        [SerializeField]
        private Scrollbar SoundEffectsVolumElement;

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
            print(GameOptions.SoundEffectsVolum);
            Debug.Log("Setting Data Loaded.");
        }
        void SetSavedSettingData()
        {
            MusicVolumElement.value = GameOptions.MusicVolum;
            SoundEffectsVolumElement.value = GameOptions.SoundEffectsVolum;
            //زبان اضافه شود بعدا
        }

        /// <summary>
        /// زمانی که فرم مقدار عانصر یو ای تنظیمات عوض میشود این تواببع خوانده شود تا مقدایر جدید 
        /// اضافه شوند
        /// </summary>
        public void UpdateSettings()
        {
            GameOptions.MusicVolum = MusicVolumElement.value;
            GameOptions.SoundEffectsVolum = SoundEffectsVolumElement.value;

            //زبان اضافه شود بعدا
            SaveCurrentSettingData();
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
            SetSavedSettingData();
        }
    }
}
