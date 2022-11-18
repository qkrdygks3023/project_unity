using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainController : MonoBehaviour
{

    public static MainController control;
    public int stageNum;
    public GameObject StageManager;
    public List<GameObject> grid_items = new List<GameObject>();

    public GameObject prefab;

    TabController tabController;

    void Awake()
    {
        var obj = FindObjectsOfType<MainController>();
        stageNum = 0;

        if (obj.Length == 1)
        {
            Debug.Log("DontDestroyOnLoad 1");
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Debug.Log("Destroy");
            Destroy(gameObject);
        }


    }

    // Start is called before the first frame update
    void Start()
    {
        //  GameObject newObj;
        // for (int i = 0; i < 400; i++)
        // {
        //     newObj = (GameObject)Instantiate(prefab, transform);
        //     newObj.SetActive(false);
        //     grid_items.Add(newObj);
        // }
    }

    // Update is called once per frame
    void Update()
    {


        // if (Input.GetKeyDown(KeyCode.DownArrow))
        // {
        //     SceneManager.LoadScene("PageScene");
        //     Debug.Log("Down");
        // }

    }

    //stage num 받아와서 다른 씬으로 토스
    public void mainNumController(int Num)
    {
        stageNum = Num;
        Debug.Log(" mainNum -  " + stageNum);


    }




}
