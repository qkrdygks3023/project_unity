using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;
using System;
using TMPro;

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


    selectController selectController;

    void Awake()
    {
        selectController = FindObjectOfType<selectController>();

        // JsonSave();
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

        saveData.Data0.Add(new Datajson("기록영상", 1950, "0전생의 침상을 겸헝하다", "국방홍보원", "2010년", new List<string> { "a", "b", "c" }, 6000, "전쟁의 참상을 표현한다 다큐멘터리", "/movies/video01.mov", "/images/ex01.jpeg"));
        saveData.Data0.Add(new Datajson("기록영상", 1950, "2950년대 전생의 겸헝하다", "국방홍보원", "2020년", new List<string> { "a", "b", "c" }, 3600, "전쟁의 참상을 표현한다 다큐멘터리", "/movise/video.mp4", "/images/ex01.jpeg"));
        saveData.Data0.Add(new Datajson("기록영상", 1950, "950년대  겸헝하다", "국방홍보원", "1990년", new List<string> { "a", "b", "c" }, 60000, "전쟁의 참상을 표현한다 다큐멘터리", "/movise/video.mp4", "/images/ex02.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1950, "150 겸헝하다", "국방홍보원", "1990년", new List<string> { "a", "b", "c" }, 60000, "전쟁의 참상을 표현한다 다큐멘터리", "/movies/video.mp4", "/images/ex04.jpeg"));
        saveData.Data0.Add(new Datajson("기록영상", 1950, "195년대 전생의 침상을 겸헝하다", "국방홍보원", "2000년", new List<string> { "a", "b", "c" }, 6000, "전쟁의 참상을 표현한다 다큐멘터리", "/movies/video.mp4", "/images/ex05.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1950, "1950년대 전생의 침상을 겸헝하다", "국방홍보원", "2000년", new List<string> { "a", "b", "c" }, 8000, "전쟁의 참상을 표현한다 다큐멘터리", "/movies/video.mp4", "/images/ex06.jpeg"));
        saveData.Data0.Add(new Datajson("기록영상", 1950, "19", "국방홍보원", "2000년", new List<string> { "a", "b", "c" }, 50000, "전쟁의 참상을 표현한다 다큐멘터리", "/movies/video.mp4", "/images/ex07.jpeg"));
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
        saveData.Data1.Add(new Datajson("전쟁영화", 3000, "전생의 침상을 겸헝하다", "국방홍보원(당시 국방홍보관리소)", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "www", "/images/ex02.png"));

        saveData.Data2.Add(new Datajson("전쟁영화", 1980, "전생의 침상을 겸헝하다", "국방홍보원(당시 국방홍보관리소)", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "www", "/images/ex02.png"));
        saveData.Data2.Add(new Datajson("전쟁영화", 1980, "전생의 침상을 겸헝하다", "국방홍보원(당시 국방홍보관리소)", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "www", "/images/ex02.png"));
        saveData.Data2.Add(new Datajson("전쟁영화", 1980, "전생의 침상을 겸헝하다", "국방홍보원(당시 국방홍보관리소)", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "www", "/images/ex02.png"));
        saveData.Data2.Add(new Datajson("전쟁영화", 1980, "전생의 침상을 겸헝하다", "국방홍보원(당시 국방홍보관리소)", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "www", "/images/ex02.png"));
        saveData.Data2.Add(new Datajson("전쟁영화", 1980, "전생의 침상을 겸헝하다", "국방홍보원(당시 국방홍보관리소)", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "www", "/images/ex02.png"));
        saveData.Data2.Add(new Datajson("전쟁영화", 1980, "전생의 침상을 겸헝하다", "국방홍보원(당시 국방홍보관리소)", "2000년", new List<string> { "a", "b", "c" }, 2000, "전쟁의 참상을 표현한다 다큐멘터리", "www", "/images/ex02.png"));


        saveData.Data3.Add(new Datajson("전쟁영화", 2020, "박경석 육군 준장 구술", "기타", "2020년", new List<string> { "구술영상", "인터뷰", "구술채록", "구술사", "참전자", "참전용사", "6·25전쟁", "한국전쟁", "육군사관학교", "육사", "시비"}, 654, "2020년 구술영상 아카이브 구축 사업 관련 본 촬영 최종본 영상이다. 박경석 예비역 육군 준장은 1950년 육군사관학교 생도 2기로 입학하였다. 입학 25일만에 6·25전쟁에 투입되어 포천전투에 참전하였고 부산까지 후퇴하여 17세에 최연소 육군 소위로 임관하였다. 현재 전쟁기념관에 있는 시비 <조국>과 <서시>의 작가이기도 하다. 6·25전쟁 투입 첫 날의 기억, 북방 1077고지 전투에서 인민군 포로가 됐던 경험과 전쟁기념관 설립과 관련된 일화 등을 구술하였다.", "/movies/1.박경석(2020).mov", "/images/ex02.png"));
        saveData.Data3.Add(new Datajson("전쟁영화", 2020, "최영섭 해군 대령 구술", "기타", "2020", new List<string> { "구술영상", "인터뷰", "구술채록", "구술사", "참전자", "참전용사", "6·25전쟁", "한국전쟁", "백두산함", "대한해협해전", "장사상륙작전"}, 652, "2020년 구술영상 아카이브 구축 사업 관련 본 촬영 최종본 영상이다. 최영섭 예비역 해군 대령은 1947년 9월 해군사관학교 3기생으로 입교하였다. 임관 4개월 만인 1950년 6월 25일 우리나라 최초의 전투함 백두산함의 갑판사관으로 대한해협해전에 참전하였다. 전역 후에는 <6·25 바다의 전우들>을 집필하기도 하고 추모비 건립 운동 등 여러 활동을 하고 있다. 해군사관학교 입교, 대한해협해전의 시작과 과정, 그리고 전쟁의 아픔과 희생을 기억하는 것의 중요성 등을 구술하였다.", "/movies/2.최영섭(2020).mov", "/images/ex02.png"));
        saveData.Data3.Add(new Datajson("전쟁영화", 2020, "이배선 공군 대령 구술", "기타", "2020년", new List<string> { "구술영상", "인터뷰", "구술채록", "구술사", "참전자", "참전용사", "6·25전쟁", "한국전쟁", "공군사관학교", "공사", "조종사", "출격일지", "강릉기지"}, 760, "2020년 구술영상 아카이브 구축 사업 관련 본 촬영 최종본 영상이다. 이배선 예비역 공군 대령은 1949년 공군사관학교 1기생으로 입교하여 대한민국 공군사관학교가 배출한 최초의 조종사이다. 6·25전쟁 중 총 92회 출격을 하였고 6·25전쟁 항공작전의 출격기록들을 <출격일지>로 남겨두었다. 공군사관학교 입교, 6·25전쟁 중 강릉기지에서의 첫 출격, 그리고 임택순 전우 등 희생된 동료에 대한 기억 등을 구술하였다.", "/movies/3.이배선(2020).mov", "/images/ex02.png"));
        saveData.Data3.Add(new Datajson("전쟁영화", 2021, "류영봉 카투사 1기 구술", "기타", "2021년", new List<string> { "구술영상", "인터뷰", "구술채록", "구술사", "참전자", "참전용사", "6·25전쟁", "한국전쟁", "장진호", "전투", "흥남철수", "미8군", "인천상륙작전" }, 531, "전쟁의 참상을 표현한다 다큐멘터리", "/movies/4.류영봉(2021).mov"  , "/images/ex02.png"));
        saveData.Data3.Add(new Datajson("전쟁영화", 2021, "박옥선 간호장교 2기 구술", "기타", "2021년", new List<string> { "구술영상", "인터뷰", "구술채록", "구술사", "참전자", "참전용사", "6·25전쟁", "한국전쟁", "육군", "군의학교" }, 503, "전쟁의 참상을 표현한다 다큐멘터리", "/movies/5.박옥순(2021).mov" , "/images/ex02.png"));
        saveData.Data3.Add(new Datajson("전쟁영화", 2021, "정기숙 여자학도병 구술", "기타", "2021년", new List<string> { "구술영상", "인터뷰", "구술채록", "구술사", "참전자", "참전용사", "6·25전쟁", "한국전쟁", "학도병"}, 534, "전쟁의 참상을 표현한다 다큐멘터리", "/movies/6.정기숙(2021).mov" , "/images/ex02.png"));
        saveData.Data3.Add(new Datajson("전쟁영화", 2021, "최선분 여자의용군 구술", "기타", "2021년", new List<string> {"구술영상", "인터뷰", "구술채록", "구술사", "참전자", "참전용사", "6·25전쟁", "한국전쟁", "육군", "부관학교", "주월한국군사령부", "베트남전쟁"}, 653, "전쟁의 참상을 표현한다 다큐멘터리", "/movies/7.최선분(2021).mov" , "/images/ex02.png"));
        saveData.Data3.Add(new Datajson("전쟁영화", 2022, "김화순 노무자 구술", "기타", "2022년", new List<string> { "구술영상", "인터뷰", "구술채록", "구술사", "참전자", "참전용사", "6·25전쟁", "한국전쟁", "육군", "화살머리고지전투", "미 7사단", "노무자", "한국노무단", "KP", "KSC", "CTC" }, 657, "전쟁의 참상을 표현한다 다큐멘터리", "8.김화순(2022)-006.mov" , "/images/ex02.png"));
        saveData.Data3.Add(new Datajson("전쟁영화", 2022, "안태진 육군 포병", "기타", "2022년", new List<string> { "구술영상", "인터뷰", "구술채록", "구술사", "참전자", "참전용사", "6·25전쟁", "한국전쟁", "육군", "수도기계화보병사단", "수도사단", "금성전투", "713전투", "351고지전투", "육근수" }, 521, "전쟁의 참상을 표현한다 다큐멘터리", "/movies/9.안태진(2022)-002.mov" , "/images/ex02.png"));



        string json = JsonUtility.ToJson(saveData, true);
        string saveFilePath = SavePath + "/datalist2.json";

        File.WriteAllText(saveFilePath, json);
    }

    public void JsonLoad()
    {
        string JsonLoadData = SavePath + "/datalist2.json";
        string data = File.ReadAllText(JsonLoadData);
        saveData = JsonUtility.FromJson<SaveData>(data);
        subMainList.Clear();
        year_group.Clear();
        year_group_total.Clear();
        place_group.Clear();


        var SelectData = saveData.Data0;

        if (select_type == 0)
        {
            SelectData = saveData.Data0;
        }
        else if (select_type == 1)
        {
            SelectData = saveData.Data1;
            Debug.Log("데이터1");
        }
        else if (select_type == 2)
        {
            SelectData = saveData.Data2;
            Debug.Log("데이터2");
        }
        else if (select_type == 3)
        {
            SelectData = saveData.Data3;
            Debug.Log("데이터3");
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

        //버튼 
        subMainList.Add(year_group);
        subMainList.Add(place_group);


        select_main = SelectData[0].group_year + "년대";

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

        List<contentData> sorted = contentData.OrderBy(ob => ob.title).ToList();

        selectController.year_subtitleObj.GetComponentInChildren<TextMeshProUGUI>().text = select_main;

        contentData.Clear();
        foreach (var i in sorted)
        {
            contentData.Add(i);

        }
    }





    //grid Data
    public void selectData(int type, int grouptype, string year_group)
    {
        Debug.Log("selectData");
        //grouptype 0 : year, 1 : place
        //year_group : 선택된 년도
        //type : 0 : 전쟁영화, 1 : 전쟁다큐멘터리

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
        if (type == 3)
        {
            SelectData = saveData.Data3;
        }

        Debug.Log(year_group);
        Debug.Log(select_main);
        Debug.Log(SelectData[0].group_year);
        Debug.Log(SelectData[0].group_year + "년대" == year_group);

        Debug.Log("SelectData.Count - " + SelectData.Count);


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

        Debug.Log("contentData.Count - " + contentData.Count);

        var sorted = contentData.OrderBy(ob => ob.title).ToList();
        contentData.Clear();
        foreach (var i in sorted)
        {
            contentData.Add(i);
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
        strhour = hours >= 10 ? hours.ToString() : 0 + hours.ToString();

        minute = num % 3600 / 60;//분을 구하기위해서 입력되고 남은값에서 또 60을 나눈다.
        strmin = minute >= 10 ? minute.ToString() : 0 + minute.ToString();

        second = num % 3600 % 60;//마지막 남은 시간에서 분을 뺀 나머지 시간을 초로 계산함
        strsec = second >= 10 ? second.ToString() : 0 + second.ToString();


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
    public List<Datajson> Data3 = new List<Datajson>();


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
