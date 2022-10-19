using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;


public class gridOnClick : MonoBehaviour , IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler
{
    // Start is called before the first frame update
  RectTransform width ;
   RectTransform height;



    public int  ishover = 0;

    Vector3  originScale;
    public int select_index;

    dataController DataController;
    selectController SelectController;
    void Start()
    {    
     DataController = FindObjectOfType<dataController>();
     SelectController = FindObjectOfType<selectController>();
    }

    // Update is called once per frame
    void Update()
    {
     
       
    }
    public void OnPointerDown (PointerEventData eventData)
    {
        Debug.Log("down");
        DataController.selectGrid(select_index);
        SelectController.select();

        Debug.Log( SelectController.activity);
       
       
    //    selectTitle =  this.transform.Find("gridtitle").gameObject.GetComponent<TextMeshProUGUI>().text;
    }

    public void OnPointerUp (PointerEventData eventData)
    {
        //   Debug.Log("up");
    }

    public  void OnPointerEnter (PointerEventData eventData)
    {
 
        
     transform.localScale = new Vector3(1.1f, 1.1f, 1.1f); 
        

        //  float width = gameObject.GetComponentInChildren<Image>().GetComponent<RectTransform>().rect.width;   
        //  width.sizeDelta = new Vector2(width.rect.width + 100 , height.rect.height);
        //  height.sizeDelta = new Vector2(width.rect.width , height.rect.height + 100);

        
 
    }

     public void OnPointerExit(PointerEventData eventData){
          ishover = 2; 
     transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        //  width.sizeDelta = new Vector2(width.rect.width - 100 , height.rect.height);
        //  height.sizeDelta = new Vector2(width.rect.width , height.rect.height - 100);

    }
    


  

    
}
