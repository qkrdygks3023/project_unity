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
    



    int playtime;
    int totaltime;
    float currentplay;


    void Start()
    {
        videoContorller = FindObjectOfType<videoContorller>();
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
            videoContorller = FindObjectOfType<videoContorller>();

            videoContorller.GetComponent<videoContorller>().videoPlay();
            videoContorller.GetComponent<videoContorller>().videoSlider();


            fullScreen.SetActive(false);
        }
        else
        {
            //fullScreen 활성화

            fullScreen.SetActive(true);
            Debug.Log("play -- " + videoContorller.GetComponent<videoContorller>().playtime); // (int)videoContorller.GetComponent<videoContorller>().playtime;

            videoContorller = FindObjectOfType<videoContorller>();


            //await 1초 대기 

            // videoContorller01.GetComponent<videoContorller1>().movePlaytime((int)videoContorller.GetComponent<videoContorller>().videoPlayer.time);

            // videoContorller01.GetComponent<videoContorller1>().movePlaytime(300);



           




        }
    }
}
