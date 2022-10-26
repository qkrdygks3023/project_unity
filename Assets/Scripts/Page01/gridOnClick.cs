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
        GameObject prefab = Instantiate(impactPanel, transform.position, Quaternion.identity);
 
        for (int i = 0; i < 10; i++)
        {
            prefab.transform.localScale = new Vector3(1.0f + i * 0.1f, 1.0f + i * 0.1f, 1.0f + i * 0.1f);
            yield return new WaitForSeconds(0.1f);
        }
        Destroy(prefab);
         SelectController.select();
        
    }





}
