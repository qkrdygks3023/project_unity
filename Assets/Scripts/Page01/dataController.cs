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

    public List<string> url_list = new List<string>();
    public List<string> urls = new List<string>();



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

        saveData.Data0.Add(new Datajson("기록영상", 1950, "흥남 철수, 한국 EVACUATION OF HUNGNAM, KOREA", "미국 NARA", "12/24/1950", new List<string> { "미해군 매시 (구축함). 11/24/1944-9/18/1947", "국방부. 미해군. 리포스 (병원선). 9/18/1947-5/1/1970", "민간인 대피", "폭발", "전쟁 피해", "수륙 양용 장갑차" }, 652, "", "/movies/00/1_흥남 철수, 한국.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949, "한국에 무스탕 MUSTANGA IN KOREA", "미국 NARA", "/", new List<string> { "항공 조종사", "공장", "비행기 격납고", "군용기", "대포", "로켓 (대포)", "무스탕 (전투기)", "정비공 (인물)" }, 517, "", "/movies/00/2_한국에 무스탕.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1950, "심리전: 한국에서의 전투 무기 Psychological Warfare: A Combat Weapon in Korea", "미국 NARA", "ca. 1950", new List<string> { "공중포격", "대포", "군용차", "화재", "선전 투하", "일본", "송신탑", "인쇄 공장" }, 502, "", "/movies/00/3_심리전- 한국에서의 전투 무기.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1950, "지뢰 제거선이 원산에서 운행, 항구, 북한MINESWEEPER IN ACTION IN WONSAN, HARBOR, NORTH KOREA", "미국 NARA", "10/10/1950", new List<string> { "한국", "국방부. 미해군. 목킹버드 (모터 지뢰 제거선). 9/18/1947-1/6/1956", "항구", "지뢰 (군용화약)", "선박", "해안선", "선박 조송술" }, 337, "", "/movies/00/4_제뢰제거함 활동 원산, 한국, 북한 .mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1951, "평화 강화 회담 무산리, 한국 CEASE FIRE TALKS Munsan-ni, Korea", "미국 NARA", "8/1/1951", new List<string> { "유엔", "미해군. 미국 해군 밴드. 1925-9/1947", "C. 터너 조이 (찰스 터너) 1895-1956", "의회와 협약", "헬리콥터", "사찰", "경비병" }, 174, "", "/movies/00/5_평화 회담 무산리, 한국.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1951, "평화 회담 개성, 한국 PEACE TALKS Kaesong, Korea", "미국 NARA", "7/10/1951", new List<string> { "유엔", "C. 터너 조이 (찰스 터너), 1895-1956", "매슈 B. 리즈웨이 (매슈 벙커), 1895-1993", "항공 조종사", "인터뷰", "해군 장교", "육군 장교", "군 헬리콥터" }, 215, "", "/movies/00/6_평화 회담 개성, 한국.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1951, "대한민국 해군사관학교 REPUBLIC OF KOREA NAVAL ACADEMY", "미국 NARA", "3/15/1951", new List<string> { "한국", "깃발", "군사 교육" }, 663, "", "/movies/00/7_대한민국 해군사관학교.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949, "부산에서의 활동, 한국 ACTIVITIES AT PUSAN, KOREA", "미국 NARA", "/", new List<string> { "민간인 대피", "한국인", "포로", "신병 모집과 협조", "선박", "사찰", "지프차", "경비병" }, 595, "", "/movies/00/8_부산에서의 활동, 한국.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949, "유엔 서울 안으로 후퇴, 서울 UN RETREAT INTO SEOUL, KOREA", "미국 NARA", "/", new List<string> { "군용트럭", "나룻배", "수여식", "사진사", "피난민", "배식", "취사", "LP" }, 595, "", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));



        saveData.Data1.Add(new Datajson("전쟁영화", 2000, "육탄 11용사", "국방홍보원", "2004년", new List<string> { "6·25전쟁", "호국인물", "6사단" }, 3049, "6.25 당시 소련제 탱크를 앞세운 북한군의 기습 남침으로 아국의 전 전선이 초토화 직전의 위기에 처할 무렵, 춘천 방어의 마지막 보루였던 홍천 말고개에서 거의 맨손으로 적 탱크를 격파하며 아군의 작전에 유리한 전기를 마련한 육군 제6사단 19연대 소속 육탄 11용사들의 백절불굴의 투혼과 감투정신을 보여주는 내용으로 이루어져 있다.", "/movies/01/1. 육탄 11용사.mp4", "/images/01/1. 육탄 11용사.jpg"));
        saveData.Data1.Add(new Datajson("전쟁영화", 1950, "정의의 진격 1부", "한국영상자료원", "1951년", new List<string> { "6·25전쟁" }, 4846, "1950년대 초, 대한민국국방부정훈국에서 제작한 한국전쟁 관련 기록영화이다. 동란 중 촬영된 영상을 음성해설과 함께 재구성해 한국전쟁의 전개 과정을 연대기 순으로 보여준다.", "/movies/01/2. 정의의 진격 1부.mp4", "/images/01/ing.png"));
        saveData.Data1.Add(new Datajson("전쟁영화", 1950, "태양의 거리(무성영화)", "한국영상자료원", "1952년", new List<string> { "6·25전쟁", "대구", "피난", "피난민", "우정", "불량소년" }, 3851, "국민학교 교사 문대식(박암)이 피란지 대구로 부임해 온다. 피난 생활상과 불량 소년들의 모습 그리고 우정과 변화를 보여준다.", "/movies/01/3. 태양의 거리(무성영화).mp4", "/images/01/ing.png"));
        saveData.Data1.Add(new Datajson("전쟁영화", 1950, "운명의 손", "한국영상자료원", "1954년", new List<string> { "6·25전쟁" }, 5390, "북한의 스파이로 활동하는 마가렛(윤인자)은 우연히 도둑으로 몰린 고학생 신영철(이향)을 구해주며 사랑에 빠진다. 자신의 마음을 고백한 마가렛은 영철과 즐거운 시간을 보내지만, 그 과정에서 간첩으로서의 정체성과 영철과의 사랑 사이에서 번민한다.", "/movies/01/4. 운명의 손.mp4", "/images/01/ing.png"));
        saveData.Data1.Add(new Datajson("전쟁영화", 1950, "미망인", "한국영상자료원", "1955년", new List<string> { "6·25전쟁", "6·25전쟁직후", "미망인", "전쟁미망인", "여성감독" }, 3731, "딸 주(이성주)를 데리고 피난생활을 하는 이신자(이민자)는 6·25 때 죽은 남편의 친구였던 이성진 사장(신동훈)의 도움으로 생계를 유지한다. 그러나 친구의 아내를 도와주어야 한다는 이 사장의 도의심은 신자에 대한 애정으로 변한다. 이를 눈치 챈 이 사장의 처(박영숙)는 남편을 추궁한다.", "/movies/01/5. 미망인.mp4", "/images/01/ing.png"));
        saveData.Data1.Add(new Datajson("전쟁영화", 1950, "피아골", "한국영상자료원", "1956년", new List<string> { "6·25전쟁" }, 6505, "휴전 후 지리산에 남아 있는 소수의 빨치산 중 아가리(이예춘)가 대장을 맡고 있는 부대는 온갖 만행을 저지른다. 공산주의 이념에 회의를 느끼기 시작한 철수(김진규)는 당성이 높고 냉철한 여자 대원 애란(노경희)의 연모를 받으며 고민한다. ", "/movies/01/6. 피아골.mp4", "/images/01/ing.png"));
        saveData.Data1.Add(new Datajson("전쟁영화", 1950, "격퇴(우리는 이렇게 싸웠다)", "한국영상자료원", "1956년", new List<string> { "6·25전쟁", "김만술", "실화바탕", "이강천" }, 5055, "김만술 대위의 6.25 참전 실화를 영화화한 작품. 한국군은 베티고지 사수가 어려움에도 불구하고 김만술 소대장과 선임하사 김무철 상사(최봉)을 포함한 소대원들은 고지를 지키기 위해 전력을 다한다.", "/movies/01/7. 격퇴(우리는 이렇게 싸웠다).mp4", "/images/01/ing.png"));
        saveData.Data1.Add(new Datajson("전쟁영화", 1950, "지옥화", "한국영상자료원", "1958년", new List<string> { "6·25전쟁", "신상옥" }, 5180, "영식(김학) 일당은 기지촌에서 살면서 미군부대의 창고를 털어 시장에 내다 파는 일을 한다. 동생 동식(조해원)은 형 영식을 설득해 고향으로 데려가기 위해 서울에 왔다가 시장 통에서 형을 발견하고 그를 따라 기지촌으로 들어간다. ", "/movies/01/8. 지옥화.mp4", "/images/01/ing.png"));
        saveData.Data1.Add(new Datajson("전쟁영화", 1950, "동심초", "한국영상자료원", "1958년", new List<string> { "6·25전쟁", "신상옥" }, 7579, "6ㆍ25때 남편을 여읜지 8년. 이숙희(최은희)는 양장점을 하다가 빚을 지고, 출판사 전무 김상규(김진규)가 빚청산을 도와주면서 둘은 사랑에 빠진다.", "/movies/01/9. 동심초.mp4", "/images/01/ing.png"));



        saveData.Data2.Add(new Datajson("다큐멘터리", 2000, "휴전선을 말한다 - 제1부 155마일의 진실", "국방홍보원", "2002년", new List<string> { "한국전쟁", "휴전선", "국군", "DMZ", "6.25전쟁", "국방홍보원" }, 3235, "2002년 국방홍보원에서 제작한 다큐멘터리 영상으로 남북 휴전선의 탄생과 변천과정, 휴전선을 바라보는 세계인의 평가에 관한 내용을 담고 있다.", "/movies/02/1.휴전선을 말한다 제1부 155마일의 진실-006.mp4", "/images/02/1. 휴전선을 말한다 - 제1부 155마일의 진실.jpg"));
        saveData.Data2.Add(new Datajson("다큐멘터리", 2000, "휴전선을 말한다 - 제2부 휴전선의 두얼굴", "국방홍보원", "2002년", new List<string> { "한국전쟁", "휴전선", "국군", "DMZ", "6.25전쟁", "국방홍보원" }, 3288, "2002년 국방홍보원에서 제작한 다큐멘터리 영상으로 2000년 6월 남북화해를 기대했으나, 서해의 NLL선에서 남과 북의 젊은이들이 교전을 벌여 수십명의 사상자가 발생하였고 이를 통해 우리 비무장지대가 안고있는 딜레마를 보여주는 내용을 담고 있다.", "/movies/02/2.휴전선을 말한다 제2부 휴전선의 두얼굴.mp4", "/images/02/2. 휴전선을 말한다 - 제2부 휴전선의 두얼굴.jpg"));
        saveData.Data2.Add(new Datajson("다큐멘터리", 2000, "휴전선을 말한다 - 제3부 돌아가야할 땅", "국방홍보원", "2002년", new List<string> { "한국전쟁", "휴전선", "국군", "DMZ", "6.25전쟁", "국방홍보원", "경의선", "남북교류" }, 3262, "2002년 국방홍보원에서 제작한 다큐멘터리 영상으로 비무장지대 내 유적지와 이산가족, 경의선 공사현장에 관한 내용을 담고 있다.", "/movies/02/3.휴전선을 말한다 제3부 돌아가야할 땅.mp4", "/images/02/3. 휴전선을 말한다 - 제3부 돌아가야할 땅.jpg"));
        saveData.Data2.Add(new Datajson("다큐멘터리", 1950, "6·25동란", "한국정책방송원", "미상", new List<string> { "한국전쟁", "6.25전쟁", "국립영화제작소" }, 6780, "", "/movies/02/4.6.25동란.mp4", "/images/02/4. 6.25동란.jpg"));
        saveData.Data2.Add(new Datajson("다큐멘터리", 1980, "민족의 증언", "한국정책방송원", "1987년", new List<string> { "한국전쟁", "6.25전쟁", "국립영화제작소" }, 1357, "", "/movies/02/4.민족의증언.mp4", "/images/02/ing.png"));
        saveData.Data2.Add(new Datajson("다큐멘터리", 1970, "아! 6.25 (농촌판)", "한국정책방송원", "1972년", new List<string> { "한국전쟁", "6.25전쟁", "국립영화제작소" }, 1035, "", "/movies/02/1. 아! 6.25 (농촌판).mp4", "/images/02/ing.png"));
        saveData.Data2.Add(new Datajson("다큐멘터리", 1970, "잊지말자 6.25", "한국정책방송원", "1976년", new List<string> { "한국전쟁", "6.25전쟁", "국립영화제작소" }, 881, "", "/movies/02/6.잊지말자  6.25.mp4", "/images/02/ing.png"));
        saveData.Data2.Add(new Datajson("다큐멘터리", 1950, "상기하자 6.25", "한국정책방송원", "1957년", new List<string> { "한국전쟁", "6.25전쟁", "국립영화제작소" }, 2207, "", "/movies/02/3. 상기하자  6.25.mp4", "/images/02/ing.png"));
        saveData.Data2.Add(new Datajson("다큐멘터리", 1990, "시련과 영광", "한국정책방송원", "1995년", new List<string> { "한국전쟁", "6.25전쟁", "국립영상제작소", "광복50주년" }, 3171, "1995년 광복 50주년을 기념하여 국립영상제작소에서 제작한 기록영상이다. 해방 이후 분단의 아픔을 딛고 일어서 한강의 기적을 이루고, 군사독재의 시련을 견디고 문민정부를 수립하기까지의 아팠지만 대견한 50년의 역사의 순간들을 담은 영상물이다.", "/movies/02/2. 시련과 영광.mp4", "/images/02/9. 시련과 영광.jpg"));




        saveData.Data3.Add(new Datajson("구술영상", 2020, "박경석 육군 준장 구술", "1. 국군/경찰", "2020년", new List<string> { "구술영상", "인터뷰", "구술채록", "구술사", "참전자", "참전용사", "6·25전쟁", "한국전쟁", "육군사관학교", "육사", "시비" }, 654, "2020년 구술영상 아카이브 구축 사업 관련 본 촬영 최종본 영상이다. 박경석 예비역 육군 준장은 1950년 육군사관학교 생도 2기로 입학하였다. 입학 25일만에 6·25전쟁에 투입되어 포천전투에 참전하였고 부산까지 후퇴하여 17세에 최연소 육군 소위로 임관하였다. 현재 전쟁기념관에 있는 시비 <조국>과 <서시>의 작가이기도 하다. 6·25전쟁 투입 첫 날의 기억, 북방 1077고지 전투에서 인민군 포로가 됐던 경험과 전쟁기념관 설립과 관련된 일화 등을 구술하였다.", "/movies/03/1.박경석(2020).mp4", "/images/03/ing.png"));
        saveData.Data3.Add(new Datajson("구술영상", 2020, "최영섭 해군 대령 구술", "1. 국군/경찰", "2020", new List<string> { "구술영상", "인터뷰", "구술채록", "구술사", "참전자", "참전용사", "6·25전쟁", "한국전쟁", "백두산함", "대한해협해전", "장사상륙작전" }, 652, "2020년 구술영상 아카이브 구축 사업 관련 본 촬영 최종본 영상이다. 최영섭 예비역 해군 대령은 1947년 9월 해군사관학교 3기생으로 입교하였다. 임관 4개월 만인 1950년 6월 25일 우리나라 최초의 전투함 백두산함의 갑판사관으로 대한해협해전에 참전하였다. 전역 후에는 <6·25 바다의 전우들>을 집필하기도 하고 추모비 건립 운동 등 여러 활동을 하고 있다. 해군사관학교 입교, 대한해협해전의 시작과 과정, 그리고 전쟁의 아픔과 희생을 기억하는 것의 중요성 등을 구술하였다.", "/movies/03/2.최영섭(2020).mp4", "/images/03/ing.png"));
        saveData.Data3.Add(new Datajson("구술영상", 2020, "이배선 공군 대령 구술", "1. 국군/경찰", "2020년", new List<string> { "구술영상", "인터뷰", "구술채록", "구술사", "참전자", "참전용사", "6·25전쟁", "한국전쟁", "공군사관학교", "공사", "조종사", "출격일지", "강릉기지" }, 760, "2020년 구술영상 아카이브 구축 사업 관련 본 촬영 최종본 영상이다. 이배선 예비역 공군 대령은 1949년 공군사관학교 1기생으로 입교하여 대한민국 공군사관학교가 배출한 최초의 조종사이다. 6·25전쟁 중 총 92회 출격을 하였고 6·25전쟁 항공작전의 출격기록들을 <출격일지>로 남겨두었다. 공군사관학교 입교, 6·25전쟁 중 강릉기지에서의 첫 출격, 그리고 임택순 전우 등 희생된 동료에 대한 기억 등을 구술하였다.", "/movies/03/3.이배선(2020).mp4", "/images/03/ing.png"));
        saveData.Data3.Add(new Datajson("구술영상", 2021, "류영봉 카투사 1기 구술", "4. 기타", "2021년", new List<string> { "구술영상", "인터뷰", "구술채록", "구술사", "참전자", "참전용사", "6·25전쟁", "한국전쟁", "장진호", "전투", "흥남철수", "미8군", "인천상륙작전" }, 531, "전쟁의 참상을 표현한다 다큐멘터리", "/movies/03/4.류영봉(2021).mp4", "/images/03/ing.png"));
        saveData.Data3.Add(new Datajson("구술영상", 2021, "박옥선 간호장교 2기 구술", "4. 기타", "2021년", new List<string> { "구술영상", "인터뷰", "구술채록", "구술사", "참전자", "참전용사", "6·25전쟁", "한국전쟁", "육군", "군의학교" }, 503, "전쟁의 참상을 표현한다 다큐멘터리", "/movies/03/5.박옥순(2021).mp4", "/images/03/ing.png"));
        saveData.Data3.Add(new Datajson("구술영상", 2021, "정기숙 여자학도병 구술", "4. 기타", "2021년", new List<string> { "구술영상", "인터뷰", "구술채록", "구술사", "참전자", "참전용사", "6·25전쟁", "한국전쟁", "학도병" }, 534, "전쟁의 참상을 표현한다 다큐멘터리", "/movies/03/6.정기숙(2021).mp4", "/images/03/ing.png"));
        saveData.Data3.Add(new Datajson("구술영상", 2021, "최선분 여자의용군 구술", "4. 기타", "2021년", new List<string> { "구술영상", "인터뷰", "구술채록", "구술사", "참전자", "참전용사", "6·25전쟁", "한국전쟁", "육군", "부관학교", "주월한국군사령부", "베트남전쟁" }, 653, "전쟁의 참상을 표현한다 다큐멘터리", "/movies/03/7.최선분(2021).mp4", "/images/03/ing.png"));
        saveData.Data3.Add(new Datajson("구술영상", 2022, "김화순 노무자 구술", "4. 기타", "2022년", new List<string> { "구술영상", "인터뷰", "구술채록", "구술사", "참전자", "참전용사", "6·25전쟁", "한국전쟁", "육군", "화살머리고지전투", "미 7사단", "노무자", "한국노무단", "KP", "KSC", "CTC" }, 657, "전쟁의 참상을 표현한다 다큐멘터리", "/movies/03/8.김화순(2022).mp4", "/images/03/ing.png"));
        saveData.Data3.Add(new Datajson("구술영상", 2022, "안태진 육군 포병", "1. 국군/경찰", "2022년", new List<string> { "구술영상", "인터뷰", "구술채록", "구술사", "참전자", "참전용사", "6·25전쟁", "한국전쟁", "육군", "수도기계화보병사단", "수도사단", "금성전투", "713전투", "351고지전투", "육근수" }, 521, "전쟁의 참상을 표현한다 다큐멘터리", "/movies/03/9.안태진(2022).mp4", "/images/03/ing.png"));
        saveData.Data3.Add(new Datajson("구술영상", 0, "준비중", "2. 유 엔 군", "0년", new List<string> { }, 0, "준비중", "", "/images/03/ing.png"));
        saveData.Data3.Add(new Datajson("구술영상", 0, "준비중", "3. 관 련 국", "0년", new List<string> { }, 0, "준비중", "", "/images/03/ing.png"));



        saveData.urljson.Add(new urljson("국방홍보원", "www.naver.com"));
        saveData.urljson.Add(new urljson("라이브러리2", "www.google.com"));
        saveData.urljson.Add(new urljson("라이브러리3", "www.daum.net"));

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
        var urljson = saveData.urljson;

        if (select_type == 0)
        {
            SelectData = saveData.Data0;
            Debug.Log("기록영상");
        }
        else if (select_type == 1)
        {
            SelectData = saveData.Data1;
            urljson = saveData.urljson;
            Debug.Log("전쟁영화");
        }
        else if (select_type == 2)
        {
            SelectData = saveData.Data2;
            Debug.Log("다큐멘터리");
        }
        else if (select_type == 3)
        {
            SelectData = saveData.Data3;
            Debug.Log("구술영상");
        }

        dictYear = new Dictionary<string, int>();
        int yearcount;
        //목록 생성
        for (int i = 0; i < SelectData.Count; i++)
        {

            year_group.Add(SelectData[i].group_year.ToString());
            year_group_total.Add(SelectData[i].group_year);
            place_group.Add(SelectData[i].place);

            if (dictYear.ContainsKey(SelectData[i].group_year.ToString()))
            {
                yearcount = dictYear[SelectData[i].group_year.ToString()];
                dictYear[SelectData[i].group_year.ToString()] = yearcount + 1;
            }
            else
            {
                dictYear.Add(SelectData[i].group_year.ToString(), 1);
            }

        }

        if (select_type == 1)
        {
            Debug.Log("urljson.Count : " + urljson.Count);
            url_list.Clear();
            for (int i = 0; i < urljson.Count; i++)
            {
                url_list.Add(urljson[i].title);
                urls.Add(urljson[i].url);

                Debug.Log("urljson[i].title : " + urljson[i].title);
            }

            // url_list = url_list.Distinct().ToList();
            // url_list = url_list.OrderBy(n => n).ToList();
        }

        year_group = year_group.Distinct().ToList();
        place_group = place_group.Distinct().ToList();


        year_group = year_group.OrderBy(n => n).ToList();
        place_group = place_group.OrderBy(n => n).ToList();

        if (select_type == 1)
        {
            subMainList.Add(year_group);
            subMainList.Add(url_list);
        }

        else
        {
            //버튼 
            subMainList.Add(year_group);
            subMainList.Add(place_group);
        }




        // select_main = SelectData[0].group_year + "년대";

        select_main = year_group[0];




        //초반 데이터 셋팅
        if (select_type != 3)
        {
            select_main = year_group[0];
            for (int i = 0; i < SelectData.Count; i++)
            {
                if (select_main == SelectData[i].group_year.ToString())
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
        }
        else
        {
            select_main = place_group[0];
            for (int i = 0; i < SelectData.Count; i++)
            {
                if (select_main == SelectData[i].place)
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
        }


        List<contentData> sorted = contentData.OrderBy(ob => ob.title).ToList();

        //초반 년도 타이틀 

        if (select_type == 3)
        {
            //군국
            selectController.yeartitleObj.GetComponentInChildren<TextMeshProUGUI>().text = select_main;
        }
        else
        {

            //연도별 타이틀
            selectController.year_subtitleObj.GetComponentInChildren<TextMeshProUGUI>().text = select_main;
            //1950년대
            selectController.yeartitleObj.GetComponentInChildren<TextMeshProUGUI>().text = "연도별";

        }

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
        //type : 0 : 전쟁영화, 1 : 전쟁다큐멘터리, 2 : 전쟁드라마, 3 : 전쟁애니메이션
        //grouptype 0 : year, 1 : place
        //year_group : 선택된 년도


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
        Debug.Log(SelectData[0].group_year.ToString() == year_group);

        Debug.Log("SelectData.Count - " + SelectData.Count);


        //초반 데이터 셋팅
        for (int i = 0; i < SelectData.Count; i++)
        {
            if (grouptype == 0)
            { //연도별
                if (SelectData[i].group_year.ToString() == year_group)
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

    public List<urljson> urljson = new List<urljson>();



    public int gold;
    public int power;
    public string title;

    public string url;


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

[System.Serializable]
public class urljson
{
    public string title;

    public string url;



    public urljson(string _title, string _url)
    {
        title = _title;
        url = _url;
    }
}