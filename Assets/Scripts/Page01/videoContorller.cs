using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using System.IO;
using TMPro;
using System.Linq;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class videoContorller : MonoBehaviour, IPointerClickHandler
{
    // Start is called before the first frame update
    public VideoPlayer videoPlayer;
    public bool isPlaying = true;
    public bool isSlider = true;

    public GameObject pauseBtn;
    public GameObject playBtn;

    public int videoPlayerlength;


    // public GameObject pauseFullBtn;
    // public GameObject playFullBtn;
    // public GameObject Fullobj;


    public GameObject silderPlayBar;
    // public GameObject silderFullPlayBar;

    public int playtime;
    public int totaltime;
    public float currentplay = 0.001f;

    GameObject fullScreen;

    public int i = 0;
    int count = 0;

    void Start()
    {
        videoPlay();
        pauseBtnFadeIn();
        // isPlaying = true;
        fullScreen = GameObject.Find("fullScreen");

        if (fullScreen == null)
        {
            videoPause();
        }
        else
        {
            videoPlay();

        }
        //videoPlayer 재생 중 확인



        if (videoPlayer.isPlaying)
        {
            playBtn.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {

        if (isSlider)
        {
            videoSlider();
        }
        if (videoPlayer.isPlaying)
        {
            playBtn.SetActive(false);


            if (isSlider && fullScreen == null)
            {
                videoSlider();
            }






        }

    }

    public void videoPlay()
    {
        videoPlayer.Play();


        if (pauseBtn != null && pauseBtn.activeSelf == false)
        {
            pauseBtn.SetActive(true);
        }

        StartCoroutine("pauseBtnFadeIn");
        if (playBtn != null && playBtn.activeSelf == true)
        {
            playBtn.SetActive(false);
        }


        // if (Fullobj.activeSelf)
        // {
        //     playFullBtn.SetActive(false);
        //     StartCoroutine("pauseFullBtnFadeIn");
        //     pauseFullBtn.SetActive(true);
        // }

        videoPlayer.errorReceived += VideoPlayer_errorReceived;


        isPlaying = true;
    }

    void VideoPlayer_errorReceived(VideoPlayer source, string message)
    {
        Debug.Log("VideoPlayer error: " + message);
        videoPause();
    }

    public void videoPause()
    {
        videoPlayer.Pause();
        // StartCoroutine("pauseBtnFadeIn");
        pauseBtn.SetActive(false);
        playBtn.SetActive(true);

        // if (Fullobj.activeSelf)
        // {
        //     playFullBtn.SetActive(true);
        //     pauseFullBtn.SetActive(false);
        // }


        isPlaying = false;

    }


    IEnumerator pauseBtnFadeIn()
    {
        int i = 100;
        while (i > 0)
        {

            i -= 1;
            float f = i / 10.0f;

            //pauseBtn color 변경
            Color color = pauseBtn.GetComponent<Image>().color;
            color.a = f;
            pauseBtn.GetComponent<Image>().color = color;

            // if (pauseFullBtn.activeSelf)
            // {
            //     //pauseFullBtn color 변경
            //     Color color2 = pauseFullBtn.GetComponent<Image>().color;
            //     color2.a = f;
            //     pauseFullBtn.GetComponent<Image>().color = color2;
            // }


            yield return new WaitForSeconds(0.01f);
        }
    }


    IEnumerator pauseFullBtnFadeIn()
    {
        int i = 100;
        while (i > 0)
        {

            i -= 1;
            float f = i / 10.0f;

            // if (pauseFullBtn.activeSelf)
            // {
            //     //pauseFullBtn color 변경
            //     Color color2 = pauseFullBtn.GetComponent<Image>().color;
            //     color2.a = f;
            //     pauseFullBtn.GetComponent<Image>().color = color2;
            // }


            yield return new WaitForSeconds(0.01f);
        }
    }








    //mouse Click
    public void OnMouseDown()
    {
        Debug.Log("mouse Click");
        Debug.Log("isPlaying Click - " + isPlaying);

        if (isPlaying)
        {
            videoPause();
        }
        else
        {
            videoPlay();

        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        OnMouseDown();
        videoSlider();
    }

    public void videoSlider()
    {
        if (videoPlayer != null)
        {
            if (videoPlayer.length == 0)
            {
                return;
            }
            else if (videoPlayer.time == 0)
            {
                return;
            }
            else
            {
                //slider의 value값을 videoController의 currentplay에 넣어준다.
                currentplay = (float)videoPlayer.time / (float)videoPlayer.length;
                silderPlayBar.GetComponent<Slider>().value = currentplay;
            }

            //silderFullPlayBar 비활성화 체크 
            // if (silderFullPlayBar.activeSelf && silderFullPlayBar.GetComponent<Slider>() != null)
            // {
            //     silderFullPlayBar.GetComponent<Slider>().value = currentplay;
            // }

            //videoplayer의 현재 재생시간을 가져온다.            
            playtime = (int)videoPlayer.time;

            //videoplayer의 전체 재생시간을 가져온다.   
            totaltime = (int)videoPlayer.length;

            //videoplayer의 현재 재생시간을 전체 재생시간으로 나누어서 0~1사이의 값으로 만든다.     
            currentplay = (float)playtime / (float)totaltime;


        }

        //소수점 3자리까지 표시
        // currentplay = (float)System.Math.Round(currentplay, 5);


        // //slider의 value값을 currentplay값으로 변경
        // silderPlayBar.GetComponent<Slider>().value = currentplay;









    }














}
