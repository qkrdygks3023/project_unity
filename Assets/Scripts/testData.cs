using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class testData : MonoBehaviour
{
    string SavePath = Application.streamingAssetsPath;
    // Start is called before the first frame update
    void Start()
    {
        loadFile();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void loadFile()
    {
        Debug.Log("test");
        string path = SavePath + "/data.json";
        var jsonString = File.ReadAllText(path);
        var saveData = JsonUtility.FromJson<datajson01>(jsonString);



        Debug.Log(saveData);

        // for (int i = 0; i < saveData.Length; i++)
        // {
        //     Debug.Log(i);
        //     Debug.Log(jsonString[i]);

        // }

    }
}


[System.Serializable]
public class datajson01
{
    public List<Dictionary<string, string>> key01;

    public datajson01(List<Dictionary<string, string>> _key01)
    {
        key01 = _key01;

    }
}