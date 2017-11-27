using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace WebGL_FullScreenTest
{
    public class MainController : MonoBehaviour
    {
        public Text Text_ClickInfoFullScreeTip;
        public Text Text_MainScene;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void OnText_ClickInfoFullScreeTipClick()
        {
            Text_ClickInfoFullScreeTip.gameObject.SetActive(false);
            Text_MainScene.gameObject.SetActive(true);

            Screen.fullScreen = true;
        }

        public void OnText_MainSceneClick()
        {
            bool isFullScreen = Screen.fullScreen;
            Text_MainScene.text = "Is FullScreen: " + isFullScreen;
        }
    }
}