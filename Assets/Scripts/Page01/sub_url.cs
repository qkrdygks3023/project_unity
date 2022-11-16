using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class sub_url : MonoBehaviour
{
    // Start is called before the first frame update

    dataController DataController;
    public List<string> urls = new List<string>();
    public List<string> url_titleList = new List<string>();


    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void btn_url_Click()
    {
        Debug.Log("btn url");
        Debug.Log(GetComponentInChildren<TextMeshProUGUI>().text);


        DataController = FindObjectOfType<dataController>();
        url_titleList = DataController.url_list;
        urls = DataController.urls;

        string title = "";
        string url = "";
        int index = 0;

        title = gameObject.GetComponentInChildren<TextMeshProUGUI>().text;

        index = url_titleList.FindIndex(a => a.Contains(title));
        url = urls[index];

        string[] thisArray =  url.Split(':');
        string thisUrl = thisArray[0];
        Debug.Log(thisUrl);

       

        try{
             if (thisUrl == "http" || thisUrl == "https")
            {
                Application.OpenURL(url);
            }
            else
            {
                Application.OpenURL("http://" + url);
            }
            // Application.OpenURL(url);
        }
         catch (System.Exception)
            {
                Debug.Log("url error");
                throw;
            }
     
    }
}
