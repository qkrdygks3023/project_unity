using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class soundSlider01 : MonoBehaviour
{
    // Start is called before the first frame update
    videoContorller1 videoContorller;
    void Start()
    {
        videoContorller = FindObjectOfType<videoContorller1>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //slider의 value값이 변경되었을때 호출되는 함수
    public void OnSliderVolume()
    {
        //  videoContorller 사운드 조절
        videoContorller.videoPlayer.SetDirectAudioVolume(0, this.GetComponent<Slider>().value);

    }
}
