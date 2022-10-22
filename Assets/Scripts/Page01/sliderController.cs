using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderController : MonoBehaviour
{
    // Start is called before the first frame update

    //videoController 연결
    videoContorller videoContorller;

    void Start()
    {
    //videoController 연결
        videoContorller = FindObjectOfType<videoContorller>();
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetMouseButton(0)) 
        {
            if(videoContorller.isPlaying){
                videoContorller.isSlider = false;
            }
        } else {
            if(videoContorller.isPlaying){
                videoContorller.isSlider = true;
            }
        }

    }

        //slider의 value값이 변경되었을때 호출되는 함수
    public void OnSliderValueChanged()
    {
        //slider의 value값을 videoController의 currentplay에 넣어준다.
        videoContorller.videoPlayer.time = this.GetComponent<Slider>().value * videoContorller.videoPlayer.length;


       
    }

     
      
}
