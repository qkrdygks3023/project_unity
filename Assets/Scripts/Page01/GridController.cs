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
    List<contentData> contentData = new List<contentData>();

    

    public Sprite temp;

    private Image img;
    void Start()
    {
        DataController = FindObjectOfType<dataController>();
        contentData = DataController.contentData;
        sliverGrid();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private Sprite GetSpritefromImage(string imgPath)
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

  

    public void sliverGrid()
    {
        GameObject newObj;
        Debug.Log("contentData.Count-- " + contentData.Count);
    


        for (int i = 0; i < contentData.Count; i++)
        {
            newObj = (GameObject)Instantiate(prefab, transform);
            // newObj.GetComponentInChildren<Image>().color = Random.ColorHSV();
     
            newObj.GetComponentInChildren<Image>().sprite = GetSpritefromImage(Application.streamingAssetsPath + contentData[i].thumbnail);     
            newObj.GetComponentInChildren<TextMeshProUGUI>().text = contentData[i].title;

            newObj.transform.Find("regdate").gameObject.GetComponent<TextMeshProUGUI>().text = DataController.CountTimeLine( contentData[i].playtime);

            newObj.gameObject.GetComponent<gridOnClick>().select_index = i;
 
    
 





            Debug.Log(" contentData -- " + contentData[i].thumbnail);

        }
    }
}
