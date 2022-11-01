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




    public string group_subbtn_title;
    public string select_year;

    rowItemContorller rowItemContorller;

   public bool isLoad;
   private bool isClicked = false;

    void Start()
    {

        DataController = FindObjectOfType<dataController>();
        rowItemContorller = FindObjectOfType<rowItemContorller>();

        Debug.Log("activity");
     

    }

    // Update is called once per frame
    void Update()
    {

    }

    //grid select
    public void select()
    {

        newBody.gameObject.SetActive(true);
        year_groupObj.GetComponent<TextMeshProUGUI>().text = DataController.selectGridData.group_year + "년대";
        titleObj.GetComponent<TextMeshProUGUI>().text = DataController.selectGridData.title;
        titleObj01.GetComponent<TextMeshProUGUI>().text = DataController.selectGridData.title;
        PlaceObj.GetComponent<TextMeshProUGUI>().text = DataController.selectGridData.place;
        yearObj.GetComponent<TextMeshProUGUI>().text = DataController.selectGridData.year;
        keywordObj.GetComponent<TextMeshProUGUI>().text = keywordString(DataController.selectGridData.keyword);
        timeObj.GetComponent<TextMeshProUGUI>().text = DataController.CountTimeLine(DataController.selectGridData.playtime).ToString();
        summaryObj.GetComponent<TextMeshProUGUI>().text = DataController.selectGridData.summary;
        Row_Items.GetComponent<rowItemContorller>().rowItem();
        video_Obj.GetComponent<UnityEngine.Video.VideoPlayer>().url = "file://" + Application.streamingAssetsPath + DataController.selectGridData.url;


        //year_groupObj 투명하게 
        year_groupObj.GetComponent<TextMeshProUGUI>().color = new Color(1, 1, 1, 0);
        titleObj.GetComponent<TextMeshProUGUI>().color = new Color(1, 1, 1, 0);
        titleObj01.GetComponent<TextMeshProUGUI>().color = new Color(1, 1, 1, 0);
        PlaceObj.GetComponent<TextMeshProUGUI>().color = new Color(1, 1, 1, 0);
        yearObj.GetComponent<TextMeshProUGUI>().color = new Color(1, 1, 1, 0);
        keywordObj.GetComponent<TextMeshProUGUI>().color = new Color(1, 1, 1, 0);
        timeObj.GetComponent<TextMeshProUGUI>().color = new Color(1, 1, 1, 0);
        summaryObj.GetComponent<TextMeshProUGUI>().color = new Color(1, 1, 1, 0);

        if (isClicked == false)
        {
            isClicked = true;

            int posy = 20;
            //year_groupObj pos y 10증가
            year_groupObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(year_groupObj.GetComponent<RectTransform>().anchoredPosition.x, year_groupObj.GetComponent<RectTransform>().anchoredPosition.y + posy);
            titleObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(titleObj.GetComponent<RectTransform>().anchoredPosition.x, titleObj.GetComponent<RectTransform>().anchoredPosition.y + posy);
            titleObj01.GetComponent<RectTransform>().anchoredPosition = new Vector2(titleObj01.GetComponent<RectTransform>().anchoredPosition.x, titleObj01.GetComponent<RectTransform>().anchoredPosition.y + posy);
            PlaceObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(PlaceObj.GetComponent<RectTransform>().anchoredPosition.x, PlaceObj.GetComponent<RectTransform>().anchoredPosition.y + posy);
            yearObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(yearObj.GetComponent<RectTransform>().anchoredPosition.x, yearObj.GetComponent<RectTransform>().anchoredPosition.y + posy);
            keywordObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(keywordObj.GetComponent<RectTransform>().anchoredPosition.x, keywordObj.GetComponent<RectTransform>().anchoredPosition.y + posy);
            timeObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(timeObj.GetComponent<RectTransform>().anchoredPosition.x, timeObj.GetComponent<RectTransform>().anchoredPosition.y + posy);
            summaryObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(summaryObj.GetComponent<RectTransform>().anchoredPosition.x, summaryObj.GetComponent<RectTransform>().anchoredPosition.y + posy);


            //year_groupObj 서서히 
            StartCoroutine(fadeIn(year_groupObj));
            StartCoroutine(fadeIn(titleObj));
            StartCoroutine(fadeIn(titleObj01));
            StartCoroutine(fadeIn(PlaceObj));
            StartCoroutine(fadeIn(yearObj));
            StartCoroutine(fadeIn(keywordObj));
            StartCoroutine(fadeIn(timeObj));
            StartCoroutine(fadeIn(summaryObj));

            isClicked = false;
        }


        Debug.Log("select");

        // Debug.Log( DataController.selectGridData.title);
    }

    IEnumerator fadeIn(GameObject obj)
    {

        //서서히 커짐        
        for (int i = 0; i < 100; i++)
        {
            //obj 투명도 0.02씩 
            obj.GetComponent<TextMeshProUGUI>().color = new Color(1, 1, 1, obj.GetComponent<TextMeshProUGUI>().color.a + 0.02f);
            //obj pos y -20
            obj.GetComponent<RectTransform>().anchoredPosition = new Vector2(obj.GetComponent<RectTransform>().anchoredPosition.x, obj.GetComponent<RectTransform>().anchoredPosition.y - 0.20f);

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
