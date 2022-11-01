using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;


public class gridOnClick : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler
{
    // Start is called before the first frame update
    RectTransform width;
    RectTransform height;



    public int ishover = 0;

    Vector3 originScale;
    public int select_index;

    public GameObject impactPanel;

    dataController DataController;
    selectController SelectController;
    rowItemContorller rowItemContorller;

    void Start()
    {
        DataController = FindObjectOfType<dataController>();
        rowItemContorller = FindObjectOfType<rowItemContorller>();
        SelectController = FindObjectOfType<selectController>();

    }

    // Update is called once per frame
    void Update()
    {


    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("down");

        DataController.selectGrid(select_index);   
        StartCoroutine(sizedUp());

        Debug.Log(SelectController.activity);
        //    selectTitle =  this.transform.Find("gridtitle").gameObject.GetComponent<TextMeshProUGUI>().text;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {


        transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);


        //  float width = gameObject.GetComponentInChildren<Image>().GetComponent<RectTransform>().rect.width;   
        //  width.sizeDelta = new Vector2(width.rect.width + 100 , height.rect.height);
        //  height.sizeDelta = new Vector2(width.rect.width , height.rect.height + 100);



    }

    public void OnPointerExit(PointerEventData eventData)
    {
        ishover = 2;
        transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        //  width.sizeDelta = new Vector2(width.rect.width - 100 , height.rect.height);
        //  height.sizeDelta = new Vector2(width.rect.width , height.rect.height - 100);

    }


    //서서히 확대
    IEnumerator sizedUp()
    {
        //canvas안에 prefab 생성    
        GameObject newObj = (GameObject)Instantiate(impactPanel, transform);
        newObj.transform.SetParent(GameObject.Find("Canvas").transform, false);
        Debug.Log("sizeup");
        width = newObj.GetComponent<RectTransform>();
        height = newObj.GetComponent<RectTransform>();

        //서서히 커짐        
        for (int i = 0; i < 50; i++)
        { 
            //newObj width 2890 까지 증가
            if (width.rect.width <= 2890)
            {
                width.sizeDelta = new Vector2(width.rect.width + 100, height.rect.height);
                height.sizeDelta = new Vector2(width.rect.width, height.rect.height + 100);
            }
            yield return new WaitForSeconds(0.01f);
        }

          SelectController.select();

        for (int i = 0; i < 10; i++)
        {
             newObj.GetComponent<Image>().color = new Color(1, 1, 1, newObj.GetComponent<Image>().color.a - 0.1f);
            yield return new WaitForSeconds(0.01f);           
        }

      
        Destroy(newObj);


 

    }





}
