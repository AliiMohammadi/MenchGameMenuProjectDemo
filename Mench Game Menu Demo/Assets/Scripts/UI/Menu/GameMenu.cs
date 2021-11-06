using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Menu
{
    public class GameMenu : MonoBehaviour
    {
        [HideInInspector]
        public GameMenu Gamemenu;

        public enum GameWindwos
        {
            Main,Setting,Profile,Chats
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
        }
        /// <summary>
        /// خروج از بازی
        /// </summary>
        public void ExitApplication()
        {
            Debug.Log("Application quit. at: " + System.DateTime.Now);
            Application.Quit();
        }
    }
}
