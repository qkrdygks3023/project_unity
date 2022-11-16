using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;



public class TabController : MonoBehaviour
{
    // public List<TabController> tabControllers = new List<TabController>[TabController];
    // string[] Avengers = new string[3];
    public Button[] TabControllers = new Button[4];
    public string title;

    dataController dataController;
    pageController pageController;
    GridController gridController;
    btnController btnController;
    selectController selectController;


    btn_main btn_main;

    public int pageSelect;


    public GameObject[] gridItem;

    public GameObject[] sub_btnList;
    public GameObject[] main_btnList;

    public GameObject[] sizeboxs;
    public GameObject[] impactPanel;

     

    void Start()
    {

        dataController = FindObjectOfType<dataController>();
        gridController = FindObjectOfType<GridController>();
        pageController = FindObjectOfType<pageController>();
        btnController = FindObjectOfType<btnController>();
        selectController = FindObjectOfType<selectController>();

        pageSelect = pageController.stageNum;


        title = TabControllers[pageSelect].GetComponent<GetName>().title;

        TabControllers[0].onClick.AddListener(delegate
        {
            title = TabControllers[0].GetComponent<GetName>().title;

            titleFunction(0);
        });

        TabControllers[1].onClick.AddListener(delegate
        {
            title = TabControllers[1].GetComponent<GetName>().title;
            call(title);
            titleFunction(1);
        });

        TabControllers[2].onClick.AddListener(delegate
        {
            title = TabControllers[2].GetComponent<GetName>().title;
            titleFunction(2);

        });

        TabControllers[3].onClick.AddListener(delegate
        {
            title = TabControllers[3].GetComponent<GetName>().title;
            titleFunction(3);

        });





    }

    // Update is called once per frame
    void Update()
    {

    }



    void call(string title)
    {

        Debug.Log(title);
    }

    public void titleFunction(int index) //0
    {
        //데이터 구조 
        pageController.stageNum = index;
        dataController.select_type = index;
        dataController.JsonLoad();
        griditemDestroy();
        if (index == 3)
        {
            dataController.selectData(dataController.select_type, 1, dataController.select_main);
        }
        else
        {
            dataController.selectData(dataController.select_type, 0, dataController.select_main);
        }
        gridController.sliverGrid();  //그리드 생성
        BtnDestroy();
        btnController.create_Btn(index); //부버튼 

        selectController.newBody.gameObject.SetActive(false);


        if (index == 0)
        {
            selectController.year_subtitleObj.GetComponentInChildren<TextMeshProUGUI>().text = dataController.select_main + "년";
        }
        else
        {
            selectController.year_subtitleObj.GetComponentInChildren<TextMeshProUGUI>().text = dataController.select_main + "년대";
        }

        if (index == 3)
        {
            selectController.year_subtitleObj.SetActive(false);

            //selectController.gridObj pos x - 100

            Vector2 gridpos = selectController.gridObj.GetComponent<RectTransform>().anchoredPosition;

            selectController.gridObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(gridpos.x, 520);
        }
        else
        {
            selectController.year_subtitleObj.SetActive(true);

            Vector2 gridpos = selectController.gridObj.GetComponent<RectTransform>().anchoredPosition;
            selectController.gridObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(gridpos.x, 400);
        }
    }

    void griditemDestroy()
    {
        gridItem = GameObject.FindGameObjectsWithTag("grid_item");

        foreach (var item in gridItem)
        {
            Destroy(item);
        }
    }

    void BtnDestroy()
    {
        sub_btnList = GameObject.FindGameObjectsWithTag("sub_btn");
        main_btnList = GameObject.FindGameObjectsWithTag("main_btn");
        sizeboxs = GameObject.FindGameObjectsWithTag("sizebox");
        impactPanel = GameObject.FindGameObjectsWithTag("impactPanel");




        foreach (var item in sizeboxs)
        {
            Destroy(item);
        }

        foreach (var item in sub_btnList)
        {
            Destroy(item);
        }

        foreach (var item in main_btnList)
        {
            Destroy(item);
        }

        foreach (var item in impactPanel)
        {
            Destroy(item);
        }


    }




}
