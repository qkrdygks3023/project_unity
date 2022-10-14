using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Linq;


public class btnController : MonoBehaviour
{
    // Start is called before the first frame update

    dataController DataController;
    pageController PageController;
    int stageNum;
    string main;
    string submain;

    List<contentData> contentData = new List<contentData>();
    public string[] subMain;
     public   string[] Main;


    void Start()
    {
     DataController = FindObjectOfType<dataController>();
     PageController = FindObjectOfType<pageController>();

    stageNum = PageController.stageNum;
    main = DataController.select_main;
    submain = DataController.select_sub;

    Main = DataController.Main;
    subMain = DataController.subMain;

 
    foreach (var item in Main)
    {
        Debug.Log("btnContrler - " + item);
    }
         Debug.Log(" - btnContrler - ");
         Debug.Log(" - btnContrler - ");

        //  Debug.Log( Main.ToArray().Count );
 




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
