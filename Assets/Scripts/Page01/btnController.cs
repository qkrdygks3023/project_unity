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
    public GameObject mainBtn_prefab01;

    public GameObject subBtn_prefab;

    public GameObject subBtn_url_prefab;


    public GameObject subBtn_prefab01;

    public GameObject sizeBox_prefab;

    public List<string> mainbtnList = new List<string>();

    GameObject newMainBtn;
    GameObject newSubBtn;



    selectController selectController;
    public GameObject[] sub_btnList;
    int select_type;

    public bool unknown_year = false;

    void Start()
    {
        DataController = FindObjectOfType<dataController>();
        PageController = FindObjectOfType<pageController>();
        selectController = FindObjectOfType<selectController>();

        mainbtnList.Clear();
        subMainList.Clear();

        mainbtnList.Add("연도별");
        mainbtnList.Add("소장처별");


        stageNum = PageController.stageNum;
        main = DataController.select_main;
        submain = DataController.select_sub;

        Main = DataController.Main;
        subMainList = DataController.subMainList;
        openList = DataController.openList;
        select_type = DataController.select_type;

        create_Btn(stageNum);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void create_Btn(int index)
    {
        Debug.Log(" create_Btn() ");

        Debug.Log(subMainList.Count);
        Debug.Log(subMainList[0].Count);
        Debug.Log(subMainList[1].Count);

        unknown_year = false;

        stageNum = PageController.stageNum;

        for (int i = 0; i < mainbtnList.Count; i++)
        {
            for (int k = 0; k < subMainList[i].Count; k++)
            {
                if (subMainList[i][k].ToString() == "0")
                {
                    unknown_year = true;
                }
            }
        }


        openList.Clear();

        for (int i = 0; i < mainbtnList.Count; i++)
        {
            openList.Add(true);
        }

        for (int i = 0; i < mainbtnList.Count; i++)
        {
            if (index != 3)
            {
                //연도별,소장처별 버튼 생성
                if (i == 0) //연도별
                {
                    newMainBtn = (GameObject)Instantiate(mainBtn_prefab, transform);
                    if (stageNum == 0)
                    {
                        newMainBtn.GetComponentInChildren<TextMeshProUGUI>().text = "연도별";
                        mainbtnList[0] = "연도별";
                    }
                    else
                    {
                        newMainBtn.GetComponentInChildren<TextMeshProUGUI>().text = "연대별";
                        mainbtnList[0] = "연대별";

                    }

                }
                else
                { //소장처별, 지역 미디어 라이브러리 


                    if (index == 1)
                    {
                        newMainBtn = (GameObject)Instantiate(mainBtn_prefab01, transform);
                        // newMainBtn.GetComponentInChildren<TextMeshProUGUI>().text = "지역 미디어 라이브러리";
                        // newMainBtn.GetComponentInChildren<TextMeshProUGUI>().text = "한국영상자료원";

                    }
                    else
                    { //소장처별
                        newMainBtn = (GameObject)Instantiate(mainBtn_prefab, transform);
                        newMainBtn.GetComponentInChildren<TextMeshProUGUI>().text = mainbtnList[i];

                    }
                }
            }
            else
            {
                //구술영상은 연도별, 소장처별 없음
            }

            //기록영상
            if (index == 0)
            {   //미상년도 체크
                if (unknown_year)
                {
                    //연도아래 버튼, 소장처별 아래 버튼 생성
                    for (int k = 0; k < subMainList[i].Count; k++)
                    {
                        newSubBtn = (GameObject)Instantiate(subBtn_prefab, transform);
                        //연도 아래 
                        if (mainbtnList[i] == "연도별")
                        {
                            Debug.Log(subMainList[i][k].ToString() == "0");
                            Debug.Log("subMainList -- " + subMainList[i][k].ToString());


                            if (subMainList[i][k].ToString() == "0")
                            {

                                newSubBtn.GetComponentInChildren<TextMeshProUGUI>().text = "연도미상" + " (" + DataController.dictYear[subMainList[i][k]] + ")";
                                newSubBtn.GetComponentInChildren<TextMeshProUGUI>().color = Color.white;


                            }
                            else if (k == 1)
                            {

                                newSubBtn.GetComponentInChildren<TextMeshProUGUI>().text = "~" + subMainList[i][k] + "년" + " (" + DataController.dictYear[subMainList[i][k]] + ")";

                            }
                            else if (k == subMainList[i].Count - 1)
                            {
                                newSubBtn.GetComponentInChildren<TextMeshProUGUI>().text = subMainList[i][k] + "년 ~" + " (" + DataController.dictYear[subMainList[i][k]] + ")";

                            }
                            else
                            {
                                newSubBtn.GetComponentInChildren<TextMeshProUGUI>().text = subMainList[i][k] + "년" + " (" + DataController.dictYear[subMainList[i][k]] + ")";
                            }
                        }
                        //소장처 아래 
                        else
                        {
                            newSubBtn.GetComponentInChildren<TextMeshProUGUI>().text = subMainList[i][k];
                        }

                        newSubBtn.gameObject.GetComponent<btn_sub>().yeartitle = mainbtnList[i];
                        newSubBtn.gameObject.GetComponent<btn_sub>().group_year = subMainList[i][k];

                        Debug.Log("* btnContrler " + k + " - " + subMainList[i][k]);
                    }
                    Instantiate(sizeBox_prefab, transform);
                }
                else
                {
                    //연도아래 버튼, 소장처별 아래 버튼 생성
                    for (int k = 0; k < subMainList[i].Count; k++)
                    {
                        newSubBtn = (GameObject)Instantiate(subBtn_prefab, transform);
                        //연도 아래 
                        if (mainbtnList[i] == "연도별")
                        {

                            if (k == 0)
                            {
                                newSubBtn.GetComponentInChildren<TextMeshProUGUI>().text = "~" + subMainList[i][k] + "년" + " (" + DataController.dictYear[subMainList[i][k]] + ")";
                                newSubBtn.GetComponentInChildren<TextMeshProUGUI>().color = Color.white;

                            }
                            else if (k == subMainList[i].Count - 1)
                            {
                                newSubBtn.GetComponentInChildren<TextMeshProUGUI>().text = subMainList[i][k] + "년 ~" + " (" + DataController.dictYear[subMainList[i][k]] + ")";

                            }
                            else
                            {
                                newSubBtn.GetComponentInChildren<TextMeshProUGUI>().text = subMainList[i][k] + "년" + " (" + DataController.dictYear[subMainList[i][k]] + ")";
                            }
                        }
                        //소장처 아래 
                        else
                        {
                            newSubBtn.GetComponentInChildren<TextMeshProUGUI>().text = subMainList[i][k];
                        }

                        newSubBtn.gameObject.GetComponent<btn_sub>().yeartitle = mainbtnList[i];
                        newSubBtn.gameObject.GetComponent<btn_sub>().group_year = subMainList[i][k];

                        Debug.Log("* btnContrler " + k + " - " + subMainList[i][k]);
                    }
                    Instantiate(sizeBox_prefab, transform);
                }
            }
            //전쟁영화,
            else if (index == 1)
            {
                if (unknown_year)
                {
                    for (int k = 0; k < subMainList[i].Count; k++)
                    {

                        //연도아래 
                        if (mainbtnList[i] == "연대별")
                        {
                            newSubBtn = (GameObject)Instantiate(subBtn_prefab, transform);

                            if (subMainList[i][k].ToString() == "0")
                            {

                                newSubBtn.GetComponentInChildren<TextMeshProUGUI>().text = "년대미상" + " (" + DataController.dictYear[subMainList[i][k]] + ")";
                                newSubBtn.GetComponentInChildren<TextMeshProUGUI>().color = Color.white;


                            }
                            else if (k == 1)
                            {
                                newSubBtn.GetComponentInChildren<TextMeshProUGUI>().text = subMainList[i][k] + "년대" + " (" + DataController.dictYear[subMainList[i][k]] + ")";

                            }
                            else
                            {
                                newSubBtn.GetComponentInChildren<TextMeshProUGUI>().text = subMainList[i][k] + "년대" + " (" + DataController.dictYear[subMainList[i][k]] + ")";
                            }
                        }
                        //지역 미디어 라이브러리
                        else
                        {
                            newSubBtn = (GameObject)Instantiate(subBtn_url_prefab, transform);
                            newSubBtn.GetComponentInChildren<TextMeshProUGUI>().text = subMainList[i][k];
                        }

                        newSubBtn.gameObject.GetComponent<btn_sub>().yeartitle = mainbtnList[i];
                        newSubBtn.gameObject.GetComponent<btn_sub>().group_year = subMainList[i][k];

                        Debug.Log("* btnContrler " + k + " - " + subMainList[i][k]);
                    }
                    Instantiate(sizeBox_prefab, transform);
                }
                else
                {
                    for (int k = 0; k < subMainList[i].Count; k++)
                    {

                        //연도아래 
                        if (mainbtnList[i] == "연대별")
                        {
                            newSubBtn = (GameObject)Instantiate(subBtn_prefab, transform);

                            if (k == 0)
                            {
                                newSubBtn.GetComponentInChildren<TextMeshProUGUI>().text = subMainList[i][k] + "년대" + " (" + DataController.dictYear[subMainList[i][k]] + ")";
                                newSubBtn.GetComponentInChildren<TextMeshProUGUI>().color = Color.white;

                            }

                            else
                            {
                                newSubBtn.GetComponentInChildren<TextMeshProUGUI>().text = subMainList[i][k] + "년대" + " (" + DataController.dictYear[subMainList[i][k]] + ")";
                            }
                        }
                        //지역 미디어 라이브러리
                        else
                        {
                            newSubBtn = (GameObject)Instantiate(subBtn_url_prefab, transform);
                            newSubBtn.GetComponentInChildren<TextMeshProUGUI>().text = subMainList[i][k];
                        }

                        newSubBtn.gameObject.GetComponent<btn_sub>().yeartitle = mainbtnList[i];
                        newSubBtn.gameObject.GetComponent<btn_sub>().group_year = subMainList[i][k];

                        Debug.Log("* btnContrler " + k + " - " + subMainList[i][k]);
                    }
                    Instantiate(sizeBox_prefab, transform);
                }


            }
            // 다큐멘터리
            else if (index != 3)
            {
                if (unknown_year)
                {
                    for (int k = 0; k < subMainList[i].Count; k++)
                    {
                        newSubBtn = (GameObject)Instantiate(subBtn_prefab, transform);
                        //연도아래 
                        if (mainbtnList[i] == "연대별")
                        {

                            if (subMainList[i][k].ToString() == "0")
                            {

                                newSubBtn.GetComponentInChildren<TextMeshProUGUI>().text = "년대미상" + " (" + DataController.dictYear[subMainList[i][k]] + ")";
                                newSubBtn.GetComponentInChildren<TextMeshProUGUI>().color = Color.white;


                            }
                            else if (k == 1)
                            {
                                newSubBtn.GetComponentInChildren<TextMeshProUGUI>().text = subMainList[i][k] + "년대" + " (" + DataController.dictYear[subMainList[i][k]] + ")";

                            }

                            else
                            {
                                newSubBtn.GetComponentInChildren<TextMeshProUGUI>().text = subMainList[i][k] + "년대" + " (" + DataController.dictYear[subMainList[i][k]] + ")";
                            }
                        }
                        //소장처 아래
                        else
                        {
                            newSubBtn.GetComponentInChildren<TextMeshProUGUI>().text = subMainList[i][k];
                        }

                        newSubBtn.gameObject.GetComponent<btn_sub>().yeartitle = mainbtnList[i];
                        newSubBtn.gameObject.GetComponent<btn_sub>().group_year = subMainList[i][k];

                        Debug.Log("* btnContrler " + k + " - " + subMainList[i][k]);
                    }
                    Instantiate(sizeBox_prefab, transform);
                }
                else
                {
                    for (int k = 0; k < subMainList[i].Count; k++)
                    {
                        newSubBtn = (GameObject)Instantiate(subBtn_prefab, transform);
                        //연도아래 
                        if (mainbtnList[i] == "연대별")
                        {

                            if (k == 0)
                            {
                                newSubBtn.GetComponentInChildren<TextMeshProUGUI>().text = subMainList[i][k] + "년대" + " (" + DataController.dictYear[subMainList[i][k]] + ")";
                                newSubBtn.GetComponentInChildren<TextMeshProUGUI>().color = Color.white;

                            }

                            else
                            {
                                newSubBtn.GetComponentInChildren<TextMeshProUGUI>().text = subMainList[i][k] + "년대" + " (" + DataController.dictYear[subMainList[i][k]] + ")";
                            }
                        }
                        //소장처 아래
                        else
                        {
                            newSubBtn.GetComponentInChildren<TextMeshProUGUI>().text = subMainList[i][k];
                        }

                        newSubBtn.gameObject.GetComponent<btn_sub>().yeartitle = mainbtnList[i];
                        newSubBtn.gameObject.GetComponent<btn_sub>().group_year = subMainList[i][k];

                        Debug.Log("* btnContrler " + k + " - " + subMainList[i][k]);
                    }
                    Instantiate(sizeBox_prefab, transform);
                }


            }
            //구술영상
            else
            { //구술영상 소장처만 소환
                for (int k = 0; k < subMainList[1].Count; k++)
                {
                    if (mainbtnList[i] == "연도별")
                    {
                    }
                    else if (mainbtnList[i] == "연대별")
                    {

                    }
                    else
                    {
                        newSubBtn = (GameObject)Instantiate(subBtn_prefab01, transform);

                        if (k == 0)
                        {
                            newSubBtn.GetComponentInChildren<TextMeshProUGUI>().text = subMainList[1][k];
                            newSubBtn.GetComponentInChildren<TextMeshProUGUI>().color = Color.white;
                        }
                        else
                        {
                            newSubBtn.GetComponentInChildren<TextMeshProUGUI>().text = subMainList[1][k];
                        }


                        newSubBtn.gameObject.GetComponent<btn_sub>().yeartitle = subMainList[1][k];
                        newSubBtn.gameObject.GetComponent<btn_sub>().group_year = subMainList[1][k];

                        // Debug.Log("* btnContrler " + k + " - " + subMainList[i][k]);


                        Debug.Log("* btnContrler " + k + " - " + mainbtnList[1] + "++++" + subMainList[1].Count);

                        Instantiate(sizeBox_prefab, transform);
                    }


                    // newSubBtn.gameObject.GetComponent<btn_sub>().group_year = subMainList[i][k];


                }

            }


        }



        Debug.Log(" - btnContrler - ");
        Debug.Log(" - btnContrler - ");
    }

    public void select_mainBtn()
    {
        GameObject[] findSubBtn;
        GameObject[] findMainBtn;
        GameObject[] sizeBoxs;


        findSubBtn = GameObject.FindGameObjectsWithTag("sub_btn");
        findMainBtn = GameObject.FindGameObjectsWithTag("main_btn");
        sizeBoxs = GameObject.FindGameObjectsWithTag("sizebox");

        selectController.newBody.gameObject.SetActive(false);

        select_type = DataController.select_type;


        for (int i = 0; i < findSubBtn.Length; i++)
        {
            Destroy(findSubBtn[i]);
        }
        for (int i = 0; i < findMainBtn.Length; i++)
        {
            Destroy(findMainBtn[i]);
        }
        for (int i = 0; i < sizeBoxs.Length; i++)
        {
            Destroy(sizeBoxs[i]);
        }

        unknown_year = false;
        for (int i = 0; i < mainbtnList.Count; i++)
        {
            for (int k = 0; k < subMainList[i].Count; k++)
            {
                if (subMainList[i][k].ToString() == "0")
                {
                    unknown_year = true;
                }
            }
        }




        for (int i = 0; i < mainbtnList.Count; i++)
        {
            if (select_type == 1)
            {
                if (i == 0)
                {
                    newMainBtn = (GameObject)Instantiate(mainBtn_prefab, transform);

                    newMainBtn.GetComponentInChildren<TextMeshProUGUI>().text = mainbtnList[i];

                }
                else
                {
                    newMainBtn = (GameObject)Instantiate(mainBtn_prefab01, transform);
                }

            }
            else
            {
                newMainBtn = (GameObject)Instantiate(mainBtn_prefab, transform);
                newMainBtn.GetComponentInChildren<TextMeshProUGUI>().text = mainbtnList[i];

            }



            if (openList[i])
            {
                for (int k = 0; k < subMainList[i].Count; k++)
                {

                    newSubBtn = (GameObject)Instantiate(subBtn_prefab, transform);
                    // newSubBtn.GetComponentInChildren<TextMeshProUGUI>().text = subMainList[i][k];

                    if (mainbtnList[i] == "연도별")
                    {


                        if (select_type == 0)
                        {
                            if (unknown_year)
                            {
                                if (subMainList[i][k].ToString() == "0")
                                {
                                    newSubBtn.GetComponentInChildren<TextMeshProUGUI>().text = "연도미상" + " (" + DataController.dictYear[subMainList[i][k]] + ")";
                                }
                                else if (k == 1)
                                {

                                    newSubBtn.GetComponentInChildren<TextMeshProUGUI>().text = "~" + subMainList[i][k] + "년" + " (" + DataController.dictYear[subMainList[i][k]] + ")";

                                }
                                else if (k == subMainList[i].Count - 1)
                                {
                                    newSubBtn.GetComponentInChildren<TextMeshProUGUI>().text = subMainList[i][k] + "년 ~" + " (" + DataController.dictYear[subMainList[i][k]] + ")";

                                }
                                else
                                {
                                    newSubBtn.GetComponentInChildren<TextMeshProUGUI>().text = subMainList[i][k] + "년" + " (" + DataController.dictYear[subMainList[i][k]] + ")";
                                }
                            }
                            else
                            {
                                if (k == 0)
                                {
                                    newSubBtn.GetComponentInChildren<TextMeshProUGUI>().text = "~" + subMainList[i][k] + "년" + " (" + DataController.dictYear[subMainList[i][k]] + ")";

                                }
                                else if (k == subMainList[i].Count - 1)
                                {
                                    newSubBtn.GetComponentInChildren<TextMeshProUGUI>().text = subMainList[i][k] + "년 ~" + " (" + DataController.dictYear[subMainList[i][k]] + ")";

                                }
                                else
                                {
                                    newSubBtn.GetComponentInChildren<TextMeshProUGUI>().text = subMainList[i][k] + "년" + " (" + DataController.dictYear[subMainList[i][k]] + ")";

                                }
                            }




                            // if (k == 0)
                            // {
                            //     newSubBtn.GetComponentInChildren<TextMeshProUGUI>().text = "~" + subMainList[i][k] + "년" + " (" + DataController.dictYear[subMainList[i][k]] + ")";

                            // }
                            // else if (k == subMainList[i].Count - 1)
                            // {
                            //     newSubBtn.GetComponentInChildren<TextMeshProUGUI>().text = subMainList[i][k] + "년 ~" + " (" + DataController.dictYear[subMainList[i][k]] + ")";

                            // }
                            // else
                            // {
                            //     newSubBtn.GetComponentInChildren<TextMeshProUGUI>().text = subMainList[i][k] + "년" + " (" + DataController.dictYear[subMainList[i][k]] + ")";

                            // }


                        }
                        else if (select_type == 1 || select_type == 2)
                        {
                            newSubBtn.GetComponentInChildren<TextMeshProUGUI>().text = subMainList[i][k] + "년대" + " (" + DataController.dictYear[subMainList[i][k]] + ")";

                        }
                        else
                        {
                            newSubBtn.GetComponentInChildren<TextMeshProUGUI>().text = subMainList[i][k] + "년대" + " (" + DataController.dictYear[subMainList[i][k]] + ")";

                        }
                    }
                    else if (mainbtnList[i] == "연대별")
                    {
                        if (select_type == 1 || select_type == 2)
                        {
                            if (subMainList[i][k] == "0")
                            {
                                newSubBtn.GetComponentInChildren<TextMeshProUGUI>().text = "년대미상" + " (" + DataController.dictYear[subMainList[i][k]] + ")";
                            }
                            else
                            {
                                newSubBtn.GetComponentInChildren<TextMeshProUGUI>().text = subMainList[i][k] + "년대" + " (" + DataController.dictYear[subMainList[i][k]] + ")";

                            }
                            Debug.Log("====== btnContrler " + k + " - " + subMainList[i][k] + (subMainList[i][k] == "0").ToString());
                        }
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
            Instantiate(sizeBox_prefab, transform);
        }
    }


}
