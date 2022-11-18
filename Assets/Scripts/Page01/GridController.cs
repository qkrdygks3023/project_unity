using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using TMPro;
using System.Linq;

public class GridController : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
    public int numberToCreate;
    dataController DataController;
    MainController mainContoller;
    List<contentData> contentData = new List<contentData>();

    List<GameObject> items = new List<GameObject>();

    public GameObject contentObject;


    // public GameObject mainContoller;





    public Sprite temp;

    private Image img;

    public bool isload = false;
    void Start()
    {
        DataController = FindObjectOfType<dataController>();
        mainContoller = FindObjectOfType<MainController>();

        items = GameObject.Find("MainController").GetComponent<MainController>().grid_items;

        contentData = DataController.contentData;



        sliverGrid();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public Sprite GetSpritefromImage(string imgPath)
    {
        try
        {
            //Converts desired path into byte array
            byte[] pngBytes = System.IO.File.ReadAllBytes(imgPath);

            //Creates texture and loads byte array data to create image
            Texture2D tex = new Texture2D(2, 2);
            tex.LoadImage(pngBytes);

            //Creates a new Sprite based on the Texture2D
            Sprite fromTex = Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), new Vector2(0.5f, 0.5f), 100.0f);

            return fromTex;
        }
        catch (System.Exception)
        {

            throw;
        }

    }



    public void sliverGrid()
    {

        StartCoroutine(GridGen());

    }
    IEnumerator GridGen()
    {

        GameObject newObj;
        Debug.Log("contentData.Count-- " + contentData.Count);
        if (isload == false)
        {

            // isload = true;
            // foreach(var item in contentData)
            // {
            //     newObj = Instantiate(prefab, transform);
            //     newObj.GetComponentInChildren<Image>().sprite = GetSpritefromImage(Application.streamingAssetsPath + item.thumbnail);
            //     newObj.GetComponentInChildren<TextMeshProUGUI>().text = item.title;
            //     newObj.transform.Find("regdate").gameObject.GetComponent<TextMeshProUGUI>().text = DataController.CountTimeLine(item.playtime);
            //     newObj.gameObject.GetComponent<gridOnClick>().select_index = 0;
            // }
            for (int i = 0; i < contentData.Count; i++)
            {
                Debug.Log("contentData.Count-- " + contentData.Count);
                Debug.Log("mainContoller.GetComponent<MainController>().grid_items-- " + mainContoller.grid_items.Count);


                // items[i].transform.SetParent(this.transform);

                // items[i].SetActive(true);
                // items[i].GetComponentInChildren<Image>().sprite = GetSpritefromImage(Application.streamingAssetsPath + contentData[i].thumbnail);
                // items[i].GetComponentInChildren<TextMeshProUGUI>().text = contentData[i].title;
                // items[i].transform.Find("regdate").gameObject.GetComponent<TextMeshProUGUI>().text = DataController.CountTimeLine(contentData[i].playtime);
                // items[i].gameObject.GetComponent<gridOnClick>().select_index = i;


                if (prefab == null)
                {
                    break;
                }
                if (prefab != null)
                {

                    // items[i].SetActive(true);
                    // items[i].GetComponentInChildren<Image>().sprite = GetSpritefromImage(Application.streamingAssetsPath + contentData[i].thumbnail);
                    // items[i].GetComponentInChildren<TextMeshProUGUI>().text = contentData[i].title;
                    // items[i].transform.Find("regdate").gameObject.GetComponent<TextMeshProUGUI>().text = DataController.CountTimeLine(contentData[i].playtime);
                    // items[i].gameObject.GetComponent<gridOnClick>().select_index = i;

                    // newObj.GetComponentInChildren<Image>().color = Random.ColorHSV();
                    //newObj 투명도 0

                    // newObj.GetComponentInChildren<Image>().color = new Color(1, 1, 1, 0);
                    // newObj.GetComponentInChildren<TextMeshProUGUI>().color = new Color(0, 0, 0, 1);
                    // newObj.transform.Find("regdate").gameObject.GetComponent<TextMeshProUGUI>().color = new Color(0, 0, 0, 1);

                    // if (newObj != null)
                    // {
                    //     StartCoroutine(fadeIn(newObj));
                    // }

                    newObj = (GameObject)Instantiate(prefab, transform);

                    newObj.GetComponentInChildren<Image>().sprite = GetSpritefromImage(Application.streamingAssetsPath + contentData[i].thumbnail);

                    newObj.GetComponentInChildren<TextMeshProUGUI>().text = contentData[i].title;
                    newObj.transform.Find("regdate").gameObject.GetComponent<TextMeshProUGUI>().text = DataController.CountTimeLine(contentData[i].playtime);
                    newObj.gameObject.GetComponent<gridOnClick>().select_index = i;
                    yield return null;


                    //1초 대기           
                    Debug.Log(" contentData -- " + contentData[i].thumbnail);
                }


            }
            isload = false;



        }



    }
    IEnumerator fadeIn(GameObject obj)
    {
        if (obj == null)
        {
            yield return null;
        }


        if (obj != null)
        {
            //서서히 커짐        
            for (int i = 0; i < 10; i++)
            {
                // obj null 체크 
                if (obj == null)
                {
                    yield return null;
                }

                if (obj != null)
                {
                    //obj 투명도 0.02씩 
                    obj.GetComponentInChildren<Image>().color = new Color(1, 1, 1, obj.GetComponentInChildren<Image>().color.a + 0.2f);
                    obj.GetComponentInChildren<TextMeshProUGUI>().color = new Color(0, 0, 0, obj.GetComponentInChildren<TextMeshProUGUI>().color.a + 0.2f);
                    obj.transform.Find("regdate").gameObject.GetComponent<TextMeshProUGUI>().color = new Color(0, 0, 0, obj.transform.Find("regdate").gameObject.GetComponent<TextMeshProUGUI>().color.a + 0.2f);
                    yield return new WaitForSeconds(0.1f);

                }


                //obj pos y -20
                // obj.GetComponent<RectTransform>().anchoredPosition = new Vector2(obj.GetComponent<RectTransform>().anchoredPosition.x, obj.GetComponent<RectTransform>().anchoredPosition.y - 0.20f);

            }
        }


    }

}
