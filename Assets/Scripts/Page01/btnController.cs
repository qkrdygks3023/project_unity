using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Linq;
using TMPro;


public class btnController : MonoBehaviour
{
    // Start is called before the first frame update

    dataController DataController;
    pageController PageController;
    int stageNum;
    string main;
    string submain;

    List<contentData> contentData = new List<contentData>();

    public List<string> Main = new List<string>();
    public List<List<string>> subMainList = new List<List<string>>();
    public List<bool> openList = new List<bool>();

    public GameObject mainBtn_prefab;
    public GameObject subBtn_prefab;
    public List<string> mainbtnList = new List<string>();

    GameObject newMainBtn;
    GameObject newSubBtn;
    selectController selectController;

    void Start()
    {
        DataController = FindObjectOfType<dataController>();
        PageController = FindObjectOfType<pageController>();
        selectController = FindObjectOfType<selectController>();

        mainbtnList.Add("연도별");
        mainbtnList.Add("소장처별");


        stageNum = PageController.stageNum;
        main = DataController.select_main;
        submain = DataController.select_sub;

        Main = DataController.Main;
        subMainList = DataController.subMainList;
        openList = DataController.openList;



        for (int i = 0; i < mainbtnList.Count; i++)
        {
            openList.Add(true);
        }

        for (int i = 0; i < mainbtnList.Count; i++)
        {
            newMainBtn = (GameObject)Instantiate(mainBtn_prefab, transform);
            newMainBtn.GetComponentInChildren<TextMeshProUGUI>().text = mainbtnList[i];

            for (int k = 0; k < subMainList[i].Count; k++)
            {
                newSubBtn = (GameObject)Instantiate(subBtn_prefab, transform);
                if (mainbtnList[i] == "연도별")
                {
                    newSubBtn.GetComponentInChildren<TextMeshProUGUI>().text = subMainList[i][k] + " (" + DataController.dictYear[subMainList[i][k]] + ")";
                }
                else
                {
                    newSubBtn.GetComponentInChildren<TextMeshProUGUI>().text = subMainList[i][k];
                }

                newSubBtn.gameObject.GetComponent<btn_sub>().yeartitle = mainbtnList[i];
                newSubBtn.gameObject.GetComponent<btn_sub>().group_year = subMainList[i][k];

                Debug.Log("* btnContrler " + k + " - " + subMainList[i][k]);
            }
        }

        Debug.Log(" - btnContrler - ");
        Debug.Log(" - btnContrler - ");


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void select_mainBtn()
    {
        GameObject[] findSubBtn;
        GameObject[] findMainBtn;

        findSubBtn = GameObject.FindGameObjectsWithTag("sub_btn");
        findMainBtn = GameObject.FindGameObjectsWithTag("main_btn");
        selectController.newBody.gameObject.SetActive(false);


        for (int i = 0; i < findSubBtn.Length; i++)
        {
            Destroy(findSubBtn[i]);
        }
        for (int i = 0; i < findMainBtn.Length; i++)
        {
            Destroy(findMainBtn[i]);
        }


        for (int i = 0; i < mainbtnList.Count; i++)
        {
            newMainBtn = (GameObject)Instantiate(mainBtn_prefab, transform);
            newMainBtn.GetComponentInChildren<TextMeshProUGUI>().text = mainbtnList[i];
            if (openList[i])
            {
                for (int k = 0; k < subMainList[i].Count; k++)
                {

                    newSubBtn = (GameObject)Instantiate(subBtn_prefab, transform);
                    // newSubBtn.GetComponentInChildren<TextMeshProUGUI>().text = subMainList[i][k];
                    if (mainbtnList[i] == "연도별")
                    {
                        newSubBtn.GetComponentInChildren<TextMeshProUGUI>().text = subMainList[i][k] + " (" + DataController.dictYear[subMainList[i][k]] + ")";
                    }
                    else
                    {
                        newSubBtn.GetComponentInChildren<TextMeshProUGUI>().text = subMainList[i][k];
                    }



                    newSubBtn.gameObject.GetComponent<btn_sub>().yeartitle = mainbtnList[i];
                    newSubBtn.gameObject.GetComponent<btn_sub>().group_year = subMainList[i][k];


                    if (selectController.group_subbtn_title == subMainList[i][k])
                    {
                        newSubBtn.gameObject.GetComponentInChildren<TextMeshProUGUI>().color = Color.white;
                    }

                    Debug.Log("* btnContrler " + k + " - " + subMainList[i][k]);
                }
            }

        }
    }
}
