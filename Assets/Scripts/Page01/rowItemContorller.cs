using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;
using System.IO;


public class rowItemContorller : MonoBehaviour
{
    // Start is called before the first frame update

    dataController dataController;
    GridController gridController;
    public GameObject prefab;
    List<contentData> contentData = new List<contentData>();



    void Start()
    {
        dataController = FindObjectOfType<dataController>();
        gridController = FindObjectOfType<GridController>();
        contentData = dataController.contentData;
        rowItem();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void rowItem()
    {
        StartCoroutine(rowGen());
    }

    IEnumerator rowGen()
    {
        GameObject newObj;

        Debug.Log(" rowItem -- " + contentData.Count);

        //tag row_item 찾기
        GameObject[] tagItems = GameObject.FindGameObjectsWithTag("row_item");

        Debug.Log(" tagItems -- " + tagItems.Length);

        for (int i = 0; i < tagItems.Length; i++)
        {
            Destroy(tagItems[i]);
        }

        for (int i = 0; i < contentData.Count; i++)
        {
            newObj = (GameObject)Instantiate(prefab, transform);

            newObj.GetComponentInChildren<Image>().sprite = GetSpritefromImage(Application.streamingAssetsPath + contentData[i].thumbnail);
            newObj.GetComponentInChildren<TextMeshProUGUI>().text = contentData[i].title;
            newObj.gameObject.GetComponent<rowitemClick>().index = i;
            yield return null;
            Debug.Log("rowItem - " + contentData[i].thumbnail);
        }
    }

    public Sprite GetSpritefromImage(string imgPath)
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
}
