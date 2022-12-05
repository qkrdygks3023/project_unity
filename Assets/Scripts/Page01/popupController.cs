using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class popupController : MonoBehaviour
{
    public GameObject popBG;
    public GameObject popup;
    public GameObject titleObj;
    public GameObject PlaceObj;
    public GameObject yearObj;
    public GameObject keywordObj;
    public GameObject timeObj;
    public GameObject summaryObj;
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

    public void popclose()
    {
        popBG.SetActive(false);
    }

    public void popopen()
    {

        DataController = FindObjectOfType<dataController>();
        SelectController = FindObjectOfType<selectController>();

        titleObj.GetComponent<TextMeshProUGUI>().text = SelectController.titleObj.GetComponent<TextMeshProUGUI>().text;
        PlaceObj.GetComponent<TextMeshProUGUI>().text = SelectController.PlaceObj.GetComponent<TextMeshProUGUI>().text;
        yearObj.GetComponent<TextMeshProUGUI>().text = SelectController.yearObj.GetComponent<TextMeshProUGUI>().text;
        keywordObj.GetComponent<TextMeshProUGUI>().text = SelectController.keywordObj.GetComponent<TextMeshProUGUI>().text;
        timeObj.GetComponent<TextMeshProUGUI>().text = SelectController.timeObj.GetComponent<TextMeshProUGUI>().text;
        summaryObj.GetComponent<TextMeshProUGUI>().text = SelectController.summaryObj.GetComponent<TextMeshProUGUI>().text;
        popBG.SetActive(true);
    }


}
