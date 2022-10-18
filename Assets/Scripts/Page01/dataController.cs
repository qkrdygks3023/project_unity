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

    string SavePath =  Application.streamingAssetsPath;

    public  List<List<string>> subMain;
    public   List<string> Main;

    public int select_type;

    public string select_main;
    public string select_sub;

     public   List<int> MainList = new List<int>();
 
     public   List<List<string>> subMainList = new List<List<string>>();
     public   List<bool> openList = new List<bool>();



    public List<contentData> contentData = new List<contentData>();

       public   List<string> year_group = new List<string>();
       public   List<int> year_group_total = new List<int>();

        public   List<string> place_group = new  List<string>();


    void Awake(){
        JsonSave();
        JsonLoad();
        writeJson();
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
      
            SpriteRenderer spriteR = gameObject.GetComponent<SpriteRenderer>();
            Sprite[] sprites = Resources.LoadAll<Sprite>("/Users/parkyohan/Documents/dev_unity/project_unity/Assets/image");
      
            // [게임오브젝트].GetComponent<Image>().sprite = Resources.Load("[이미지경로]", typeof(Sprite)) as Sprite;
          
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
        
        saveData.Data0.Add(new Datajson("기록영상", 1950,  "0전생의 침상을 겸헝하다", "국방홍보원", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "www", "/images/ex.jpeg"));
        saveData.Data0.Add(new Datajson("기록영상", 1950,  "2950년대 전생의 침상을 겸헝하다", "국방홍보원", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "www", "/images/ex01.jpeg"));
        saveData.Data0.Add(new Datajson("기록영상", 1950,  "1950년대 전생의 침상을 겸헝하다", "국방홍보원", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "www", "/images/ex02.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1950,  "1950년대 전생의 침상을 겸헝하다", "국방홍보원", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "www", "/images/ex04.jpeg"));
        saveData.Data0.Add(new Datajson("기록영상", 1950,  "1950년대 전생의 침상을 겸헝하다", "국방홍보원", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "www", "/images/ex05.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1950,  "1950년대 전생의 침상을 겸헝하다", "국방홍보원", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "www", "/images/ex06.jpeg"));
        saveData.Data0.Add(new Datajson("기록영상", 1950,  "1950년대 전생의 침상을 겸헝하다", "국방홍보원", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "www", "/images/ex07.jpeg"));
        saveData.Data0.Add(new Datajson("기록영상", 1950,  "1950년대 전생의 침상을 겸헝하다", "국방홍보원", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "www", "/images/ex08.png"));

        saveData.Data0.Add(new Datajson("기록영상", 1950,  "1950년대 전생의 침상을 겸헝하다", "국방홍보원", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "www", "ex.jpeg"));
    
        saveData.Data0.Add(new Datajson("기록영상", 1960,   "1951년대 전생의 침상을 겸헝하다", "미국", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "www", "Assets/image/ex.jpeg"));
        saveData.Data0.Add(new Datajson("기록영상", 1960,  "전생의 침상을 겸헝하다", "궁밥홍보원", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "www", "image/ex.jpeg"));
        saveData.Data0.Add(new Datajson("기록영상", 1960,   "1951년대  겸헝하다", "국방홍보원(당시 국방홍보관리소)", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "www", "ex.jpeg"));
        saveData.Data0.Add(new Datajson("기록영상", 1960,   "전생의 침상을 겸헝하다", "국방홍보원(당시 국방홍보관리소)", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "www", "/Users/parkyohan/Documents/dev_unity/project_unity/Assets/image/ex.jpeg"));
        saveData.Data0.Add(new Datajson("기록영상", 1970,   "1960년대 전생의 침상을 겸헝하다", "국방홍보원(당시 국방홍보관리소)", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "www", "/Users/parkyohan/Documents/dev_unity/project_unity/Assets/image/ex.jpeg"));
        saveData.Data0.Add(new Datajson("기록영상", 1970, "전생의 침상을 겸헝하다", "국방홍보원(당시 국방홍보관리소)", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "www", "/Users/parkyohan/Documents/dev_unity/project_unity/Assets/image/ex.jpeg"));
        saveData.Data0.Add(new Datajson("기록영상", 1980, "전생의 침상을 겸헝하다", "국방홍보원(당시 국방홍보관리소)", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "www", "/Users/parkyohan/Documents/dev_unity/project_unity/Assets/image/ex.jpeg"));

        saveData.Data1.Add(new Datajson("전쟁영화", 1980,  "전생의 침상을 겸헝하다", "국방홍보원(당시 국방홍보관리소)", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "www", "www"));
        saveData.Data1.Add(new Datajson("전쟁영화", 1980,  "전생의 침상을 겸헝하다", "국방홍보원(당시 국방홍보관리소)", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "www", "www"));
        saveData.Data1.Add(new Datajson("전쟁영화", 1980,  "전생의 침상을 겸헝하다", "국방홍보원(당시 국방홍보관리소)", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "www", "www"));



        string json = JsonUtility.ToJson(saveData, true);
        string saveFilePath =  SavePath + "/datalist2.json";

        File.WriteAllText(saveFilePath, json);
    }

    public void JsonLoad()
    {
        string JsonLoadData =  SavePath + "/datalist2.json";
        string data = File.ReadAllText(JsonLoadData);
        saveData = JsonUtility.FromJson<SaveData>(data);
    
            

        var SelectData = saveData.Data0 ;

        if(select_type == 0){
            SelectData = saveData.Data0;
        }else if(select_type == 1){
            SelectData = saveData.Data1;
        }

        for (int i = 0; i < SelectData.Count; i++)
        {     
          year_group.Add(SelectData[i].group_year+"년대");  
          year_group_total.Add(SelectData[i].group_year);
          place_group.Add(SelectData[i].place);      
        }

        year_group =  year_group.Distinct().ToList();
        place_group =  place_group.Distinct().ToList();


        year_group = year_group.OrderBy(n => n).ToList();
        place_group = place_group.OrderBy(n => n).ToList();

        subMainList.Add(year_group);
        subMainList.Add(place_group);


        select_main = year_group[0];

        Debug.Log( "select_main -- " + select_main);
        Debug.Log( "select_main -- " + SelectData[0].group_year);
        Debug.Log( "select_main -- " + SelectData[0].group_year+"년대");
        Debug.Log( "select_main -- " + select_main == SelectData[0].group_year+"년대");







        //초반 데이터 셋팅
        for (int i = 0; i < SelectData.Count; i++)
        {
            if (select_main == SelectData[i].group_year+"년대")
            {
                contentData.Add(new contentData(
                SelectData[i].title,   
                SelectData[i].group_year,
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
        var sorted = contentData.OrderBy(ob => ob.title).ToList();       
        contentData.Clear();
        foreach (var i in sorted)
        {
            contentData.Add(i);
             Debug.Log( "sorted -- " + i);
        }

       

     























 
    //     List<string> subList = new List<string>();
    //     for (int i = 0; i < Main.Count; i++)
    //     {            
    //         subMainList.Add(subList);
    //     }


    //     for (int i = 0; i < Main.Count; i++)
    //     {       
    //         for (int j = 0; j < SelectData.Count; j++)
    //         {          
             
    //             if(Main[i] == SelectData[j].main && !subMainList[i].Contains(SelectData[j].submain)){
    //                 Debug.Log("********** " + Main[i] +" ***** " +  SelectData[j].main);
                 
    //                  Debug.Log("********** " + j + " - " +  subMainList[i] +  "--- " + SelectData[j].submain);

    //                  subMainList[i].Add(SelectData[j].submain);              
    //             }                 
    //         }          
    //     }

    //     foreach (var item in subMainList)
    //     {
    //          foreach (var i in item)
    //      {
    //           Debug.Log("foreach " +  i);

    //      }
    //     }
       



    //     for (int i = 0; i < Main.Count; i++)
    //     {
    //         for (int k = 0; k < subMainList[i].Count; k++)
    //         {
    //             Debug.Log(" ------------------=- " + "i - "  + i+ " k - " + k);
    //         }
    //     }



    //   subMain =  new   List<List<string>>();
    //     for (int i = 0; i < Main.Count; i++)
    //     {
    //     // subMain = subMainList[i].Distinct().ToList();
    //     // subMainList[i] = subMainList[i].OrderBy(n => n).ToList();
    //     //  Debug.Log("openList - " +subMainList[i][i]);
    //      openList.Add(true);
       
    //     }


    //     select_main = Main[0];  //연도별, 소장처별
    //     select_sub = subMainList[0][0]; //1950년대, 1960년대

    //     Debug.Log("select_main - " + select_main);
    //     Debug.Log("select_sub - " + select_sub);
        

    //     // for (int i = 0; i < Main.Length; i++)
    //     // {
    //     //     Debug.Log("Main - " + Main[i]);
    //     // }

    //     // for (int i = 0; i < subMain.Length; i++)
    //     // {
    //     //     Debug.Log("subMain - " + subMain[i]);
    //     // }











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
        // for (int i = 0; i < SelectData.Count; i++)
        // {
        //     if (select_main == SelectData[i].main && select_sub == SelectData[i].submain)
        //     {
        //         contentData.Add(new contentData(
        //         SelectData[i].main,
        //         SelectData[i].submain,
        //          SelectData[i].title,
        //          SelectData[i].place,
        //          SelectData[i].year,
        //          SelectData[i].keyword,
        //          SelectData[i].playtime,
        //          SelectData[i].summary,
        //          SelectData[i].url,
        //          SelectData[i].thumbnail));
        //     }
        // }


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
    public string type; //기록영상 
    public int group_year; // 1950
 
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


    public Datajson(string _type, int _group_year, string _title, string _place, string _year, List<string> _keyword, int _playtime, string _summary, string _url, string _thumbnail)
    {
        type = _type;
        group_year = _group_year;      
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

    public string type; //기록영상 
    public int group_year; // 1950
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

 
    public contentData(string _type,  int _group_year, string _title, string _place, string _year, List<string> _keyword, int _playtime, string _summary, string _url, string _thumbnail)
    {
        type = _type;
        group_year = _group_year;
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


