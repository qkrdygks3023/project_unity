using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fullScreenBtn : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject fullScreen;
    public GameObject smallScreen;



    videoContorller videoContorller;
    videoContorller1 videoContorller01;



    int playtime;
    int totaltime;
    float currentplay;


    void Start()
    {
        videoContorller = FindObjectOfType<videoContorller>();
        videoContorller01 = FindObjectOfType<videoContorller1>();




    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(fullScreen.GetComponent<videoContorller>().videoPlayer.time);

    }

    public void fullScreenSet()
    {

        if (fullScreen.activeSelf)
        {
            videoContorller01 = FindObjectOfType<videoContorller1>();
            videoContorller = FindObjectOfType<videoContorller>();

            videoContorller01.GetComponent<videoContorller1>().videoPlayer.Pause();
            videoContorller.GetComponent<videoContorller>().videoPlayer.time = (float)videoContorller01.GetComponent<videoContorller1>().playtime;
            videoContorller.GetComponent<videoContorller>().videoPlay();
            videoContorller.GetComponent<videoContorller>().videoSlider();


            fullScreen.SetActive(false);
        }
        else
        {
            //fullScreen 활성화

            fullScreen.SetActive(true);
            videoContorller.GetComponent<videoContorller>().videoPause();

            // videoContorller01.GetComponent<videoContorller1>().videoPlayer.time = (float)videoContorller.GetComponent<videoContorller>().playtime;

            //fullScreen 비디오 재생
            // videoContorller01.GetComponent<videoContorller1>().videoPlay();

            Debug.Log("play -- " + videoContorller.GetComponent<videoContorller>().playtime); // (int)videoContorller.GetComponent<videoContorller>().playtime;


            //videoContorller01 400초 후 
            videoContorller01 = FindObjectOfType<videoContorller1>();
            videoContorller = FindObjectOfType<videoContorller>();


            //await 1초 대기 

            // videoContorller01.GetComponent<videoContorller1>().movePlaytime((int)videoContorller.GetComponent<videoContorller>().videoPlayer.time);

            // videoContorller01.GetComponent<videoContorller1>().movePlaytime(300);



            videoContorller01.GetComponent<videoContorller1>().videoPlay();
            videoContorller01.GetComponent<videoContorller1>().videoSlider();


            videoContorller01.GetComponent<videoContorller1>().videoPlayer.time = (float)videoContorller.GetComponent<videoContorller>().playtime;




        }
    }
}
