using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using System;
using UnityEngine.EventSystems;
using UnityEngine.UI;



public class btn_main01 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    // Start is called before the first frame update
    selectController selectController;
    bool oncheck = true;
    void Start()
    {
        selectController = FindObjectOfType<selectController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void btn_libray_Click()
    {
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string SavePath = Application.streamingAssetsPath;
        // string url = DataController.url;
        string url = SavePath + "\\webExecute.bat";
        Process.Start(url);
    }


    public void OnPointerEnter(PointerEventData eventData)
    {
        // if (oncheck == true)
        // {
        //     oncheck = false;
        //     Debug.Log("OnPointerEnter");
        //     Vector3 mousePos = Input.mousePosition;
        //     //마우스 좌표값을 월드 좌표로 변환
        //     Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);

        //     selectController.popupObj.SetActive(true);
        //     selectController.popupObj.GetComponent<RectTransform>().position = new Vector3(mousePos.x + 250, mousePos.y, 0);
        //     StartCoroutine("pauseBtnFadeIn");
        // };

        // if (oncheck == true)
        // {
        //     oncheck = false;
        //     Vector3 mousePos = Input.mousePosition;
        //     selectController.popupObj.GetComponent<RectTransform>().position = new Vector3(mousePos.x, mousePos.y, 0);
        // }
        // selectController.popupObj.SetActive(true);

    }

    public void OnPointerExit(PointerEventData eventData)
    {

        // selectController.popupObj.SetActive(false);
        // StartCoroutine(pauseBtnFadeIn());

    }

    IEnumerator pauseBtnFadeIn()
    {
        int i = 20;
        while (i > 0)
        {
            // Debug.Log("i : " + i);
            i -= 1;
            float f = i / 20.0f;

            //pauseBtn color 변경
            Color color = selectController.popupObj.GetComponent<Image>().color;
            color.a = f;
            selectController.popupObj.GetComponent<Image>().color = color;
            if (i < 1)
            {
                oncheck = true;
                selectController.popupObj.SetActive(false);
            }


            yield return new WaitForSeconds(0.1f);
        }

    }

}
