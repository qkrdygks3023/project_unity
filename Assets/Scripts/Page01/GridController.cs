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

        private Sprite GetSpritefromImage(string imgPath) {
 
        //Converts desired path into byte array
        byte[] pngBytes = System.IO.File.ReadAllBytes(imgPath);
 
        //Creates texture and loads byte array data to create image
        Texture2D tex = new Texture2D(2, 2);
        tex.LoadImage(pngBytes);
 
        //Creates a new Sprite based on the Texture2D
        Sprite fromTex = Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), new Vector2(0.5f, 0.5f), 100.0f);
 
        return fromTex;
 
    }
    private Image img;
    void sliverGrid(){
    GameObject newObj;
            Debug.Log( "contentData.Count-- " + contentData.Count);

          

    for (int i = 0; i < contentData.Count; i++)
        {
            newObj = (GameObject)Instantiate(prefab, transform);
            // newObj.GetComponentInChildren<Image>().color = Random.ColorHSV();
            //[게임오브젝트].GetComponent<Image>().sprite = Resources.Load("[이미지경로]", typeof(Sprite)) as Sprite;
            //
            newObj.GetComponentInChildren<Image>().sprite = GetSpritefromImage(Application.streamingAssetsPath + contentData[i].thumbnail);
            // newObj.GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>(Application.streamingAssetsPath + contentData[i].thumbnail);
            
//            string PATH = "/Users/parkyohan/Documents/dev_unity/project_unity/Assets/image/ex07";	

            // GameObject a = Instantiate(Resources.Load(PATH, typeof(GameObject)))as GameObject;

            // GameObject B = Instantiate(Resources.Load<GameObject>(PATH));
            
            // newObj.GetComponentInChildren<SpriteRenderer>().sprite =  Resources.Load<Sprite>(contentData[i].thumbnail);
            // newObj.GetComponentInChildren<SpriteRenderer>().sprite = Resources.Load(contentData[i].thumbnail, typeof(Sprite)) as Sprite;

            // newObj.GetComponentInChildren<SpriteRenderer>().sprite =  Resources.Load(PATH,typeof(Sprite)) as Sprite;
          	//이미지 위치를 저장하는 변수    

            // Sprite  sprite = Resources.Load <Sprite>("image/ex07");
            // Debug.Log(sprite);

 
            // newObj.GetComponentInChildren<SpriteRenderer>().sprite =  Resources.Load(PATH,typeof(Sprite)) as Sprite;	//이미지 로드
        	// sprite = Resources.Load <Sprite>("Images/SampleSprite");
    		// GameObject image = GameObject.Find ("Image");
	    	// image.GetComponent<Image>().sprite = sprite;



            
            newObj.GetComponentInChildren<TextMeshProUGUI>().text = contentData[i].title;  

         

            // newObj.GetComponentInChildren<griditem>(). = 


        
            Debug.Log( " contentData -- " + contentData[i].thumbnail);
       
        }
    }
}
