using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;
using System;

public class dataController : MonoBehaviour
{
    // Start is called before the first frame update


    public List<Datajson> datalist = new List<Datajson>();
    public List<List<Datajson>> datalist01;

    public SaveData saveData;
    string saveJson;

    public string SavePath = "/Users/parkyohan/Documents/dev_unity/project_unity/Assets/Data/";

    public string[] subMain;
    public  string[] Main;

    public int select_type;

    public string select_main;
    public string select_sub;

     public   List<string> MainList = new List<string>();
     public   List<string> subMainList = new List<string>();


    List<contentData> contentData = new List<contentData>();

    void Awake(){
        JsonSave();
        JsonLoad();
    }
    void Start()
    {
        //  writeJson();
     
        // selectData();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void writeJson()
    {
        // datalist.Add(new Datajson("a", 10, "z"));

        // datalist.Add(new Datajson("b", 20, "x"));
        // datalist.Add(new Datajson("c", 40, "c"));
        // datalist.Add(new Datajson("d", 50, "v"));



        for (int i = 0; i < datalist.Count; i++)
        {
            // Debug.Log(datalist[i].Time);
            // saveJson = JsonUtility.ToJson(datalist[i].Time);
        }



        Debug.Log(datalist.Count);
        Debug.Log(saveJson);
        string SavePath = "/Users/parkyohan/Documents/dev_unity/project_unity/Assets/Data/";
        Debug.Log(SavePath);
        string saveFilePath = SavePath + "datalist" + ".json";

        File.WriteAllText(saveFilePath, saveJson);
        Debug.Log("Save Success: " + saveFilePath);

        // JsonData json1 = JsonMapper.ToJson

        // JsonData json = JsonUtility.ToJson(datalist);
    }


    public void JsonSave()
    {
        SaveData saveData = new SaveData();

        // for (int i = 0; i < 10; i++)
        // {
        //     saveData.testDataA.Add("테스트 데이터 no " + i);
        // }

        // for (int i = 0; i < 10; i++)
        // {
        //     saveData.testDataB.Add(i);
        // }

        // for (int i = 0; i < 10; i++)
        // {
        //     saveData.testDataC.Add(new Datajson("d", i, "v"));
        // }

        saveData.gold = 5;
        saveData.power = 10;

        //0 기록영상, 1 전쟁영화

        saveData.Data0.Add(new Datajson(0, "연도별", "1950년대", "0전생의 침상을 겸헝하다", "국방홍보원(당시 국방홍보관리소)", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "www", "www"));
        saveData.Data0.Add(new Datajson(0, "연도별", "1950년대", "2950년대 전생의 침상을 겸헝하다", "국방홍보원(당시 국방홍보관리소)", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "www", "www"));
        saveData.Data0.Add(new Datajson(0, "연도별", "1950년대", "1950년대 전생의 침상을 겸헝하다", "국방홍보원(당시 국방홍보관리소)", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "www", "www"));
    
        saveData.Data0.Add(new Datajson(0, "연도별", "1951년대", "1951년대 전생의 침상을 겸헝하다", "국방홍보원(당시 국방홍보관리소)", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "www", "www"));
        saveData.Data0.Add(new Datajson(0, "연도별", "1951년대", "전생의 침상을 겸헝하다", "국방홍보원(당시 국방홍보관리소)", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "www", "www"));
        saveData.Data0.Add(new Datajson(0, "연도별", "1951년대", "1951년대  겸헝하다", "국방홍보원(당시 국방홍보관리소)", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "www", "www"));
        saveData.Data0.Add(new Datajson(0, "연도별", "1951년대", "전생의 침상을 겸헝하다", "국방홍보원(당시 국방홍보관리소)", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "www", "www"));
        saveData.Data0.Add(new Datajson(0, "연도별", "1960년대", "1960년대 전생의 침상을 겸헝하다", "국방홍보원(당시 국방홍보관리소)", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "www", "www"));
        saveData.Data0.Add(new Datajson(0, "소장처별", "1953년대", "전생의 침상을 겸헝하다", "국방홍보원(당시 국방홍보관리소)", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "www", "www"));
        saveData.Data0.Add(new Datajson(0, "소장처별", "1954년대", "전생의 침상을 겸헝하다", "국방홍보원(당시 국방홍보관리소)", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "www", "www"));


        saveData.Data1.Add(new Datajson(1, "전쟁연도별", "1955년대", "전생의 침상을 겸헝하다", "국방홍보원(당시 국방홍보관리소)", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "www", "www"));
        saveData.Data1.Add(new Datajson(1, "전쟁연도별", "1955년대", "전생의 침상을 겸헝하다", "국방홍보원(당시 국방홍보관리소)", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "www", "www"));
        saveData.Data1.Add(new Datajson(1, "전쟁연도별", "1955년대", "전생의 침상을 겸헝하다", "국방홍보원(당시 국방홍보관리소)", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "www", "www"));


        string json = JsonUtility.ToJson(saveData, true);
        string saveFilePath = SavePath + "datalist" + ".json";

        File.WriteAllText(saveFilePath, json);
    }

    public void JsonLoad()
    {
        string JsonLoadData = SavePath + "datalist" + ".json";
        string data = File.ReadAllText(JsonLoadData);
        saveData = JsonUtility.FromJson<SaveData>(data);
        MainList = new List<string>();
        subMainList = new List<string>();
        select_type = 0;
         
        var SelectData = saveData.Data0 ;

        if(select_type == 0){
            SelectData = saveData.Data0;
        }else if(select_type == 1){
            SelectData = saveData.Data1;
        }

        for (int i = 0; i < SelectData.Count; i++)
        {
            Debug.Log("Load - " + i);
            MainList.Add(SelectData[i].main);
            subMainList.Add(SelectData[i].submain);
        }

        Main = MainList.Distinct().ToArray();
        subMain = subMainList.Distinct().ToArray();
        subMain = subMain.OrderBy(n => n).ToArray();

      
        select_main = Main[0];  //연도별, 소장처별
        select_sub = subMain[0]; //1950년대, 1960년대

        Debug.Log("select_main - " + select_main);
        Debug.Log("select_sub - " + select_sub);

        // for (int i = 0; i < Main.Length; i++)
        // {
        //     Debug.Log("Main - " + Main[i]);
        // }

        // for (int i = 0; i < subMain.Length; i++)
        // {
        //     Debug.Log("subMain - " + subMain[i]);
        // }

        //초반 데이터 셋팅
        for (int i = 0; i < SelectData.Count; i++)
        {
            if (select_main == SelectData[i].main && select_sub == SelectData[i].submain)
            {
                contentData.Add(new contentData(
                SelectData[i].main,
                SelectData[i].submain,
                 SelectData[i].title,
                 SelectData[i].place,
                 SelectData[i].year,
                 SelectData[i].keyword,
                 SelectData[i].playtime,
                 SelectData[i].summary,
                 SelectData[i].url,
                 SelectData[i].thumbnail));
            }
        }

        var sorted = contentData.OrderBy(ob => ob.title).ToArray();       
        contentData.Clear();
        foreach (var i in sorted)
        {
            contentData.Add(i);
        }
        foreach (var i in contentData)
        {
          Debug.Log("contentData - " + i.title);
        }



        // selectData(0, select_main,  select_sub);

    }

    public void selectData(int type, string _main, string _sub)
    {
        contentData.Clear();
        var SelectData = saveData.Data0;
        if (type == 0)
        {
            SelectData = saveData.Data0;
        }
        if (type == 1)
        {
            SelectData = saveData.Data1;
        }
        if (type == 2)
        {
            SelectData = saveData.Data2;
        }

        //데이터 재 새팅 
        for (int i = 0; i < SelectData.Count; i++)
        {
            if (select_main == SelectData[i].main && select_sub == SelectData[i].submain)
            {
                contentData.Add(new contentData(
                SelectData[i].main,
                SelectData[i].submain,
                 SelectData[i].title,
                 SelectData[i].place,
                 SelectData[i].year,
                 SelectData[i].keyword,
                 SelectData[i].playtime,
                 SelectData[i].summary,
                 SelectData[i].url,
                 SelectData[i].thumbnail));
            }
        }


        var sorted = contentData.OrderBy(ob => ob.title).ToArray(); 
        contentData.Clear();
        foreach (var i in sorted)
        {
            contentData.Add(i);
        }

        foreach (var i in contentData)
        {
          Debug.Log("contentData - " + i.title);
        }
          
    }
}


[System.Serializable]
public class SaveData
{
    public List<string> testDataA = new List<string>();
    public List<int> testDataB = new List<int>();
    public List<Datajson> Data0 = new List<Datajson>();
    public List<Datajson> Data1 = new List<Datajson>();
    public List<Datajson> Data2 = new List<Datajson>();

    public int gold;
    public int power;
    public string title;

}




[System.Serializable]
public class Datajson
{
    public int type; //기록영상 0 1 2 3
    public string main; //연도별 소장처별
    public string submain; //1950년대
    public string title; //전생의 침상을 경험하다
    // public string subtitle; //
    // public string name; //
    public string place; //원소장치
    public string year; //2000년
    public List<string> keyword; //키워드
    public int playtime; //재생시간
    public string summary; //요약
    public string url; //비디오 영상
    public string thumbnail; //비디오 영상


    public Datajson(int _type, string _main, string _submain, string _title, string _place, string _year, List<string> _keyword, int _playtime, string _summary, string _url, string _thumbnail)
    {
        type = _type;
        main = _main;
        submain = _submain;
        title = _title;
        place = _place;
        year = _year;
        keyword = _keyword;
        playtime = _playtime;
        summary = _summary;
        url = _url;
        thumbnail = _thumbnail;
    }
}

public class contentData
{


    public string main; //연도별 소장처별
    public string submain; //1950년대
    public string title; //전생의 침상을 경험하다
    // public string subtitle; //
    // public string name; //
    public string place; //원소장치
    public string year; //2000년
    public List<string> keyword; //키워드
    public int playtime; //재생시간
    public string summary; //요약
    public string url; //비디오 영상
    public string thumbnail; //비디오 영상

 
    public contentData(string _main, string _submain, string _title, string _place, string _year, List<string> _keyword, int _playtime, string _summary, string _url, string _thumbnail)
    {
        main = _main;
        submain = _submain;
        title = _title;
        place = _place;
        year = _year;
        keyword = _keyword;
        playtime = _playtime;
        summary = _summary;
        url = _url;
        thumbnail = _thumbnail;
    }
}


