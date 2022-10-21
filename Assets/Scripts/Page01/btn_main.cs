using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
public class btn_main : MonoBehaviour
{
    dataController DataController;
    pageController PageController;
    btnController BtnController;


    public List<string> mainbtnList = new List<string>();
    public List<List<string>> subMainList = new List<List<string>>();
    public List<bool> openList = new List<bool>();

    public int select_index;

    public string title;
    public GameObject subBtn_prefab;

    void Start()
    {
        DataController = FindObjectOfType<dataController>();
        PageController = FindObjectOfType<pageController>();
        BtnController = FindObjectOfType<btnController>();

        openList = DataController.openList;
        //  GetComponentInChildren<TextMeshProUGUI>().text = "a";   

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void btn_main_Click()
    {
        Debug.Log("btn Main");
        Debug.Log(GetComponentInChildren<TextMeshProUGUI>().text);

        title = GetComponentInChildren<TextMeshProUGUI>().text;

        mainbtnList = BtnController.mainbtnList;
        int idx = mainbtnList.FindIndex(a => a.Contains(title));
        Debug.Log(idx);

        for (int i = 0; i < openList.Count; i++)
        {
            Debug.Log(idx);

        }
        openList[idx] = !openList[idx];
    }

    public void btn_subBtn_Create()
    {
        title = GetComponentInChildren<TextMeshProUGUI>().text;
        mainbtnList = BtnController.mainbtnList;
        int idx = mainbtnList.FindIndex(a => a.Contains(title));
        if (openList[idx])
        {
            //생성
            Debug.Log("생성");
            BtnController.select_mainBtn();

        }
        else
        {
            //파괴
            Debug.Log("파괴");
            BtnController.select_mainBtn();
        }


    }
}
