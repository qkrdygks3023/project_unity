using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class selectController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject newBody;
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
    public GameObject yeartitleObj;
    public GameObject year_subtitleObj;
    public GameObject select_year_subtitleObj;
    public GameObject Row_Items;

    public GameObject video_Obj;

    public GameObject gridObj;

    public GameObject loadingObj;
    public GameObject image_dvdObj;
    public GameObject image_videoObj;
    public GameObject videoScreenObj;
    public GameObject erorrObj;
    public GameObject popupObj;








    public string group_subbtn_title;

    public int subtbtn_white_i;
    public int subtbtn_white_k;

    public string select_year;

    rowItemContorller rowItemContorller;

    public bool isLoad;
    private bool isClicked = false;

    private float year_groupObj_y;
    private float titleObj_y;
    private float titleObj01_y;
    private float PlaceObj_y;
    private float yearObj_y;
    private float keywordObj_y;
    private float timeObj_y;
    private float summaryObj_y;


    void Start()
    {
        year_groupObj_y = year_groupObj.GetComponent<RectTransform>().anchoredPosition.y;
        titleObj_y = titleObj.GetComponent<RectTransform>().anchoredPosition.y;
        titleObj01_y = titleObj01.GetComponent<RectTransform>().anchoredPosition.y;
        PlaceObj_y = PlaceObj.GetComponent<RectTransform>().anchoredPosition.y;
        yearObj_y = yearObj.GetComponent<RectTransform>().anchoredPosition.y;
        keywordObj_y = keywordObj.GetComponent<RectTransform>().anchoredPosition.y;
        timeObj_y = timeObj.GetComponent<RectTransform>().anchoredPosition.y;
        summaryObj_y = summaryObj.GetComponent<RectTransform>().anchoredPosition.y;


        DataController = FindObjectOfType<dataController>();
        rowItemContorller = FindObjectOfType<rowItemContorller>();



        Debug.Log("activity");


    }

    // Update is called once per frame
    void Update()
    {

    }

    //grid select
    public void select(bool isfirst)
    {
        erorrObj.SetActive(false);
        DataController = FindObjectOfType<dataController>();
        newBody.gameObject.SetActive(true);
        if (DataController.select_type == 0)
        {

            if (DataController.selectGridData.group_year == 0)
            {
                year_groupObj.GetComponent<TextMeshProUGUI>().text = "연도미상";

            }
            else
            {
                year_groupObj.GetComponent<TextMeshProUGUI>().text = DataController.selectGridData.group_year + "년";
            }
        }
        else
        {

            if (DataController.selectGridData.group_year == 0)
            {
                year_groupObj.GetComponent<TextMeshProUGUI>().text = "년대미상";

            }
            else
            {
                year_groupObj.GetComponent<TextMeshProUGUI>().text = DataController.selectGridData.group_year.ToString() + "년대";

            }
        }

        titleObj.GetComponent<TextMeshProUGUI>().text = DataController.selectGridData.title;
        titleObj01.GetComponent<TextMeshProUGUI>().text = DataController.selectGridData.title;

        if (DataController.select_type == 3)
        {
            string[] placeList = DataController.selectGridData.place.Split('.');
            PlaceObj.GetComponent<TextMeshProUGUI>().text = placeList[1].ToString();
        }
        else
        {
            PlaceObj.GetComponent<TextMeshProUGUI>().text = DataController.selectGridData.place;
        };

        yearObj.GetComponent<TextMeshProUGUI>().text = DataController.selectGridData.year;
        keywordObj.GetComponent<TextMeshProUGUI>().text = keywordString(DataController.selectGridData.keyword);
        timeObj.GetComponent<TextMeshProUGUI>().text = DataController.CountTimeLine(DataController.selectGridData.playtime).ToString();

        // summaryObj.GetComponent<TextMeshProUGUI>().text = DataController.selectGridData.title;
        summaryObj.GetComponent<TextMeshProUGUI>().text = DataController.select_type == 0 ? DataController.selectGridData.title + "\n" + DataController.selectGridData.summary : DataController.selectGridData.summary;


        if (DataController.selectGridData.url == "dvd" || DataController.selectGridData.url == "DVD")
        {
            image_dvdObj.SetActive(true);
            image_videoObj.SetActive(false);
            videoScreenObj.SetActive(false);

        }
        else if (DataController.selectGridData.url == "비디오" || DataController.selectGridData.url.ToString().ToLower() == "video")
        {
            image_dvdObj.SetActive(false);
            image_videoObj.SetActive(true);
            videoScreenObj.SetActive(false);
        }
        else
        {
            image_dvdObj.SetActive(false);
            image_videoObj.SetActive(false);
            videoScreenObj.SetActive(true);
            try
            {
                video_Obj.GetComponent<UnityEngine.Video.VideoPlayer>().url = "file://" + Application.streamingAssetsPath + DataController.selectGridData.url;
            }
            catch (System.Exception)
            {

                throw;
            }



        }


        if (isfirst)
        {
            Row_Items.GetComponent<rowItemContorller>().rowItem();
        }
        else
        {

        }



        //year_groupObj 투명하게 
        year_groupObj.GetComponent<TextMeshProUGUI>().color = new Color(3 / 255f, 56 / 255f, 90 / 255f, 255f);
        titleObj.GetComponent<TextMeshProUGUI>().color = new Color(3 / 255f, 56 / 255f, 90 / 255f, 255f);
        titleObj01.GetComponent<TextMeshProUGUI>().color = new Color(3 / 255f, 56 / 255f, 90 / 255f, 255f);
        PlaceObj.GetComponent<TextMeshProUGUI>().color = new Color(3 / 255f, 56 / 255f, 90 / 255f, 255f);
        yearObj.GetComponent<TextMeshProUGUI>().color = new Color(3 / 255f, 56 / 255f, 90 / 255f, 255f);
        keywordObj.GetComponent<TextMeshProUGUI>().color = new Color(33 / 255f, 56 / 255f, 90 / 255f, 255f);
        timeObj.GetComponent<TextMeshProUGUI>().color = new Color(3 / 255f, 56 / 255f, 90 / 255f, 255f);
        summaryObj.GetComponent<TextMeshProUGUI>().color = new Color(3 / 255f, 56 / 255f, 90 / 255f, 255f);

        //검정색


        // if (isClicked == false)
        // {
        //     isClicked = true;

        //     int posy = 20;
        //     //year_groupObj pos y 10증가
        //     year_groupObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(year_groupObj.GetComponent<RectTransform>().anchoredPosition.x, year_groupObj_y + posy);
        //     titleObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(titleObj.GetComponent<RectTransform>().anchoredPosition.x, titleObj_y + posy);
        //     titleObj01.GetComponent<RectTransform>().anchoredPosition = new Vector2(titleObj01.GetComponent<RectTransform>().anchoredPosition.x, titleObj01_y + posy);
        //     PlaceObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(PlaceObj.GetComponent<RectTransform>().anchoredPosition.x, PlaceObj_y + posy);
        //     yearObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(yearObj.GetComponent<RectTransform>().anchoredPosition.x, yearObj_y + posy);
        //     keywordObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(keywordObj.GetComponent<RectTransform>().anchoredPosition.x, keywordObj_y + posy);
        //     timeObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(timeObj.GetComponent<RectTransform>().anchoredPosition.x, timeObj_y + posy);
        //     summaryObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(summaryObj.GetComponent<RectTransform>().anchoredPosition.x, summaryObj_y + posy);


        //     //year_groupObj 서서히 
        //     // StartCoroutine(fadeIn(year_groupObj, year_groupObj_y));
        //     //  StartCoroutine(fadeIn(titleObj, titleObj_y));
        //     // StartCoroutine(fadeIn(titleObj01, titleObj01_y));
        //     // StartCoroutine(fadeIn(PlaceObj, PlaceObj_y));
        //     // StartCoroutine(fadeIn(yearObj, yearObj_y));
        //     // StartCoroutine(fadeIn(keywordObj, keywordObj_y));
        //     // StartCoroutine(fadeIn(timeObj, timeObj_y));
        //     // StartCoroutine(fadeIn(summaryObj, summaryObj_y));

        //     isClicked = false;
        // }




        Debug.Log("select");

        // Debug.Log( DataController.selectGridData.title);
    }







    IEnumerator fadeIn(GameObject obj, float y)
    {

        //서서히 커짐        
        for (int i = 0; i < 100; i++)
        {
            //obj 투명도 0.02씩 
            obj.GetComponent<TextMeshProUGUI>().color = new Color(3 / 255f, 56 / 255f, 90 / 255f, obj.GetComponent<TextMeshProUGUI>().color.a + 0.02f);
            //obj pos y -20
            obj.GetComponent<RectTransform>().anchoredPosition = new Vector2(obj.GetComponent<RectTransform>().anchoredPosition.x, y);

            yield return new WaitForSeconds(0.01f);
        }




    }


    string keywordString(List<string> keyword)
    {
        string keywordstr = "";
        for (int i = 0; i < keyword.Count; i++)
        {
            keywordstr = i < keyword.Count - 1 ? keywordstr + keyword[i] + "," : keywordstr + keyword[i];
        }

        return keywordstr;
    }




}
