using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SaveAndRetrieve;
namespace GameOption
{
    /// <summary>
    /// کلاس با ویژگی های قابل ذخیره سازی این بازی
    /// </summary>
    public class GameSetting 
    {
        public enum GameLanguage
        {
            Persian , English
        }

        public float MusicVolum = 1f;
        public float SoundEffectsVolum = 1f;

        public GameLanguage Language = GameLanguage.English;

        public GameSetting(float musicvolum , float soundeffectvolume , GameLanguage language)
        {
            MusicVolum = musicvolum;
            SoundEffectsVolum = soundeffectvolume;

            Language = language;
        }

        /// <summary>
        /// اطلاعات ذخیره شده رو از داخل حافظه میخواند و در قالب کلاس تنظیمات قرار میدهد
        /// </summary>
        /// <returns></returns>
        public static GameSetting GetSavedSettings()
        {
            return new GameSetting(SaveData.GameOptions.GameMusicVolume, SaveData.GameOptions.GameSoundEffectsVolume, ConvertStringtoEnum(SaveData.GameOptions.GameLanguage));
        }
        /// <summary>
        /// ذخیره تظیمات 
        /// </summary>
        /// <param name="settings"></param>
        public static void SaveSetting(GameSetting settings)
        {
            SaveData.GameOptions.GameMusicVolume = settings.MusicVolum;
            SaveData.GameOptions.GameSoundEffectsVolume = settings.SoundEffectsVolum;
            SaveData.GameOptions.GameLanguage = ConvertEnumToString(settings.Language);
        }

        static GameLanguage ConvertStringtoEnum(string name)
        {
            switch (name)
            {
                case "English":
                    return GameLanguage.English;

                case "Persian":
                    return GameLanguage.Persian;

                default:
                    return GameLanguage.English;
            }
        }
        static string ConvertEnumToString(GameLanguage language)
        {
            return language.ToString();
        }
    }
}
