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

    string SavePath = Application.streamingAssetsPath;

    public List<List<string>> subMain;
    public List<string> Main;

    public int select_type;

    public string select_main;
    public string select_sub;

    public List<int> MainList = new List<int>();

    public List<List<string>> subMainList = new List<List<string>>();
    public List<bool> openList = new List<bool>();



    public List<contentData> contentData = new List<contentData>();

    public Dictionary<string, int> dictYear;

    public List<string> year_group = new List<string>();
    public List<int> year_group_total = new List<int>();

    public List<string> place_group = new List<string>();

    public contentData selectGridData;

    void Awake()
    {
        JsonSave();
        JsonLoad();
        // writeJson();
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

    // private void writeJson()
    // {      
    //         SpriteRenderer spriteR = gameObject.GetComponent<SpriteRenderer>();
    //         Sprite[] sprites = Resources.LoadAll<Sprite>("/Users/parkyohan/Documents/dev_unity/project_unity/Assets/image");
    //         // [게임오브젝트].GetComponent<Image>().sprite = Resources.Load("[이미지경로]", typeof(Sprite)) as Sprite;
    // }

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

        saveData.Data0.Add(new Datajson("기록영상", 1950, "0전생의 침상을 겸헝하다", "국방홍보원", "2010년", new List<string> { "a", "b", "c" }, 6000, "전쟁의 참상을 표현한다 다큐멘터리", "/movies/videoex.mp4", "/images/ex01.jpeg"));
        saveData.Data0.Add(new Datajson("기록영상", 1950, "2950년대 전생의 겸헝하다", "국방홍보원", "2020년", new List<string> { "a", "b", "c" }, 3600, "전쟁의 참상을 표현한다 다큐멘터리", "/movies/videoex.mp4", "/images/ex01.jpeg"));
        saveData.Data0.Add(new Datajson("기록영상", 1950, "950년대  겸헝하다", "국방홍보원", "1990년", new List<string> { "a", "b", "c" }, 60000, "전쟁의 참상을 표현한다 다큐멘터리", "/movies/videoex.mp4", "/images/ex02.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1950, "150 겸헝하다", "국방홍보원", "1990년", new List<string> { "a", "b", "c" }, 60000, "전쟁의 참상을 표현한다 다큐멘터리", "/movies/videoex.mp4", "/images/ex04.jpeg"));
        saveData.Data0.Add(new Datajson("기록영상", 1950, "195년대 전생의 침상을 겸헝하다", "국방홍보원", "2000년", new List<string> { "a", "b", "c" }, 6000, "전쟁의 참상을 표현한다 다큐멘터리", "/movies/videoex.mp4", "/images/ex05.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1950, "1950년대 전생의 침상을 겸헝하다", "국방홍보원", "2000년", new List<string> { "a", "b", "c" }, 8000, "전쟁의 참상을 표현한다 다큐멘터리", "/movies/videoex.mp4", "/images/ex06.jpeg"));
        saveData.Data0.Add(new Datajson("기록영상", 1950, "19", "국방홍보원", "2000년", new List<string> { "a", "b", "c" }, 50000, "전쟁의 참상을 표현한다 다큐멘터리", "/movies/videoex.mp4", "/images/ex07.jpeg"));
        saveData.Data0.Add(new Datajson("기록영상", 1950, "1950년대 전생의 침상을 겸헝하다", "국방홍보원", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "/movies/videoex.mp4", "/images/ex08.png"));

        saveData.Data0.Add(new Datajson("기록영상", 1950, "1950년대 전생의 침상을 겸헝하다", "국방홍보원", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "/movies/videoex.mp4", "/images/ex05.png"));

        saveData.Data0.Add(new Datajson("기록영상", 1960, "1951년대 전생의 침상을 겸헝하다", "국방홍보원", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "/movies/videoex.mp4", "/images/ex05.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1960, "전생의 침상을 겸헝하다", "궁밥홍보원", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "/movies/videoex.mp4", "/images/ex05.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1960, "1951년대  겸헝하다", "국방홍보원(당시 국방홍보관리소)", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "/movies/videoex.mp4", "/images/ex05.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1960, "전생의 침상을 겸헝하다", "국방홍보원(당시 국방홍보관리소)", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "/movies/videoex.mp4", "/images/ex05.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1970, "1960년대 전생의 침상을 겸헝하다", "국방홍보원(당시 국방홍보관리소)", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "/movies/videoex.mp4", "/images/ex05.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1970, "전생의 침상을 겸헝하다", "국방홍보원(당시 국방홍보관리소)", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "/movies/videoex.mp4", "/images/ex05.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1980, "전생의 침상을 겸헝하다", "국방홍보원(당시 국방홍보관리소)", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "/movies/videoex.mp4", "/images/ex05.png"));

        saveData.Data1.Add(new Datajson("전쟁영화", 1980, "전생의 침상을 겸헝하다", "국방홍보원(당시 국방홍보관리소)", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "/movies/videoex.mp4", "/images/ex02.png"));
        saveData.Data1.Add(new Datajson("전쟁영화", 1980, "전생의 침상을 겸헝하다", "국방홍보원(당시 국방홍보관리소)", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "www", "/images/ex02.png"));
        saveData.Data1.Add(new Datajson("전쟁영화", 1980, "전생의 침상을 겸헝하다", "국방홍보원(당시 국방홍보관리소)", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "www", "/images/ex02.png"));



        string json = JsonUtility.ToJson(saveData, true);
        string saveFilePath = SavePath + "/datalist2.json";

        File.WriteAllText(saveFilePath, json);
    }

    public void JsonLoad()
    {
        string JsonLoadData = SavePath + "/datalist2.json";
        string data = File.ReadAllText(JsonLoadData);
        saveData = JsonUtility.FromJson<SaveData>(data);


        var SelectData = saveData.Data0;

        if (select_type == 0)
        {
            SelectData = saveData.Data0;
        }
        else if (select_type == 1)
        {
            SelectData = saveData.Data1;
        }
        dictYear = new Dictionary<string, int>();
        int yearcount;
        //목록 생성
        for (int i = 0; i < SelectData.Count; i++)
        {
            year_group.Add(SelectData[i].group_year + "년대");
            year_group_total.Add(SelectData[i].group_year);
            place_group.Add(SelectData[i].place);

            if (dictYear.ContainsKey(SelectData[i].group_year + "년대"))
            {
                yearcount = dictYear[SelectData[i].group_year + "년대"];
                Debug.Log(yearcount);
                dictYear[SelectData[i].group_year + "년대"] = yearcount + 1;
            }
            else
            {
                dictYear.Add(SelectData[i].group_year + "년대", 1);
                Debug.Log(dictYear[SelectData[i].group_year + "년대"]);
            }

        }

        year_group = year_group.Distinct().ToList();
        place_group = place_group.Distinct().ToList();


        year_group = year_group.OrderBy(n => n).ToList();
        place_group = place_group.OrderBy(n => n).ToList();

        subMainList.Add(year_group);
        subMainList.Add(place_group);


        select_main = year_group[0];

        Debug.Log("select_main -- " + select_main);
        Debug.Log("select_main -- " + SelectData[0].group_year);
        Debug.Log("select_main -- " + SelectData[0].group_year + "년대");
        Debug.Log("select_main -- " + select_main == SelectData[0].group_year + "년대");



        //초반 데이터 셋팅
        for (int i = 0; i < SelectData.Count; i++)
        {
            if (select_main == SelectData[i].group_year + "년대")
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
            Debug.Log("sorted -- " + i);
        }

    }









    public void selectData(int type, int grouptype, string year_group)
    {
        Debug.Log("selectData");


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

        Debug.Log(year_group);
        Debug.Log(select_main);

        //초반 데이터 셋팅
        for (int i = 0; i < SelectData.Count; i++)
        {
            if (grouptype == 0)
            { //연도별
                if (SelectData[i].group_year + "년대" == year_group)
                {
                    Debug.Log("i - " + i);
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
            else
            {
                if (SelectData[i].place == year_group)
                {
                    Debug.Log("i - " + i);
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

        }
        var sorted = contentData.OrderBy(ob => ob.title).ToList();
        contentData.Clear();
        foreach (var i in sorted)
        {
            contentData.Add(i);
            Debug.Log("sorted -- " + i);
        }
    }

    public void selectGrid(int index)
    {
        selectGridData = new contentData(
        contentData[index].type,
        contentData[index].group_year,
        contentData[index].title,
        contentData[index].place,
        contentData[index].year,
        contentData[index].keyword,
        contentData[index].playtime,
        contentData[index].summary,
        contentData[index].url,
        contentData[index].thumbnail
        );
    }


    public string CountTimeLine(int num)
    {
        int hours, minute, second;
        string strhour, strmin, strsec;

        hours = num / 3600;//시 공식          
        strhour = hours > 10 ? hours.ToString() : 0 + hours.ToString();

        minute = num % 3600 / 60;//분을 구하기위해서 입력되고 남은값에서 또 60을 나눈다.
        strmin = minute > 10 ? minute.ToString() : 0 + minute.ToString();

        second = num % 3600 % 60;//마지막 남은 시간에서 분을 뺀 나머지 시간을 초로 계산함
        strsec = second > 10 ? second.ToString() : 0 + second.ToString();


        string timeline = strhour + ":" + strmin + ":" + strsec;

        return timeline;
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


    public contentData(string _type, int _group_year, string _title, string _place, string _year, List<string> _keyword, int _playtime, string _summary, string _url, string _thumbnail)
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
