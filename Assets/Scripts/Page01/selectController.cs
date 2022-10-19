using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class selectController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject SelectObj;
    public bool activity = false;
    public GameObject year_groupObj;
    public GameObject titleObj;
    public GameObject titleObj01;

    public GameObject PlaceObj;
    public GameObject yearObj;
    public GameObject keywordObj;
    public GameObject timeObj;
    public GameObject summaryObj;
    public GameObject urlObj;
    public GameObject thumbnailObj;
    dataController DataController;


    void Start()
    {
    
        DataController = FindObjectOfType<dataController>();           
        Debug.Log("activity");

      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void select(){
        
        SelectObj.gameObject.SetActive(true);
        
        year_groupObj.GetComponent<TextMeshProUGUI>().text =  DataController.selectGridData.group_year+"년대";
        titleObj.GetComponent<TextMeshProUGUI>().text =  DataController.selectGridData.title;
        titleObj01.GetComponent<TextMeshProUGUI>().text =  DataController.selectGridData.title;
        PlaceObj.GetComponent<TextMeshProUGUI>().text =  DataController.selectGridData.place;
        yearObj.GetComponent<TextMeshProUGUI>().text =  DataController.selectGridData.year;
        keywordObj.GetComponent<TextMeshProUGUI>().text =  keywordString(DataController.selectGridData.keyword);
        timeObj.GetComponent<TextMeshProUGUI>().text =  DataController.CountTimeLine(DataController.selectGridData.playtime).ToString();
        summaryObj.GetComponent<TextMeshProUGUI>().text =  DataController.selectGridData.summary;

        Debug.Log("select");
        
        // Debug.Log( DataController.selectGridData.title);
    }

     string  keywordString(List<string> keyword){
        string keywordstr = "";
        for (int i = 0; i < keyword.Count; i++)
        {
            keywordstr =  i < keyword.Count-1 ?  keywordstr + keyword[i] + "," : keywordstr + keyword[i];
        }

        return keywordstr;    
    }




}
