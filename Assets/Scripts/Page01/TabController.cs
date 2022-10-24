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
            call(title);
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

    public void titleFunction(int index)
    {
        pageController.stageNum = index;
        dataController.select_type = index;
        dataController.JsonLoad();
        griditemDestroy();
        dataController.selectData(dataController.select_type, 0, dataController.select_main);
        gridController.sliverGrid();
        BtnDestroy();
        btnController.create_Btn();

        selectController.newBody.gameObject.SetActive(false);
        selectController.year_subtitleObj.GetComponentInChildren<TextMeshProUGUI>().text = "연도별";
        selectController.year_subtitleObj.GetComponentInChildren<TextMeshProUGUI>().text = dataController.select_main;
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


    }




}
