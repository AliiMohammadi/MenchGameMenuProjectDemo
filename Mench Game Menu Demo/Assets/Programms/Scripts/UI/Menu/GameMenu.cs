using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Menu
{
    public class GameMenu : MonoBehaviour
    {
        [HideInInspector]
        public static GameMenu Gamemenu;

        public enum GameWindwos
        {
            Main,Setting,Profile,Chats,LeaderBoard,OfflineLobby,OnlineLobby 
             ,CashShop,DiecShop,LogoShop,DailyQuests
        }
        /// <summary>
        /// پنجره درحال تمرکز 
        /// </summary>
        public GameWindwos CurrentWindow = GameWindwos.Main;

        private void Start()
        {
            Gamemenu = this;
        }

        public void LoadScene(string scenename)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(scenename);
            Debug.Log("Scene " + scenename + " loaded.");
        }
        public void LoadScene(int sceneindex)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneindex);
            Debug.Log("Scene " + sceneindex + "(Index scene) loaded.");
        }

        /// <summary>
        /// خروج از بازی
        /// </summary>
        public void ExitApplication()
        {
            Debug.Log("Application quit.");
            Application.Quit();
        }
    }
}
