using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class btn_sub : MonoBehaviour
{
    // Start is called before the first frame update
    public string yeartitle;
    public string group_year;

    public string str_group_year;

    selectController selectController;
    dataController dataController;
    pageController pageController;
    GridController gridController;


    public int pageSelect;

    void Start()
    {
        selectController = FindObjectOfType<selectController>();
        dataController = FindObjectOfType<dataController>();
        pageController = FindObjectOfType<pageController>();
        gridController = FindObjectOfType<GridController>();

        pageSelect = pageController.stageNum;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public GameObject respawnPrefab;
    public GameObject[] sub_btnList;
    public GameObject[] gridItem;
    public GameObject[] impactPanel;


    public bool isLoad = false;

    public void onClick()
    {
        Debug.Log(group_year); //1950년대
        Debug.Log(yeartitle); //연도별
        Debug.Log(pageSelect); //0 1 2 3 4

        int grouptype;
        if (yeartitle == "연도별")
        {
            grouptype = 0;
        }
        else
        {
            grouptype = 1;
        }
        dataController.selectData(pageSelect, grouptype, group_year);
        selectController.newBody.gameObject.SetActive(false);
        selectController.group_subbtn_title = group_year;

        // selectController.year_subtitleObj.gameObject.GetComponent<TextMeshProUGUI>().text = group_year;

        //selectController 오브젝트 
        //연대별 소장쳐벌
        selectController.yeartitleObj.gameObject.GetComponent<TextMeshProUGUI>().text = yeartitle;
        // 1950년 1950년대
        if (pageSelect == 0)
        {
            if (grouptype == 0)
            {
                selectController.year_subtitleObj.gameObject.GetComponent<TextMeshProUGUI>().text = group_year + "년";

            }
            else
            {
                selectController.year_subtitleObj.gameObject.GetComponent<TextMeshProUGUI>().text = group_year;
            }

        }
        else
        {
            if (grouptype == 0)
            {
                selectController.year_subtitleObj.gameObject.GetComponent<TextMeshProUGUI>().text = group_year + "년대";

            }
            else
            {
                selectController.year_subtitleObj.gameObject.GetComponent<TextMeshProUGUI>().text = group_year;
            }
        }






        if (selectController.select_year_subtitleObj != null)
        {
            selectController.select_year_subtitleObj.GetComponentInChildren<TextMeshProUGUI>().color = new Color(130 / 255f, 130 / 255f, 130 / 255f);

        }
        else
        {
            selectController.select_year_subtitleObj = this.gameObject;

            sub_btnList = GameObject.FindGameObjectsWithTag("sub_btn");
            foreach (GameObject sub_btnObject in sub_btnList)
            {
                sub_btnObject.GetComponentInChildren<TextMeshProUGUI>().color = new Color(130 / 255f, 130 / 255f, 130 / 255f);
            }
        }

        selectController.select_year_subtitleObj = this.gameObject;
        selectController.select_year_subtitleObj.GetComponentInChildren<TextMeshProUGUI>().color = Color.white;


        selectController.select_year = yeartitle;



        //grid 생성
        gridItem = GameObject.FindGameObjectsWithTag("grid_item");
        impactPanel = GameObject.FindGameObjectsWithTag("impactPanel");


        foreach (var item in gridItem)
        {

            item.gameObject.SetActive(false);

            Destroy(item);
        }

        foreach (var item in impactPanel)
        {
            Destroy(item);
        }


        gridController.sliverGrid();


    }



}
