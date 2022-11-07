using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;


public class MainMouseBtn : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject btn;
    public GameObject image;
    public int move;

    Vector2 pos;
    void Start()
    {
        pos = image.GetComponent<RectTransform>().anchoredPosition;




    }

    // Update is called once per frame
    void Update()
    {
    }


    public void OnPointerEnter(PointerEventData eventData)
    {
        //image 위치 정보

        //image left move
        image.GetComponent<RectTransform>().anchoredPosition = new Vector2(pos.x - move, pos.y);
    }

    public void OnPointerExit(PointerEventData eventData)
    {

        image.GetComponent<RectTransform>().anchoredPosition = new Vector2(pos.x, pos.y);



    }

}
