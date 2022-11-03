using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class sliderController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    // Start is called before the first frame update

    //videoController 연결
    videoContorller videoContorller;
        dataController DataController;

    void Start()
    {
        //videoController 연결
        videoContorller = FindObjectOfType<videoContorller>();
        DataController = FindObjectOfType<dataController>();


    }

    // Update is called once per frame
    void Update()
    {

        if (videoContorller != null)
        {
            if (videoContorller.isPlaying)
            {
                videoContorller.isSlider = true;
            }
        }



    }


    public void OnPointerDown(PointerEventData eventData)
    {
        videoContorller.videoPause();
        Debug.Log("OnPointerDown");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        videoContorller.videoPlay();
        Debug.Log("OnPointerUp");
    }


    //slider의 value값이 변경되었을때 호출되는 함수
    public void OnSliderValueChanged()
    {
        //slider의 value값을 videoController의 currentplay에 넣어준다.

        if (videoContorller.isPlaying == false)
        {


          


            if(videoContorller.totaltime == 0){
               videoContorller.videoPlayer.time = this.GetComponent<Slider>().value *  DataController.selectGridData.playtime;
            }else{
                  videoContorller.videoPlayer.time = this.GetComponent<Slider>().value * videoContorller.totaltime;
            }
          

            Debug.Log("videoPlayer - " + videoContorller.videoPlayer.length.ToString());  //645
            Debug.Log("value - " + this.GetComponent<Slider>().value.ToString());   //0.18
            Debug.Log("time - " +  videoContorller.videoPlayer.time.ToString());    //



            videoContorller.isSlider = false;
        }


    }








}
