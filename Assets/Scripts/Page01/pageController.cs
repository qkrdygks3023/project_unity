using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class pageController : MonoBehaviour
{
    public int stageNum;
    public Button[] TabControllers = new Button[4];
    public int index;
    TabController tabController;
    dataController dataController;
    selectController selectController;



    void Awake()
    {
        stageNum = 0;
        var obj = FindObjectsOfType<MainController>();
        tabController = FindObjectOfType<TabController>();
        dataController = FindObjectOfType<dataController>();
        selectController = FindObjectOfType<selectController>();



        if (obj.Length == 1)
        {
            stageNum = GameObject.Find("MainController").GetComponent<MainController>().stageNum;
        }
        // else
        // {
        //     Debug.Log("Destroy");
        //     Destroy(gameObject);
        // }
        btnContoller();

        Debug.Log("page - " + stageNum);
        dataController.select_type = stageNum;



        if (stageNum == 3)
        {
            selectController.year_subtitleObj.SetActive(false);
            Vector2 gridpos = selectController.gridObj.GetComponent<RectTransform>().anchoredPosition;
            selectController.gridObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(gridpos.x, 520);
        }
        else
        {
            selectController.year_subtitleObj.SetActive(true);
            Vector2 gridpos = selectController.gridObj.GetComponent<RectTransform>().anchoredPosition;
            selectController.gridObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(gridpos.x, 400);
        }
        // tabController.titleFunction(stageNum);

    }
    void Start()
    {

        Debug.Log("page - " + stageNum);
    }

    // Update is called once per frame
    void Update()
    {

    }


    //title 변경
    void titleName(int stageNum)
    {
        GameObject.Find("subtitle").GetComponent<TitleName>().stageController(stageNum);
        Debug.Log("page stageNum - " + stageNum);
    }

    void btnContoller()
    {

        TabControllers[0].onClick.AddListener(delegate
        {
            index = TabControllers[0].GetComponent<GetName>().stageNum;
            Debug.Log("page stageNum - " + index);
            titleName(index);
        });

        TabControllers[1].onClick.AddListener(delegate
        {
            index = TabControllers[1].GetComponent<GetName>().stageNum;
            Debug.Log("page stageNum - " + index);
            titleName(index);
        });

        TabControllers[2].onClick.AddListener(delegate
        {
            index = TabControllers[2].GetComponent<GetName>().stageNum;
            Debug.Log("page stageNum - " + index);
            titleName(index);
        });

        TabControllers[3].onClick.AddListener(delegate
        {
            index = TabControllers[3].GetComponent<GetName>().stageNum;
            Debug.Log("page stageNum - " + index);
            titleName(index);
        });

    }



}
