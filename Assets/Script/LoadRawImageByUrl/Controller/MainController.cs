using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace LoadRawImageByUrl
{
    public class MainController : MonoBehaviour
    {
        public RawImage RawImage_BananaAlllllll;


        private Texture testTexture;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        IEnumerator DownloadPngByUrl(string url)
        {
            WWW www = new WWW(url);

            //Wrong
            //yield return www

            while (www.isDone == false)
            {
                yield return 0;
            }

            Debug.Log("Complete Download Time: " + DateTime.Now.ToString());
            testTexture = www.texture;
        }

        public void DownloadUrlPng()
        {
            Debug.Log("Start Download Time: " + DateTime.Now.ToString());
            StartCoroutine(DownloadPngByUrl("http://www.fullyu.com/ueditor/php/upload/image/20151010/1444459286830317.jpg"));
        }

        public void SetRawImage()
        {
            RawImage_BananaAlllllll.texture = testTexture;
        }

        public void ClearRawImage()
        {
            RawImage_BananaAlllllll.texture = null;
        }
    }
}