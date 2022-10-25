using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using System.IO;
using TMPro;
using System.Linq;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class videoContorller1 : MonoBehaviour, IPointerClickHandler
{
    // Start is called before the first frame update
    public VideoPlayer videoPlayer;
    public bool isPlaying = true;
    public bool isSlider01 = true;

    public GameObject pauseBtn;
    public GameObject playBtn;
    public GameObject silderPlayBar;
    public int playtime;
    public int totaltime;
    public float currentplay;

    void Start()
    {
        // isPlaying = true;
        videoPlay();
    }

    // Update is called once per frame
    void Update()
    {

        if (isSlider01)
        {
            videoSlider();
        }

    }

    public void videoPlay()
    {
        videoPlayer.Play();
        pauseBtn.SetActive(true);
        StartCoroutine("pauseBtnFadeIn");
        playBtn.SetActive(false);
        isPlaying = true;
    }

    public void videoPause()
    {
        videoPlayer.Pause();
        pauseBtn.SetActive(false);
        playBtn.SetActive(true);
        isPlaying = false;

    }


    IEnumerator pauseBtnFadeIn()
    {
        int i = 10;
        while (i > 0)
        {
            // Debug.Log("i : " + i);
            i -= 1;
            float f = i / 10.0f;

            //pauseBtn color 변경
            Color color = pauseBtn.GetComponent<Image>().color;
            color.a = f;
            pauseBtn.GetComponent<Image>().color = color;


            yield return new WaitForSeconds(0.1f);
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
        //videoplayer의 현재 재생시간을 가져온다.
        playtime = (int)videoPlayer.time;
        //videoplayer의 전체 재생시간을 가져온다.   
        totaltime = (int)videoPlayer.length;
        //videoplayer의 현재 재생시간을 전체 재생시간으로 나누어서 0~1사이의 값으로 만든다.     
        currentplay = (float)playtime / (float)totaltime;
        //slider의 value값을 현재 재생시간으로 변경한다.
        silderPlayBar.GetComponent<Slider>().value = currentplay;
    }

    public void movePlaytime(int timer)
    {
        videoPlayer.time = timer;
        Debug.Log(" timer - " + timer);

    }














}
