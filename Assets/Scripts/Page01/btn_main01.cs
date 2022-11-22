using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using System;

public class btn_main01 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void btn_libray_Click()
    {
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string SavePath = Application.streamingAssetsPath;
        // string url = DataController.url;
        string url = SavePath + "\\webExecute.bat";



        Process.Start(url);


    }
}
