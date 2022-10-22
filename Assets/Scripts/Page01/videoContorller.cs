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
    public GameObject silderPlayBar;
    public int playtime;
    public int totaltime;
    public float currentplay;

    void Start()
    {
        videoPlay();
    }

    // Update is called once per frame
    void Update()
    {
         
        if (isSlider)
        {
           videoSlider();
        }

    }

    public void videoPlay()
    {
        videoPlayer.Play();
    }

    public void videoPause()
    {
        videoPlayer.Pause();

    }

    //mouse Click
    public void OnMouseDown()
    {
        Debug.Log("mouse Click");
        if (isPlaying)
        {
            videoPause();
            pauseBtn.SetActive(false);
            playBtn.SetActive(true);
            isPlaying = false;
        }
        else
        {
            videoPlay();
            pauseBtn.SetActive(true);
            playBtn.SetActive(false);
            isPlaying = true;
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














}
