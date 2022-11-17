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

        JsonSave();
        JsonLoad();

        // writeJson();
    }
    void Start()
    {
        // DontDestroyOnLoad(this.gameObject);
     
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
        // saveData.Data0.Add(new Datajson("기록영상", 1949,  "이름",  "소장처별", "년도", new List<string> {"키워드"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));


        saveData.Data0.Add(new Datajson("기록영상", 1950, "흥남 철수, 한국 EVACUATION OF HUNGNAM, KOREA", "미국 NARA", "12/24/1950", new List<string> { "미해군 매시 (구축함). 11/24/1944-9/18/1947", "국방부. 미해군. 리포스 (병원선). 9/18/1947-5/1/1970", "민간인 대피", "폭발", "전쟁 피해", "수륙 양용 장갑차" }, 652, "", "/movies/00/1_흥남 철수, 한국.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949, "한국에 무스탕 MUSTANGA IN KOREA", "미국 NARA", "/", new List<string> { "항공 조종사", "공장", "비행기 격납고", "군용기", "대포", "로켓 (대포)", "무스탕 (전투기)", "정비공 (인물)" }, 517, "", "/movies/00/2_한국에 무스탕.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1950, "심리전: 한국에서의 전투 무기 Psychological Warfare: A Combat Weapon in Korea", "미국 NARA", "ca. 1950", new List<string> { "공중포격", "대포", "군용차", "화재", "선전 투하", "일본", "송신탑", "인쇄 공장" }, 502, "", "/movies/00/3_심리전- 한국에서의 전투 무기.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1950, "지뢰 제거선이 원산에서 운행, 항구, 북한MINESWEEPER IN ACTION IN WONSAN, HARBOR, NORTH KOREA", "미국 NARA", "10/10/1950", new List<string> { "한국", "국방부. 미해군. 목킹버드 (모터 지뢰 제거선). 9/18/1947-1/6/1956", "항구", "지뢰 (군용화약)", "선박", "해안선", "선박 조송술" }, 337, "", "/movies/00/4_제뢰제거함 활동 원산, 한국, 북한 .mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1951, "평화 강화 회담 무산리, 한국 CEASE FIRE TALKS Munsan-ni, Korea", "미국 NARA", "8/1/1951", new List<string> { "유엔", "미해군. 미국 해군 밴드. 1925-9/1947", "C. 터너 조이 (찰스 터너) 1895-1956", "의회와 협약", "헬리콥터", "사찰", "경비병" }, 174, "", "/movies/00/5_평화 회담 무산리, 한국.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1951, "평화 회담 개성, 한국 PEACE TALKS Kaesong, Korea", "미국 NARA", "7/10/1951", new List<string> { "유엔", "C. 터너 조이 (찰스 터너), 1895-1956", "매슈 B. 리즈웨이 (매슈 벙커), 1895-1993", "항공 조종사", "인터뷰", "해군 장교", "육군 장교", "군 헬리콥터" }, 215, "", "/movies/00/6_평화 회담 개성, 한국.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1951, "대한민국 해군사관학교 REPUBLIC OF KOREA NAVAL ACADEMY", "미국 NARA", "3/15/1951", new List<string> { "한국", "깃발", "군사 교육" }, 663, "", "/movies/00/7_대한민국 해군사관학교.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949, "부산에서의 활동, 한국 ACTIVITIES AT PUSAN, KOREA", "미국 NARA", "/", new List<string> { "민간인 대피", "한국인", "포로", "신병 모집과 협조", "선박", "사찰", "지프차", "경비병" }, 595, "", "/movies/00/8_부산에서의 활동, 한국.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949, "유엔 서울 안으로 후퇴, 서울 UN RETREAT INTO SEOUL, KOREA", "미국 NARA", "/", new List<string> { "군용트럭", "나룻배", "수여식", "사진사", "피난민", "배식", "취사", "LP" }, 595, "", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));

        saveData.Data0.Add(new Datajson("기록영상", 1951,  "THIS IS KOREA 부록 SUPPLEMENTS TO THIS IS KOREA",  "소장처별", "년도", new List<string>{ "국방부. 미해군. 미수리 (전함). 5/10/1985-3/31/1992 , 항공 조종사, 비행기, 공중 포격, 군용기, 로켓 (대포), 스카이 레이더 (전투기), 수역"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "전쟁 고아, 한국 WAR ORPHANS, KOREA",  "소장처별", "년도", new List<string>{"어린이 , 춤, 헌병대, 간호사, 고아원, 트럭, 레슬링, 신체 진단"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한국에 유엔군 UN FORCES IN KOREA",  "소장처별", "년도", new List<string>{"버스, 선박, 아코디언, 주사위게임, 쌍안경, 깃발, 군악대, 군용트럭, 연설"} , 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한국에 유엔군 UN FORCES IN KOREA",  "소장처별", "년도", new List<string>{"초가집 , 군용차, 통조림, 송수화기, 군용기, 포탄, 연료주입, 공중 포격, 박격포"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한국에 유엔군 UN FORCES IN KOREA",  "소장처별", "년도", new List<string>{"군용차, 포탄, 바주카, 화염방사기, 총검, 군함, 환영 행사"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한국에 캐나다인, 임진강 CANADIANS IN KOREA, IMJIN RIVER",  "소장처별", "년도", new List<string> {"텐트 , 대포, 포격, 지도, 군용차, 쌍안경, 송수화기"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "Little Switch 작전, 부산, 한국 Operation Little Switch, Pusan, Korea",  "소장처별", "년도", new List<string> {" 부산 (한국) , 유엔, 미국 적십자 2/12/1978-, Little Switch 작전, 1953, 병과 부상에 대한 전시 구조"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "북한에 대한 항공모함 공격 CARRIER STRIKE AGAINST NORTHERN KOREA",  "소장처별", "년도", new List<string> {"미해군. 밸리 포지 (항공모함). 11/3/1946-9/19/1947 , 원자 폭탄, 항공 포격, 로켓 (대포), 선박, 터널"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "제1 해병대 사단이 활동에 들어가다 벙커 언덕 지역, 한국 FIRST MARINE DIVISION IN ACTION Bunker Hill Area, Korea",  "소장처별", "년도", new List<string> { "공중 폭격 , 소형 화기, 요새,  해병대, 트럭, 군 헬리콥터, 저격수"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
       
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "미국해군전함 뉴저지 (BB-62) 적을 폭격하다 원산, 한국 USS NEW JERSEY (BB-62) BOMBARDING ENEMY Wonsan, Korea",  "소장처별", "년도", new List<string> {"한국, 미해군. 뉴저지 (전함). 5/23/1943-9/18/1947, 전함, 항공"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "정예 구축함 사단 161 고국 한국으로부터 이빨 드러내다 CRACK DESTROYER DIVISION 161 HOME FROM KOREA SHOWS ITS TEETH",  "소장처별", "년도", new List<string> {" 군함, 항공뷰, 포격, 행진, 군악대, 선원, 의장대, 의례와 의식"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한국 회복을 위한 미국 정부 수송, 부산, 한국 U.S. GOVERNMENT SHIPMENT FOR KOREAN RECOVERY, PUSAN, KOREA",  "소장처별", "년도", new List<string> {"부산 (한국), 이승만, 1875-1965, 엘리스 O. 브릭스 (엘리스 옴스비), 1899-1976, 어린이, 오락 행사, 선박, 담화,연설"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "저격 산등성이 구역: 금화 지역, 한국 Sniper Ridge Area : Kumwha Sector, Korea",  "소장처별", "년도", new List<string> {"위장, 발사체, 로켓 발사대 (대포), 로켓 (대포), 탱크, 육군 장교, 신호와 신호판, 곡사포"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "전쟁에서의 여성, 무산리, 한국 Women in War, Munsan-Ni, Korea",  "소장처별", "년도", new List<string> {"무산리 (경기도, 한국), 매슈 B. 리즈웨이 (리즈웨이 벙커), 1895- , C. 터너 조이 (찰스 터너), 1895-1956, 마크 W. 클락 (마크 웨인), 1896-1984, 하워드 M. 터너 (하워드 맥메스), 1902-1965, 동성 훈장 (U.S.) "}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "미국해군전함 미수리 (BB-63) 인청과 청진 해안을 떠나다, 한국 미수리, 미국해군전함 USS MISSOURI (BB-63) OFF COAST OF INCHON AND CHONJIN, KOREA MISSOURI, USS",  "소장처별", "년도", new List<string> {" 인천 (한국) , 국방부. 미해군. 로완 (구축함). 9/18/1947-12/18/1975, 아서 D. 스트러블 (아서 듀이), 1894-1983, 비행기, 구축함 (군함), 소형 화기, 항구, 군 기동 부대, 포병"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "상륙강습 원산, 북한 AMPHIBIOUS ASSAULT Wonsa, North Korea",  "소장처별", "년도", new List<string> {"국방부. 미해군. 미수리(전함). 5/10/1985-3/31/1992, 비행기, 전함, 군 통신, 상륙 주정, 상륙 작전, 해병대, 군사 지원, 수륙 양용 장갑차, 군 기동 부대"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한국에 헬리콥터 로켓 HELICOPTERS-ROCKETS IN KOREA",  "소장처별", "년도", new List<string> {"항공 조종사, 탄약, 헬리콥터, 상륙 작전, 로켓 (대포), 군 헬리콥터"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "헬리콥터 운영, 한국 HELICOPTER OPERATIONS. Korea",  "소장처별", "년도", new List<string> {"항공뷰, 항공 조종사, 공항, 탄약, 로켓 발사기 (대포), 트럭, 마이크로폰, 군 헬리콥터"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한강을 건너다 한국 HAN RIVER CROSSING Korea",  "소장처별", "년도", new List<string> {"바지선, 소형 화기, 깃발, 상륙 주정, 상륙 작전, 군사 지원, 탱크 (군사학), 육군 장교, GMC 덕 (군트럭), 감시원"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "제1 사단, 미국 해병대USMC, 로켓 중대 한국 FIRST DIVISION, USMC, ROCKET COMPANY Korea",  "소장처별", "년도", new List<string> {"지도, 군 통신, 해병대, 라디오, 로켓 (대포), 트럭, 지프차, 포병"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "고지 벙커 안 해병대 한국 MARINES IN THE BUNKER HILL AREA Korea",  "소장처별", "년도", new List<string> {" 비행기, 해병대, 탱크, 군 병원, 병과 부상에 대한 전시 구조, 공격"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한국에 해병대 MARINES IN KOREA",  "소장처별", "년도", new List<string> {"비행기, 폭격기, 요새, 해병대, 로켓 (대포) "}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "'CRIPPLED CHICK ISLAND' 프로젝트 여도, 한국 'PROJECT, CRIPPLED CHICK ISLAND Yo-Do, Korea'",  "소장처별", "년도", new List<string> {"국방부. 미해군. 해군 건설 부대. 9/18/1947-, 항공뷰, 공항, 부두, 상륙 주정, 선원, 삽, 건설 장비"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "평화 회담, 판문점, 함국 PEACE TALKS, PANMUNJOM, KOREA",  "소장처별", "년도", new List<string> {"판문점 (한국), 군 캠프, 사진사, 군 차량, 육군 장교, 종군 기자, 신호와 신호판, 경비병"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "개성 회담 판문점, 한국 KAESONG CONFERENCES Panmunjon, Korea",  "소장처별", "년도", new List<string> {"판문점 (한국), 유엔, 중국인, 의회와 협약, 종군 기자, 군 헬리콥터, 지프차"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "인천 첫 해안 폭격, 한국 THE FIRST SHORE BOMBARDMENT OF INCHON, KOREA",  "소장처별", "년도", new List<string> {"인천 (한국), 미해군. 콜렛 (구축함). 5/16/1944-9/18/1947, 미해군. 로체스터 (중순양함). 12/20/1946-9/18/1947, 국방부. 미해군. 톨레도 (잠수함). 2/24/1995-, 상륙전, 대공포, 군 통신, 회전 포탑, 감시원, 군 기동 부대"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "D 더하기 I DAY 인천, 한국 D PLUS I DAY Inchon, Korea",  "소장처별", "년도", new List<string> {" 인천, 국방부. 미해군. 해군 건설 부대. 9/18/1947-, 상륙 작전, 해병, 군사 지원, 해군 장교, 선박, 트럭, 육군 장교, 전쟁 피해, 부교 다리, 지프차, 트레일러"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "인천 폭격, 한국 BOMBARDMENT OF INCHON, KOREA",  "소장처별", "년도", new List<string> {" 인천 (한국), 미해군. 라이먼 K. 스웬슨 (구축함). 5/2/1944-9/18/1947, 탄약, 공중 포격, 발포, 항구, 상륙 주정, 지뢰 (군용화약), 침입, 예광탄 (탄약), 수륙양용장갑차"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "원산 상륙, 북한 LANDING AT WONSON, NORTH KOREA",  "소장처별", "년도", new List<string> {"지뢰 (군용화약), 선원, 선박, 트럭, GMC 부두 (군 트럭), LCVP (상륙 주정), 침입, 수륙 양육 장갑차, 대형 상륙함, 정찰선"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "Heartbreak 고지, 인제면 지역, 한국 Heartbreak Hill, Inje-Myon Area, Korea",  "소장처별", "년도", new List<string> {" 해병대, 군사 지원, 질의, 육군 장교, 참호, 산, 병과 부상에 대한 전시 구조, 군 헬리콥터, 기관총, 박격포 (대포) "}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "사진총 한국 GUN CAMERA Korea",  "소장처별", "년도", new List<string> {"미해군. 복서 (항공모함). 4/16/1945-9/18/1947, 카메라, 라디오, 로켓 (대포), 철도 마당, 공격 (군사학) "}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "THIS IS KOREA 미공개 영상  SUPPLEMENTS TO THIS IS KOREA",  "소장처별", "년도", new List<string> {" 국방부. 미해군. 잉글리시 (구축함). 9/18/1947-5/15/1970, 비행기, 구축함 (군함), 항구, 로켓 (대포), 전쟁 피해"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "평화 회담 판문점, 한국 PEACE TALKS Panmunjom, Korea",  "소장처별", "년도", new List<string> {"판문점 (한국), C. 터너 조이 (찰스 터너), 1895-1956, 의회와 협약, 발포, 헬리콥터, 휘장, 상륙 작전, 기계류, 우편 제도"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "흥남 철수 활동, 한국 EVACUATION ACTIVITIES AT HUNGNAM, KOREA",  "소장처별", "년도", new List<string> {" 미해군. 뱅거 (고속 수송함). 3/14/1945-9/18/1947, 국방부. 미해군. 위스턴 (상륙 화물 수송함). 1950 ?-1976 ?, 아프리카계 미국인, 해변, 민간인 대피, 폭발, 발포, 상륙 주정, 군사 지원, 피난민, 선박, 군인, 탱크 (군사학), 트럭, 전쟁 피해, 수륙 양용 장갑차, 군 기동 부대, 하역망, 건설 장비"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "THIS IS KOREA 미공개 영상 SUPPLEMENTS TO THIS IS KOREA",  "소장처별", "년도", new List<string> {"비행기, 전함, 항공 폭격, 로켓 (대포), 전쟁 피해, 부교 다리"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "진남포 항구에서 지뢰제거 작전, 한국 MINESWEEPING OPERATIONS AT CHINNAMPO HARBOR, KOREA",  "소장처별", "년도", new List<string> {" 미해군. 카타마운트 (선착장 상륙함). 4/9/1945-9/18/1947, 국방부. 미해군. 포레스트 로열 (구축함). 9/18/1947-3/27/1971, 국방부. 미해군. 굴 (보조 전동 지뢰 제거함). 9/18/1947-8/1/1954, 미해군. 호레이스 B. 베이스 (고속 수송함). 12/21/1944-9/18/1947, 항공, 헬리콥터, 지뢰 (군용화약), 해군 장교, 해운, 송수화기, 영국인, 부교, 기관총, 아프리카계 미국 선원"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "인천에서의 D-DAY 활동, 한국 D-DAY ACTIVITIES AT INCHON, KOREA",  "소장처별", "년도", new List<string> {" 인천 (한국), 국방부. 미해군. 미수리 (전함). 5/10/1985-3/31/1992, 비행기, 대공포, 폭격기, 상륙 주정, 군사 지원, 로켓 (대포), 침입, 회전 포탑, 수륙양용장갑차"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한국에서 해병대 퇴각 MARINE RETREAT IN KOREA",  "소장처별", "년도", new List<string> {"북한, 행군, 탱크, 군용차, 군용기, 투하, 군용트럭, 군수품, 철로"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "구축함 원산 포격, 한국 DESTROYER BOMBARDMENT OF WONSAN, KOREA",  "소장처별", "년도", new List<string> {"원산 (한국), 급식, 통신장비, 망원경, 포격, 군함, 포탄"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "구축함 원산 포격, 한국 DESTROYER BOMBARDMENT OF WONSAN, KOREA",  "소장처별", "년도", new List<string> {" 원산 (한국), 군함, 포격, 연기, 보트, 헬리콥터"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));


        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한국에 캐나다군, 임진강 CANADIANS IN KOREA, IMJIN RIVER",  "소장처별", "년도", new List<string> {" 군용트럭, 견인, 토치, 용접, 탱크, 대포, 확성기, 통신장비, 군용차, 송수화기"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "이승만 대통령 취임식 서울, 한국 INAUGURATION OF PRESIDENT SYNGMAN RHEE Seoul, Korea",  "소장처별", "년도", new List<string> {" 서울 (한국), 마크 W. 클라크 (마크 웨인), 1896-1984, 이승만, 1875-1965, 자동차, 취임식, 육군 장교, 합창 (음악), 헌병대, 신호와 신호판"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "유엔 & 공산군 휴전 협상 판문점, 한국 UN & COMMUNIST ARMISTICE NEGOTATIONS Panmunjom, Korea",  "소장처별", "년도", new List<string> {"판문점 (한국), C. 터너 조이 (찰스 터너), 1895-1956, 의회와 협약, 비와 강우량, 진흙 "}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "초계 어뢰정 작전 진해, 한국 PT BOAT OPERATIONS Chinhae, Korea",  "소장처별", "년도", new List<string> {" 영국, 미해군. 데이비스 카운티 (대형 상륙선). 1944 ?-9/18/1947, 탄약, 대공포, 밴드 (음악), 상륙 주정, 해군 장교, 레이더, 로켓 , 선박, 정찰 보트"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "헬리콥터 반-지뢰 작전 원산 항공, 북한 HELICOPTER ANTI-MINE OPERATIONS Wonsan Harbor, N. Korea",  "소장처별", "년도", new List<string> {"한국인 ,  미해군. 콘도르 (전동 소해정). 2/1947-9/18/1947, 미해군. 멀렛 (소해정). 8/21/1945-9/18/1947, 항공 조종사, 비행기, 헬리콥터, 상륙 주정, 지뢰 (군용화약), 군 헬리콥터, 풍량계, 생존자 수색과 구조"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "유엔 & 공산군 휴전 협상 판문점, 한국 UN & COMMUNIST ARMISTICE NEGOTIATIONS Panmunjom, Korea",  "소장처별", "년도", new List<string> {" 판문점 (한국), 리비, 룻벤 엘머, 1900-1986, 풍선, 의회와 협약, 한국인, 텐트, 신호와 신호판, 선박조종술"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한국에 해병대와 (동해안) WITH MARINES IN KOREA (EAST COAST)",  "소장처별", "년도", new List<string> {" 한국 , 우편 제도, 레크레이션, 눈, 참호, 워키토키, 병과 부상에 대한 전시 구조"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "This is korea 미공개   THIS IS KOREA, SUPPLEMENT",  "소장처별", "년도", new List<string> {" 국방부. 미해군. 미수리 (전함). 5/10/1985-3/31/1992,  항공모함, 비행기, 공중 포격, 구축함 (군함), 폭발, 축구, 막사, 얼음, 군사 기지, 로켓 (대포), 선박, 전쟁 피해, 행진, 수류탄, 수녀"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "전쟁의 하루 한국 ONE DAY OF WAR Korea",  "소장처별", "년도", new List<string> {"미해군. 복서 (항공모함). 4/16/1945-9/18/1947, 항공 조종사, 비행기, 대공포, 공중 폭격, 선박, 트랙터, 군 헬리콥터"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "원산 피난, 한국 EVACUATION OF WONSAN, KOREA",  "소장처별", "년도", new List<string> {"국방부. 미해군. 맥킨리 산 (상륙지휘함). 9/18/1947-1976, 크래인, 기중기 등, 부두, 민간인 대피, 항구, 상륙 주정, 군사 지원, 선박, 전쟁 비행, 행진"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "흥남 철수 한국 EVACUATION OF HUNGNAM KOREA",  "소장처별", "년도", new List<string> {" 비행기, 폭탄, 공중 폭격, 구축함 (군함), 민간인 대피, 폭발, 항구, 상륙 주정, 탱크"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "흥남 포격, 한국 BOMBARDMENT OF HUNGNAM, KOREA",  "소장처별", "년도", new List<string> {"탄약, 대공포, 방파제, 구축함 (군함), 민간인 대피, 폭발, 항구, 군사 지원, 도로, 로켓 (대포), 선박, 트럭, LCVP (상륙 주정), 군 기동 부대"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "인천 피난, 한국 EVACUATION OF INCHON, KOREA",  "소장처별", "년도", new List<string> {"인천 (한국) , 미해군. 엘도라도 (상륙지휘함). 8/25/1944-9/18/1947, 민간인 대피, 폭발, 항구, 상륙 주정, 해군 장교, 철로, 선박 조종술"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한국 인천에서의 D-DAY D-DAY AT INCHON, KOREA",  "소장처별", "년도", new List<string> {" 인천 (한국),  국방부. 미해군. 맥킨리 산 (상륙지휘함). 9/18/1947-1976 ?, 미해군. 로체스터 (중순양함). 12/20/1946-9/18/1947, 더글라스 맥아더, 1880-1964, 아서 D. 스트러블 (아서 듀이), 1894-1983, 로버트 M. 도일 (로버트 모리스), 1853-1925, 공중 폭격, 항구, 선박, 상륙 주정, 해군 장교, 침입, 수륙양용장갑차"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "진남포에서 지뢰제거 작전, 한국 MINESWEEPING OPERATIONS AT CHINNAMPO, KOREA",  "소장처별", "년도", new List<string> {"국방부. 미해군. 굴 (보조 모터 지뢰 제거기). 9/18/1947-8/1/1954, 군통신, 개, 항구, 헬리콥터, 상륙 주정, 지뢰 (군용화약), 해군 장교, 스쿠버 드라이버"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "미국 해병대의 한국에서의 퇴각 MARINE RETREAT IN KOREA",  "소장처별", "년도", new List<string> {"북한,  텐트, 환자, 군용기, 행군, 포탄, 군용트럭, 취사"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "흥남 부두 활동, 한국 ACTIVITY AT HUNGNAM HARBOR, KOREA",  "소장처별", "년도", new List<string> {"미해군. 뱅거(고속 수송함). 3/14/1945-9/18/1947, 국방부. 미해군. 맥킨리 산 (상륙지휘함). 9/18/1947-1976 ?, 국방부. 미해군. 성 파울 (중순양함). 9/18/1947-4/30/1971, 국방부. 미해군. 리포스 (병원선). 9/18/1947-5/1/1970, 알몬드 M. 에드워드 (에드워드 말러리), 1892-1979, 로버트 M. 도일 (로버트 모리스), 1853-1925, 탄약, 민간인 대피, 폭발, 상륙 주정, 군수 지원, 선박, 눈, 창고, 전쟁 피해, 산"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "흥남 철수, 한국 EVACUATION OF HUNGNAM, KOREA",  "소장처별", "년도", new List<string> {" 국방부. 미해군. 카트마이 산(탄약선). 9/18/1947-8/14/1973, 미해군. 필리핀 바다(항공모함). 5/11/1946-9/18/1947, 비행기, 탄약, 군 통신, 군사 지원, 레크레이션, 연료 주입, 하역망, 폭풍 해일"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한국 휴전선 Truce Line Korea",  "소장처별", "년도", new List<string> {"막사, 한반도 비무장 지대 (한국), 라디오,  소총, 군인, 보초 임무, 군식당, 식기 세트, 청소, 군사 훈련"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "BIG SWITCH, 무산리와 판문점, 한국 BIG SWITCH, MUNSAN-NI AND PANMUNJOM, KOREA",  "소장처별", "년도", new List<string> {" 무산리 (경기도, 한국) , 판문점 (한국), , 랜돌프 M. 페이트 (랜돌프 맥콜), 1898-1961, 앰뷸런스, 헬리콥터, 상륙 작전, 해병대, 의료진, 전쟁 포로, 송환"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "LITTLE SWITCH, 음성 포함 인터뷰, 무산리, 한국 LITTLE SWITCH, INCLUDING SOUND INTERVIEWS, MUNSAN-NI, KOREA",  "소장처별", "년도", new List<string> {" 무산리 (경기도, 한국), 공항, 헬리콥터, 간호사, 내과 의사, 육군 장교, 마이크로폰, 텐트, 지프차, 치카소 (헬리콥터) "}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "헌병대 (MP) 차량 정찰, 제10 군단, 한국 MILITARY POLICE (MP) TRAFFICE PATROL, X CORPS, KOREA",  "소장처별", "년도", new List<string> {" 상륙 주정, 헌병대, 경찰, 사찰, 아프리카계 미국 군인"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "SP-1 전쟁포로, 부산, 한국 SP-1 Prisoners of War, Pusan, Korea",  "소장처별", "년도", new List<string> {" 배구, 철조망, 전쟁포로, 세수, 캠프, 옥상뷰"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "선전 포격 회의, 판문점, 한국, 등 INVESTIGATION OF PROPAGANDA SHELL, PANMUNJOM, KOREA; ETC",  "소장처별", "년도", new List<string> {" 군용차, 군용기, 군악대, 군용트럭, 행군, 관중, 공연, 헬리콥터, 사진사"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "유엔이 한국에 병력을 파견하다 UN RUSH TROOPS TO KOREA",  "소장처별", "년도", new List<string> {" 선박, 보트, 군악대, 사진사, 연설, 행군, 비행기, 탱크, 군용차, 군용트럭"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한국에 캐나다 병력을 위한 기동 훈련 SPEED TRAINING FOR CANADIAN TROOPS IN KOREA",  "소장처별", "년도", new List<string> {" 사격, 바주카, 군용트럭, 포격, 행군, 열차, 선박, 빨래, 화물"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "더글라스 맥아더 장군 한국 방문 GEN. DOUGLAS MACARTHUR VISITS KOREA",  "소장처별", "년도", new List<string> {" 비행기, 군용차, 사진사, 활주로, 임시다리"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "카톨릭 성당, 원산, 한국 CATHOLIC CHURCH, WONSAN, N. KOREA",  "소장처별", "년도", new List<string> {" 음성있음, 체험담, 증언"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "카톨릭 성당, 원산, 한국 CATHOLIC CHURCH, WONSON, KOREA",  "소장처별", "년도", new List<string> {" 음성있음, 교회, 그림, 한국인, 대담, 통역"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한국 행진곡, 부산, 한국 KOREAN MARCHING SONGS, PUSAN, KOREA",  "소장처별", "년도", new List<string> {" 음성있음, 텐트, 행군, 연기, 철조망, 노래"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "흥남 철수, UDT, 한국 EVACUATION OF HUNGHAM, UDT, KOREA",  "소장처별", "년도", new List<string> {" 군용트럭, 와이어, 보트, 로프, 수중 투하, 연기, 부두"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "혜산진 항공뷰, ; 미국해군모함 필리핀 바다 (CV-47) 연료 보급과 보급품 인수 탑승;  AERIAL VIEWS OF HYESANJIN, KOREA AND NEARBY MOUNTAINS; REFUELING AND TAKING ON SUPPLIES ABOARD THE USS PHILIPPINE SEA (CV-47); LIGHT DECK OPERATIONS IN SNOWSTORM",  "소장처별", "년도", new List<string> {" 국방부. 미해군. 카트마이 산 (탄약선). 9/18/1947-8/14/1973, 미해군. 필리핀 바다 (항공모함). 5/11/1946-9/18/1947, 비행기, 탄약, 군통신, 오락, 폭풍, 기관총, 연료 공급, 하역망, 폭풍 해일"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한국 전쟁, 조 디마지오와 레프티 오돌, 함흥&김포 공군 기지 KOREAN WAR, JOE DI MAGGIO AND LEFTY O'DOUL, HAMHUNG & KIMPO AIRBASE ; KOREAN WAR ARRIVALS AT HAMHUNG, KOREA ; BOB HOPE SHOW, KIMPO, KOREA",  "소장처별", "년도", new List<string> {" 비행기, 군용차, 자동차, 병원, 환자, 의장대, 수여식, 배구, 군용기, 기자, 인터뷰, 공연"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "도판 다리에 낙하산 투하를 동반한 작전, 한국 ACTION ACCOMPANYING PARACHUTE DROP OF THE TREADWAY BRIDGE, KOREA",  "소장처별", "년도", new List<string> {" 한천강 (한국), 바지선, 공병, 상륙 주정, 구명 보트, 낙하산, 육군 장교, 트렉터, 지프차, GMC 부두 (군트럭) "}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "제1 해병대 사단을 위한 대니 케이 쇼, 제5 여단 한국 DANNY KAYE SHOW FOR THE 1ST MARINE DIVISION, 5TH REGIMENT Korea",  "소장처별", "년도", new List<string> {" 대니 케이, 1913-1987, 비행기, 관중, 오락 행사, 해병대, 아코디언, 신호와 신호판, 군 헬리콥터"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "미국 해병대 정찰 & 한국에서의 활동 구동Ku-Dong, 한국 US MARINE PATROLS & ACTIVITIES IN KOREA Ku-Dong, Korea",  "소장처별", "년도", new List<string> {" 탄약, 벙커 (요새), 요새화, , 해병대, 지뢰 (군용 화약), 보초 업무, 철조망, 감시원, 대형 상륙함, 기관총, 포수"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "THIS IS KOREA 미공개 영상 SUPPLEMENTS TO THIS IS KOREA",  "소장처별", "년도", new List<string> {" 도쿄 (일본), 한국, 구축함 (군함), 항구, 선박, 부교, 대형 상륙함, 포수"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "제1 해병대 사단을 위한 대니 케이 쇼 한국 DANNY KAYE SHOW FOR THE 1ST MARINE DIVISION Korea",  "소장처별", "년도", new List<string> {" 대니 케이, 1913-1987, 비행기, 오락 행사, 해병대, 텐트, 군병원, GMC 부두 (군트럭) "}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한국 흥남 활동; 일본 도쿄 크리스마스 장식 ACTIVITIES IN HUNGNAM, KOREA; CHRISTMAS DECORATIONS IN TOKYO, JAPAN",  "소장처별", "년도", new List<string> {" 도쿄 (일본), 한국, 공중 폭격, 크리스마스, 부두, 노동자, 상륙 주정, 의료 관리, 전체 상선, 군사 지원"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "정찰 비행대대. VP-6; 북한 흥남 항구 활동 PATROL SQDN. VP-6; ACTIVITIES IN HUNGNAM HARBOR North Korea",  "소장처별", "년도", new List<string> {" 비행기, 항구, 해변, 민간인 대피, 상륙 주정, 전체 상선, 전쟁 상해, 행진, 병과 부상에 대한 전시 구조"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "미국해군전함 뉴저지 (BB-62)  작전개시, 개성, 한국 지역 INITIAL OPERATION OF USS NEW JERSEY (BB-62) Kansong, Korea Area",  "소장처별", "년도", new List<string> {" 미해군. 아놀드 J. 이사벨 (구축함). 1/5/1946-9/18/1947, 알레이 A. 버크 (알레이 알버트), 1901-1996, 대공포, 전함, 부표, 구축함 (군함), 해군 장교, 회전 포탑"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "OLD BALDY 전투, 제2 보병 사단 지역, 한국 BATTLE FOR OLD BALDY, 2ND INF DIV AREA, KOREA",  "소장처별", "년도", new List<string> {" 전투 사상자, 위장 (군사학), 발굴, 폭발, 헬리콥터, 위생, 헌병대, 병과 부상에 대한 전시 구조, 샌드백, 수류탄, 곡사포, 계곡, 병력호송장갑차"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "매킨리 산  'D ' DAY, 매킨리 산 탑승 인천, 한국 ABOARD THE MT. McKINLEY ON  'D ' DAY, INCHON, KOREA",  "소장처별", "년도", new List<string> {" 아서 D. 스트러블 (아서 듀이), 1894-1983, 레무엘 C. 셰퍼드 (레무엘 코닉), 1896-1990, 폭발, 항공, 항구, 상륙 주정, 해군 장교, 육군 장교, 순양함 (군함), 침입, 부교, 군 기동대"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "Little Switch 작전- 무신리와 K-16, 한국 Operation Little Switch- Munsan-ni and K-16, Korea",  "소장처별", "년도", new List<string> {" 무산리 (경기도, 한국), 미국 적십자사 2/12/1978-, 멕스웰 D 테일러. (맥스웰 데번포트), 1901-1987, 비행기, 헬리콥터, 환자, 전쟁포로, Little Switch 작전, 1953, C-124 (수송기) "}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "LITTLE SWITCH (포로 송환), 판문점과 무산리, 한국 LITTLE SWITCH (RETURNING PRISONERS), PANMUNJOM AND MUNSAN-NI, KOREA",  "소장처별", "년도", new List<string> {" 무산리 (경기도, 한국), 판문점 (한국) (Korea), 한국, 앰뷸런스, 다리, 신호와 신호판"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "OLD BALDY 전투, 제2 보병 사단 지역, 한국 BATTLE FOR OLD BALDY, 2ND INF DIV AREA, KOREA",  "소장처별", "년도", new List<string> {" 포병대, 벙커 (요새), 저녁 식사와 만찬, 음식, 군식당, 식기 세트, 폭발, 헬멧, 탱크 (군사학), 무덤, 보초 업무, 아프리카계 미국 군인, 철조망, 예광탄 (탄약), 청소, 기관총, 병력 호송 장갑차"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "지뢰제거선 (MSB) 작전, 원산발, 한국 MINESWEEP BOAT (MSB) OPERATION, OFF WONSAN, KOREA",  "소장처별", "년도", new List<string> {" 구축함 (군함), 상륙 주정, 지뢰 (군용화약), 바다, 선원, 선박, 난파선"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "제 101 통신 대대 건설, 춘천, 한국 101ST SIGNAL BN CONSTRUCTION, CHUNCHON, KOREA",  "소장처별", "년도", new List<string> {" 춘천 (한국), 통신, 전선, 폭발, 군인, 송수화기, 트럭, 와이어, 해머"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  " '트루먼 대통령 한국에 대해 발표 '  'President Truman Reports on Korea '",  "소장처별", "년도", new List<string> {" 뉴욕 (N.Y.), 유엔, 트루먼 S. 헨리, 1884-1972, 딘 애치슨, 1893-1971, 더글라스 맥아더, 1880-1964, 엘리너 루스벨트, 1884-1962, 깃발, 퍼레이드, 선박, 자유의 여신상 (뉴욕, N.Y.) "}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "정보 수색 정찰, 제7 사단 17 보병대대, INF, 응가리, KOREA INTELLIGENCE AND RECONNAISSANCE PATROL, 17TH INF, 7TH DIV, UNGYA-RI, KOREA",  "소장처별", "년도", new List<string> {" 군용차, 대포, 포탄, 포격"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "일반활동, 미국해군전함 맨체스터의 송진 해변을 공격하다, 한국 GENEREAL ACTIVITIES, USS MANCHESTER FIRING ON BEACH AT SONGJIN, KOREA",  "소장처별", "년도", new List<string> {" 군함, 포격, 쌍안경, 통신장비, 헬리콥터, 항공뷰, 환자, 포탄"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한국군 제1 사단 (개성 지역 내와 그 근방 지역 부근 우호 게릴라 작전) 한국 1ST ROK DIV (FRIENDLY GUERRILLAS OPERATING IN AND AROUND KAESONG AREA) KOREA",  "소장처별", "년도", new List<string> {" 군용차, 한국인, 보트, 지도, 책상, 쌍안경, 대포, 포격, 나룻배"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "제27 보병 여단,강을 넘다,  한강, 한국 RIVER CROSSING, 27TH INF REGT, HAN R AREA, KOREA",  "소장처별", "년도", new List<string> {" 박격포 , 송수화기, 취사, 부교, 군용차, 고무보트, 기중기, 불도저, 탱크, 보트, 신문, 기병"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "해병대 근접항공지원 (제1 사단) 한국 CLOSE AIR SUPPORT OF MARINES (IST DIVISION) Korea",  "소장처별", "년도", new List<string> {" 군사 정보 통신, 해병대, 군사 지원, 낙하산, 라디오, 트럭, 전쟁 상해, 육군 장교보초 근무, 참호선, 병과 부상에 대한 전시 구조, 군 헬리콥터, 감시원, 발전기"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "미국해군전함 라이먼 K. 스웬슨 (DD-729) 탑승 인천 침입 작전, 한국 ACTION ABOARD THE USS LYMAN K. SWENSON (DD-729) INVASION OF INCHON, KOREA",  "소장처별", "년도", new List<string> {" 인천 (한국), 미해군. 라이먼 K. 스웬슨 (구축함). 5/2/1944-9/18/1947, 구급차, 상륙전, 공중 폭격, 해병대, 해군 장교, 전쟁 피해, 지프차, 트레일러, 수륙 양용 장갑차"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "인천에서의 활동, 한국; 병원 환자 이송; 작전용 부두 교각; 크리스마스 트리ACTIVITIES AT INCHON, KOREA; REDEPLOYMENT OF HOSPITAL PATIENTS; PONTOON PIER READY FOR OPERATION; CHRISTMAS TREE",  "소장처별", "년도", new List<string> {" 인천 (한국), 미해군. 엘도라도 (상륙지휘함). 8/25/1944-9/18/1947, 국방부. 미해군. 리포스 (병원선). 9/18/1947-5/1/1970, 항공 조종사, 비행기, 구급차, 민간인 대피, 상륙 주정, 선박, 탱크 (군사학), 부교, 병과 부상에 대한 전시 구조, 아프리카계 미국 국인"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "작전 변경 유엔 전쟁 포로 (POW) #1 캠프, 거제도, 한국 OPERATION SWAP, UNITED NATIONS PRISONER OF WAR (POW) CAMP #1, KOJE-DO, KOREA",  "소장처별", "년도", new List<string> {" 거제도 (한국), 판문점 (한국), 전쟁포로, 레크레이션, 송환, 군인, 행진, 기관총, 경비병"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "R & R, K-16 공군 기지 공군 기지 서울, 제40 미국 보병 사단 지역, 한국 R & R, K-16 AFB AFB SEOUL, 40TH U.S. INF DIV AREA, KOREA",  "소장처별", "년도", new List<string> {" 서울 (한국), 공항, 시상식, 벙커 (요새), 소총, 군인, 운영 배급량 (군사 지원), 샌드백, 저격총, C-119 대형 수송기 (수송기) "}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "미국해군모함 에식스(CV-9) 비행갑판에 F2H 충돌과 화재 , 한국발 F2H CRASH AND FIRE ON FLIGHT DECK OF USS ESSEX(CV-9) Japanese Sea, Off Korea",  "소장처별", "년도", new List<string> {" 미해군. 에식스 (항공모함). 12/31/1942-1/9/1947, 항공모함, 비행기, 소화, 소방관"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "육군 간호대와 WMSC 활동, 서울, 한국 Army Nurse Corps and WMSC activities, Seoul, Korea",  "소장처별", "년도", new List<string> {" 서울(한국), 공항, 의료 지원, 간호사, 환자, 내과 의사, 외과 의사, 수술, C-124 (수송기), 수술실, 휴식"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "식품 패키지 배부, PONCHON, 한국 ; VIP의 제 40 사단 지역 순회, 한국 DISTRIBUTION OF FOOD PACKAGES, PONCHON, KOREA ; VIP'S TOUR 40TH DIVISION AREA, KOREA",  "소장처별", "년도", new List<string> {" Ponchon포천 (한국), 맥스웰  D. 테일러. (맥스웰 테일러), 1901-1987, 토마스 F. 하키 (토마스 프랜시스), 1898-1983, 리겔리 게이더, 1903-1992, 깃발, 군인, 운영 배급제 (군사 지원), 의장대, 치카소 (헬리콥터), 노래, 환영 행사"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
       
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "보병 산악 작전, 제40 사단 지역, 한국 INFANTRY OPERATIONS IN THE MOUNTAINS, 40TH DIV AREA, KOREA",  "소장처별", "년도", new List<string> {" 탄약, 조경, 소총, 군인, 탱크 (군사학), 공격 (군사학) "}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "래리 핀리 쇼, 미국위문협회USO 행사 1098, 제40 미국 보병 사단, 한국 LARRY FINLEY SHOW, USO SHOW 1098, 40TH U.S. INF DIV, KOREA",  "소장처별", "년도", new List<string> {" 허브 제프리즈, 도티 오브라이언O'Brien, Dottie, 챔프 버틀러, 밴드 (음악), 노래, 카메라, 담배, 트럭, 악기, 아프리카계 미국 군인, 박수"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "유엔한국민사원조위원회. (UNCACK) 활동, 중앙 구호 위원회 회의, 부산, 한국; 등 UNITED NATIONS CIVIL ASSISTANCE COMMAND KOREA (UNCACK) ACTIVITIES, CENTRAL RELIEF COMMITTEE MEETING, PUSAN, KOREA; ETC",  "소장처별", "년도", new List<string> {" 책상, 회의, 서류, 신생아실, 부산아동자선병원, 길거리, 한국인"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  " 'THUNDER FROM THE SKY ', 한국 전술 공군 이야기  'THUNDER FROM THE SKY ', A STORY OF THE TACTICAL AIR FORCES IN KOREA",  "소장처별", "년도", new List<string> {" 전투기, 폭격, 회담, 사격, 군함, 폭격, 항공뷰, 탱크, 브리핑, 포탄"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "육군 수송 이야기, 한국 부산 ; 육군 수송 이야기, 인천, 한국 Army transportaion story, Pusan Korea ; Army transportation story, Inchon, Korea",  "소장처별", "년도", new List<string> {" 선박, 군용트럭, 군수품, 열차, 보트, 노동자, 군용차, 환자, 적십자"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "96 야전 포병 대대, 양구,제10 전방 포병대 활주로, 한국, 포레스트셔먼 하네다공군 96TH FIELD ARTILLERY BATTALION, YANGGU, KOREA ; VIPS, 10TH FORWARD ARTILLERY AIRSTRIP, KOREA ; ADM. FORREST SHERMAN, HANEDA AIR BASE, TOKYO, JAPAN",  "소장처별", "년도", new List<string> {" 대포, 포격, 책상, 통신기, 군용기, 활주로, 비행기, 사진사, 자동차"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "오스트레일리안 F-21'S (전투기) 부산, 한국 ; 손상된 F-51 전투기, 부산, 한국 AUSTRALIAN F-21'S (PLANES) PUSAN, KOREA ; CRASHED F-51 PLANE, PUSAN, KOREA",  "소장처별", "년도", new List<string> {" 군용기, 군용트럭, 연료, 포탄, 탄약, 기중기"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "헬리콥터 운용, 원주, ; 40 사단 극동을 향해 승선, 포트 메이슨, 샌프란시스코, HELICOPTER OPERATION, WONJU, KOREA ; 40TH DIVISION EMBARKATION FOR THE FAR EAST, FORT MASON, SAN FRANCISCO, PORT OF EMBARKATION",  "소장처별", "년도", new List<string> {" 천막, 헬리콥터, 환자, 군용트럭, 적십자, 대포, 선박, 깃발"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  " 프린스턴 탑승, CV-37, 항공모함, 제1 왕실 해병 특공대 ABOARD THE USS PRINCETON, CV-37, AIRCRAFT CARRIER- OFF KOREA 1ST ROYAL MARINE COMMANDOS AT RAID BELOW SONGJIN, N KOREA",  "소장처별", "년도", new List<string> {" 전함, 포탄, 쌍안경, 탱크, 철로, 통신기, 폭발, 포격"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "항복 전단 투하, 대구, 한국 ; 전투기 조종과 T6 (MOSQUITO 전투기), 대구 SURRENDER LEAFLET DROP, TAEGU, KOREA ; FIGHTER CONTROL AND T6 (MOSQUITO FIGHTER PLANES), TAEGU",  "소장처별", "년도", new List<string> {" 선전, 군용기, 통신장비, 군용차, 탱크, 포탄"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "7기갑 여단 강 건넘 추천, 잔혹 행위 7기갑 강 건넘  7TH CAVALRY REGT RIVER CROSSING, N OF CHUNCHON, KOREA ; 8TH CAV ASSAULT ; ATROCITY AND 7TH CAV RIVER CROSSING",  "소장처별", "년도", new List<string> {" 돌다리, 군용차, 탱크, 불, 폭발, 보트"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "패트리지 중장 (제5 공군AF사령관), ; 북위 38도선으로부터 북쪽으로 10마일, 제187 여단, LT. GEN. EARLE E. PARTRIDGE (CG 5TH AF) AWARD, EUSAK TAEGU, KOREA ; 10 MILES NORTH OF THE 38TH PARALLEL, 187TH RCT, INJE, KOREA",  "소장처별", "년도", new List<string> {" 깃발, 의장대, 군악대, 사진사, 자동차, 군용차, 군용트럭, 탱크, 헬리콥터, 공중보급, 군수품"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "조지 I. 백 장군 도착, 극동 사령부, 대구, 한국 ; 한국 전쟁, 피난민, 함안, 한국 KOREAN WAR, ARRIVAL OF GENERAL GEORGE I. BACK, SIGNAL OFFICER, GENERAL HEADQUARTERS, FAR EAST COMMAND, TAEGU, KOREA ; KOREAN WAR, EVACUEES, HAMAN, KOREA",  "소장처별", "년도", new List<string> {" 군용차, 비행기, 군용기, 송수화기, 전투기, 피난민, 열차, 철로, 역"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "주한 군사 고문단(KMAG), 한국 KMAG, KOREA",  "소장처별", "년도", new List<string> {" 송수화기, 쌍안경, 군용트럭, 군수품, 군용차, 통신장비, 헬리콥터, 환자, 박격포, 전선, 노동자"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "흥남 철수, 한국 EVACUATION OF HUNGNAM, KOREA",  "소장처별", "년도", new List<string> {" 군함, 불, 피난민, 철로, 철조망, 박격포, 포격, 탱크, 보트"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한국에 온 잭 버니, 철원 JACK BENNY IN KOREA, CHORWON",  "소장처별", "년도", new List<string> {" 공연, 연주, 군행사"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "SP-1 전쟁 포로, 부산, 한국 SP-1 PRISONERS OF WAR, PUSAN, KOREA",  "소장처별", "년도", new List<string> {" 전쟁포로, 취사, 군식당, 소독, 이발, 철조망, 배구"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "전투 선적작전, 인천, 한국 ; 잔혹 행위, 평양, 한국 COMBAT LOADING OPERATIONS, INCHON, KOREA ; ATROCITIES, PYONGYANG, KOREA",  "소장처별", "년도", new List<string> {" 군수품, 고무보트, 강, 선박, 불도저, 부두, 전함, 포탄"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "평화 협상 회담, 개성과 무산리, 한국 CEASE FIRE TALKS, KAESONG AND MUNSAN-NI, KOREA",  "소장처별", "년도", new List<string> {" 군용차, 부교, 사진사, 궁, 송수화기, 열차, 헬리콥터, 군용트럭, 텐트, 탱크, 철조망"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  " 'PIPE DREAM ' 작전, 제24 보병 사단 훈련, 한국 OPERATION  'PIPE DREAM ', 24TH INFANTRY DIVISION TRAINING, KOREA",  "소장처별", "년도", new List<string> {" 사격, 기관총, 탄약, 전투기, 폭격, 화염방사기, 군용차, 지도, 통신기구"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "서울 철수와 방어, 중서부, 한국 RETREAT AND DEFENSES OF SEOUL, WEST CENTRAL, KOREA",  "소장처별", "년도", new List<string> {" 대포, 포격, 시청, 탱크, 카드게임, 연기, 쌍안경, 송수화기, 박격포"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "EUSAK 의장대, 대구, 한국 EUSAK HONOR GUARD, TAEGU, KOREA",  "소장처별", "년도", new List<string> {" 군악대, 깃발, 행진, 의장"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "헬리콥터 작전, 대구, 한국 HELICOPTER OPERATIONS, TAEGU, KOREA",  "소장처별", "년도", new List<string> {" 헬리콥터, 군용트럭, 적십자, 환자, 항공샷, 낙하산"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));



        saveData.Data0.Add(new Datajson("기록영상", 1949,  "서울을 위한 쌀, 서울, 한국 RICE FOR SEOUL, SEOUL, KOREA",  "소장처별", "년도", new List<string> {" 탱크, 쌍안경, 사격, 행군, 노숙, 군용차, 부상자, 비행기, 화재, 소화"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "수색 정찰, 한국 ; 제187 공수, 무산리 RECONNAISSANCE PATROL, KOREA ; 187TH AIRBORNE, MUNSON-NI",  "소장처별", "년도", new List<string> {" 탱크, 군용차, 지뢰탐지기, 군용트럭, 부상, 기관총, 사격, 행군, 헬리콥터, 환자, 적십자"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "F-86 작전, 진격 공군 활주로 , 대구, 한국 F-86 OPERATIONS, ADVANCED AIR FIELD, TAEGU, KOREA",  "소장처별", "년도", new List<string> {" 군용기, 비행기, 활주로, 포탄, 연료, 탄약"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "탱크와 정찰, 전주 남부, 한국 TANKS AND PATROL, N CHONJU, KOREA",  "소장처별", "년도", new List<string> {" 군용트럭, 탱크, 포탄, 연료, 길거리, 포로, 군용기"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한국군 제1 사단, 수원 남부, 한국 1ST ROK DIVISION, NORTH OF SUWON, KOREA",  "소장처별", "년도", new List<string> {" 포격, 박격포, 송수화기, 쌍안경, 지도, 헬리콥터, 탱크, 지뢰탐지기, 사격"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한국행진곡, 부산, 한국 KOREAN MARCHING SONGS, PUSAN, KOREA",  "소장처별", "년도", new List<string> {" 음성있음, 천막, 행군, 철조망"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  " 박격포 소대, 인천, 한국 HEAVY MORTAR PLATOON, INCHON, KOREA",  "소장처별", "년도", new List<string> {" 박격포, 포탄, 포격, 탱크, 군용트럭, 기관총, 사격"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "유엔  캐나다 부대, 밀양, 한국 CANADIAN UN FORCES, MIRYANG, KOREA",  "소장처별", "년도", new List<string> {" 천막, 송수화기, 군용트럭, 군용차, 탱크, 빨래, 깃발"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한국에 해병대, 마산 WITH THE MARINES IN KOREA ; MASAN",  "소장처별", "년도", new List<string> {" 사격, 군용트럭, 군용차, 군수품, 군함, 쌍안경, 배구, 사격, 적십자"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "흥남 철수, 한국 EVACUATION OF HUNGNAM, KOREA",  "소장처별", "년도", new List<string> {" 보트, 군함, 연기"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "흥남 철수, 한국 EVAC수ATION, HUNGNAM, KOREA",  "소장처별", "년도", new List<string> {" 대공포, 송수화기, 포격, 닻, 보트, 선박, 연기, 군용기, 불, 군함"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "정찰 활동, 함흥, 한국 PATROL ACTION, HAMHUNG, KOREA",  "소장처별", "년도", new List<string> {" 군용차, 군용트럭, 기관총, 탄약, 행군, 통신기, 탱크, 사격"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "흥남 철수, 한국 EVACUATION OF HUNGNAM, KOREA",  "소장처별", "년도", new List<string> {" 군함, 보트, 포격, 군용트럭, 밀가루, 철로, 피난민"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "흥남 철수, 한국 EVACUATION OF HUNGNAM, KOREA",  "소장처별", "년도", new List<string> {" 군용트럭, 기중기, 철로, 군함, 보트, 피난민"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "흥남 철수, 한국 EVACUATION OF HUNGNAM, KOREA",  "소장처별", "년도", new List<string> { " 피난민, 군함, 보트, 군용차, 탱크"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "잔혹 행위, 덕산 니켈 광산, 함흥, 북한 ATROCITIES, DUKSAN NICKEL MINE, HAMHUNG, N KOREA",  "소장처별", "년도", new List<string> {" 한국인, 오열, 불, 행군"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "군사제, 부상자&위생병, 안주, 한국 CHAPLAIN, WOUNDED & MEDICS, ANJU, KOREA",  "소장처별", "년도", new List<string> {" 환자, 행군, 탱크, 한국인, 소형화기, 지뢰탐지기, 다리, 군용차"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "제1 한국군 사단, PAKCHONG 부근, 한국 1ST ROK DIVISION, NEAR PAKCHONG, KOREA",  "소장처별", "년도", new List<string> {" 기관총, 박격포, 위장, 지도, 쌍안경, 송수화기, 전봇대"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "낙하산 강하, 숙천, 한국 ; 한국 전쟁, 청주, 한국 PARACHUTE JUMP, SUKCHON, KOREA ; KOREAN WAR, CHONGJU, KOREA",  "소장처별", "년도", new List<string> {" 낙하산, 군용기, 공중보급, 군용차, 장비, 환자, 탱크, 태극기"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
       
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "폭탄 피해와 부상자의 항공 후송, 한국 BOMB DAMAGE AND AIR EVACUATION OF WOUNDED, KOREA",  "소장처별", "년도", new List<string> {" 탱크, 비행기, 다리, 항공뷰, 지도, 브리핑"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "제7 육군 사단이 이원에 도착, 한국 SEVENTH ARMY DIVISION LANDING AT IWON, KOREA",  "소장처별", "년도", new List<string> {" 선박, 보트, 철로, 수레, 군용기, 군함, 불도저, 군용차, 군용트럭, 보트, 선박, 행군"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "김포 공항(FIELD), 한국에 해경 항공전대, 한국 MARINE AIR GROUPS AT KIMPO FIELD, KOREA ",  "소장처별", "년도", new List<string> {" 활주로, 군용기, 군용차, 군용트럭, 텐트"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "유엔의 날,  서울, 한국 ; 한국 전쟁, 숙천 UN DAY, SEOUL, KOREA ; KOREAN WAR, SUKCHON",  "소장처별", "년도", new List<string> {" 연설, 군악대, 행진, 화재, 연기, 대포, 군용차, 환자, 정찰, 포로"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "해방 기념식, 서울, 한국 LIBERATION CEREMONIES, SEOUL, KOREA",  "소장처별", "년도", new List<string> {" 깃발, 연설, 사진사, 회의실"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "서울 탈환, 한국 RECAPTURE OF SEOUL, KOREA",  "소장처별", "년도", new List<string> {" 서울, 탱크, 군용차, 자동차, 송수화기, 신문, 행군, 타자기, 바리게이트, 불, 환자, 사격"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한강을 건넘, 제1 미해병대 사단, 한국 HAN RIVER CROSSING US 1ST MARINE DIVISION, KOREA",  "소장처별", "년도", new List<string> {" 군용트럭, 기관총, 탱크, 강, 고무보트, 불도저, 보트, 군용차, 깃발, 부상"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한강을 건넘, 제1 미해병대 사단, 한국 HAN RIVER CROSSING, US 1ST MARINE DIVISION, KOREA",  "소장처별", "년도", new List<string> {" 탱크, 군용트럭, 고무보트, 연기, 포로, 환자, 행군, 사격, 깃발"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한국의 서울로 향하는 해병대 Marines on way to Seoul, Korea",  "소장처별", "년도", new List<string> {" 연기, 불, 기관총, 사격, 군용기, 탱크, 부교, 열차, 행군, 부상, 태극기, 헬리콥터, 사격"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "제9 육군 기갑 연대, 낙동강, 한국 ARMY 9TH REGT CP, NAKTONG RIVER, KOREA",  "소장처별", "년도", new List<string> {" 브리핑, 회의, 탱크, 천막, 군용트럭, 헬리콥터, 환자, 소형포, 취사, 통조림"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
       
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "미육군 활동, 제1 기갑 부대, 왜관, 한국 US ARMY ACTIVITIES, 1ST CAV, WAEGWAN, KOREA",  "소장처별", "년도", new List<string> {" 다리, 강, 대포, 포격, 전투기, 연기, 항공뷰, 군용차, 군용기"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한국 전쟁, 포항, 한국 KOREAN WAR, POHANG, KOREA",  "소장처별", "년도", new List<string> {" 보트, 안내문, 선박, 통신 장비, 길거리, 군용트럭"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "전쟁, 수원, 한국 WAR, SUWON, KOREA",  "소장처별", "년도", new List<string> {" 군용트럭, 위장, 군수품, 군용기, 불, 포로, 행군, 통신기, 열차"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "인천 작전, 한국 OPERATIONS AT INCHON, KOREA",  "소장처별", "년도", new List<string> {" 미해군. 콜렛 (구축함). 5/16/1944-9/18/1947, 구축함 (군함), 항구, 상륙용 주정, 침입, 둑길"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "'Big Switch'작전, 자유의 마을, 한국 Operation, 'Big Switch', Freedom Village, Korea",  "소장처별", "년도", new List<string> {" 전쟁 포로,  Big Switch 작전, 1953 "}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "'Big Switch'작전, 자유의 마을, 한국 Operation, 'Big Switch', Freedom Village, Korea",  "소장처별", "년도", new List<string> {" 전쟁 포로,  Big Switch 작전, 1953 "}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "'Big Switch'작전, 자유의 마을, 한국 Operation, 'Big Switch', Freedom Village, Korea",  "소장처별", "년도", new List<string> {" 인터뷰, 전쟁 포로, 레크레이션, Big Switch 작전, 1953 "}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "'BIG SWITCH'작전, 자유의 마을/문산, 한국 OPERATION, 'BIG SWITCH' Freedom Village/Munsan, Korea",  "소장처별", "년도", new List<string> {" 인터뷰, 해병대, 전쟁포로, 군인, Big Switch 작전, 1953, 까치, 종군 기자, 대중"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "SP-1 전쟁 포로, 부산, 한국 SP-1 PRISONERS OF WAR, PUSAN, KOREA",  "소장처별", "년도", new List<string> {" 전쟁포로,  부상, 적십자, 이발, 군수품, 환복, 소독, 취사, 가마솥, 군식당"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "오스트레일리아 병력과 캐나다 'PRINCESS PAT' 여단, 한국; 'PRINCESS PAT' 캐나다 병력 AUSTRALIAN TROOPS AND CANADIAN 'PRINCESS PAT' REGIMENT, KOREA ; 'PRINCESS PAT' CANADIAN TROOPS",  "소장처별", "년도", new List<string> {" 탱크, 부교, 군용차, 군용트럭, 방화, 면도, 빨래, 통조림, 강, 보트"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "미국 해병대와, 제7 여단, 제1사단, 인제, 한국 WITH THE US MARINES, 7TH REGIMENT, 1ST DIVISION, INJE, KOREA",  "소장처별", "년도", new List<string> {" 탱크, 행군, 폭파, 사격, 기관총, 산, 쌍안경"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한국에 매슈 B 리즈웨이 장군, 서울 ; 방어, 서울 지역, 한국 GEN MATTHEW B RIDGWAY IN KOREA, SEOUL ; DEFENSE, SEOUL AREA, KOREA",  "소장처별", "년도", new List<string> {" 군용차, 사진사, 피난민, 나룻배, 강, 취식, 통조림, 하모니카, 전봇대, 전선, 길거리"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "캐나다 유엔 병력, 밀양, 한국 ; 습식 주행 기술, 캐나다 유엔 군, 밀양 CANADIAN UN TROOPS, MIRYANG, KOREA ; WET RUN MANEUVERS, CANADIAN UN FORCES, MIRYANG",  "소장처별", "년도", new List<string> {" 텐트, 박격포, 위문편지, 바주카, 군용트럭, 배식, 행군, 신부, 예배"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한국 전쟁, 의정부 ; 피난민, 부산, 한국 ; 퇴각, 흥남 지역, 한국, 보쿠도(BOKU-DO) KOREAN WAR, UIJONGBU ; REFUGEES, PUSAN, KOREA ; EVACUATION, HUNGNAM AREA, KOREA, BOKU-DO",  "소장처별", "년도", new List<string> {" 포탄, 소, 위장, 피난민, 지뢰탐지기, 선박, 보트, 기병, 말, 탱크, 부두"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "제7 여단과, 제1 해병대 사단이 함흥 남부로 진격하다 ,한국 WITH THE 7TH REGT, 1ST MARINE DIV DRIVING NORTH OF HAMHUNG, KOREA",  "소장처별", "년도", new List<string> {" 통조림, 행군, 군용트럭, 비행기, 불, 연기, 소화, 탱크, 전쟁포로, 선박, 통신기"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한국 전쟁, 제1 해병대 사단과, 코조, 한국 KOREAN WAR, WITH THE FIRST MARINE DIVISION, KOJO, KOREA",  "소장처별", "년도", new List<string> {" 행군, 폐허, 화재, 전함, 헬리콥터, 군용차, 텐트, 대공포, 포격, 이발"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  " 한국 앞 바다에서미국해군전함 밸리 포지 (CV 45) 탑승 공중 작전 AIR OPERATIONS ABOARD USS VALLEY FORGE (CV 45) AT SEA OFF KOREA",  "소장처별", "년도", new List<string> {" 활주로, 군용기, 전투기, 포탄, 쌍안경, 탄약, 헬리콥터"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  " 한국 앞 바다에서미국해군전함 밸리 포지 (CV 45) 탑승 공중 작전 AIR OPERATIONS ABOARD USS VALLEY FORGE (CV 45) AT SEA OFF KOREA",  "소장처별", "년도", new List<string> {" 군용기전투기, 헬리콥터, 전함, 활주로"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "전투기 조종사와 T-6 (MOSQUITO 정찰기) 대구, 한국 FIGHTER CONTROL AND T-6 (MOSQUITO SPOTTER PLANES) TAEGU, KOREA",  "소장처별", "년도", new List<string> {" 활주로, 군용기, 항공뷰, 탄약, 포탄, 군용트럭, 귀순병 환영"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한국 전쟁, 평양, 한국 ; 한국 전쟁 ; 정수 지점, 한국 KOREAN WAR, PYONGYONG, KOREA ; KOREAN WAR ; WATER PURIFICATION POINT, KOREA",  "소장처별", "년도", new List<string> {" 군용차, 천막, 회의, 송수화기, 지뢰, 길거리, 대포, 포격, 군용트럭, 기관총"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한국 전쟁 ; 조치원, 한국, 제63 FA ; 한국 전쟁, 대전 KOREAN WAR ; ZOCZIWON, KOREA, 63RD FA ; KOREAN WAR, TAEJON",  "소장처별", "년도", new List<string> {" 열차, 군용차, 수레, 군용트럭, 기관총, 시민, 대포, 취사, 통조림, 행군, 지뢰, 비행기, 군수품, 탄약"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "전쟁포로 [POW, 한국] 활동, 거제도, 한국 Prisoner of War [POW, Korean] Activities, Koje-Do, Korea",  "소장처별", "년도", new List<string> {" 라켓, 글러브, 세면대, 회의, 배식"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "후퇴, 의정부, 한국 ; 전투 사진가, 북위 38도 ; 전투 사진가, 의정부, 한국 ; 후퇴, 의정부 RETREAT, UIJONGBU, KOREA ; COMBAT PHOTOGRAPHERS, 38TH PARALLEL ; COMBAT PHOTOGRAPHERS, UIJONGBU, KOREA ; RETREAT, UIJONGBU",  "소장처별", "년도", new List<string> {" 피난민, 탱크, 포격, 대공포, 송수화기, 군용트럭, 철로, 행군"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "제임스 A 밴 플리트 중장, 제3 사단, POAN-NIE, 한국 ; 유엔 부대, 영국과 벨기에, 북위 38도 LT GEN JAMES A VAN FLEET, 3RD DIV, POAN-NIE, KOREA ; UN TROOPS, BRITISH AND BELGIUM, 38TH PARALLEL",  "소장처별", "년도", new List<string> {" 군용기, 군용차, 보트, 취사, 행군, 박격포, 탱크, 노동자"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "제 27 여단 (울프하운드) ,제65연대, 서울의 5 MI N, 한국 ; 리즈웨이가 I  군단지역을 방문하다, 한국 65TH RCT AND 27TH (WOLFHOUNDS) 5 MI N OF SEOUL, KOREA ; RIDGWAY VISITS I CORPS AREA, KOREA",  "소장처별", "년도", new List<string> {" 참호, 사격, 전투기 , 포격, 연기, 기관총, 비행기, 군용차"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "화천, 한국 북동쪽 15마일 지점의 포병대를 위한 항공 작전 ; 무산에 공중투하, 한국 AERIAL OBSERVATION FOR ARTILLERY 15 MILES NORTHEAST OF HWACHON, KOREA ; PARADROP AT MUNSAN, KOREA",  "소장처별", "년도", new List<string> {" 탱크, 포격, 송수화기, 군용기, 항공뷰, 지도, 공중보급"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "거제도에 PW 건설, 부산 남쪽 약 60마일 지점, 한국 PW CONSTRUCTION ON KOJE-DO ISLAND, ABOUT 60 MILES SOUTH OF PUSAN, KOREA",  "소장처별", "년도", new List<string> {" 불도저, 목재, 공사, 폭발, 취사, 가마솥 "}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "제24 사단의 제 19, 21 여단이 철의 삼각지대 선봉에 서다 THE 19TH AND 21ST REGIMENTS OF THE 24TH DIVISION SPEARHEAD INTO IRON TRIANGLE, KOREA",  "소장처별", "년도", new List<string> {" 폭발, 연기, 군용트럭, 탱크"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "후퇴, 중서부 한국 ; 제임스 A 밴 플리트 중장 그리스군 방문, 한국 RETREAT, WEST CENTRAL KOREA ; LT GEN JAMES A VAN FLEET VISITING GREEKS, SEOUL, KOREA",  "소장처별", "년도", new List<string> {" 피난민, 군용차, 폐허, 지뢰, 철조망"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한국군 제1사단, 서울의 미사일경사거리(MSR)에 24 MI N, 한국 ; 임진강 건넘,  1ST ROK DIVISION, 24 MI N OF SEOUL ON MSR, KOREA ; IMJIN RIVER CROSSING, 1ST ROK DIVISION",  "소장처별", "년도", new List<string> {" 이발, 물, 탱크, 송수화기, 호루라기, 박격포, 포격"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "704 언덕 이야기, 인천 북부, 한국 ; 언덕 공격, 인천, 한국 STORY OF HILL 704, N. OF INCHON, KOREA ; ATTACK ON HILL 584, INCHON, KOREA",  "소장처별", "년도", new List<string> {" 포격, 박격포, 노동자, 산, 사격"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한국에 미국 해병대 제 1사단(제1 여단), 안동, 'A' 부대장(CO) 제1 탱크 부대 WITH THE US MARINE'S 1ST DIV (1ST REGT) IN KOREA, ANDONG, 'A' CO 1ST TANK BN",  "소장처별", "년도", new List<string> {" 포, 기관총, 탱크, 비행기, 군용차, 행진, 군용기, 송수화기, 불도저"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
      
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한국에 미국 해병대 제1 사단과, 찬동과 , 찬동 북부(N), 한국; 장날 WITH THE US MARINE'S 1ST DIV IN KOREA, CHON-DONG AND N OF CHON-DONG, KOREA ; MARKET DAY",  "소장처별", "년도", new List<string> {" 대포, 군용트럭, 시장, 상인, 미제물건, 말, 운반, 노동자, 기관총"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한국 전쟁, 안양, 한국 ; 한국 전쟁, 전방에 메슈 B 리즈웨이 장군, 인천 KOREAN WAR, ANYANG, KOREA ; KOREAN WAR, GEN MATTHEW B RIDGWAY AT THE FRONT, INCHON",  "소장처별", "년도", new List<string> {" 연기, 참호, 탱크, 대포, 포격, 카메라, 군용차, 행군"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "남아프리카 공군 (날으는 치타 비행함대) 수원, 한국 ; 흥남 철수 (수중폭파반), 한국 SOUTH AFRICAN AIR FORCE (FLYING CHEETEA SQADRON) SUWON, KOREA ; EVACUATION OF HUNGNAM (UNDERWATER DEMOLITION TEAM), KOREA",  "소장처별", "년도", new List<string> {" 전투기, 물자, 선박, 보트"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한국에 F-86', 김포 ; NK ; F-80s 겨울 장면, 김포, 한국 ; B-26 임무, CJONGNE,북한 F-86'S IN KOREA, KIMPO ; NK ; WINTER SCENES F-80s, KIMPO, KOREA ; B-26 MISSION, CJONGNE, N KOREA",  "소장처별", "년도", new List<string> {" 전투기, 탄약, 항공뷰, 활주로, 연기"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "첫번째 해병대 철수,제1 해병대 사단. 장진호 지역으로부터, 코토 리, 한국 WITHDRAWAL FIRST MARINES, 1ST MARINE DIV. FROM CHOSIN RESERVOIR AREA, KOTO-RI, KOREA",  "소장처별", "년도", new List<string> {" 천막, 불, 군용트럭, 탱크, 행군"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "더글라스 맥아더 장군이 활주로와 부상 대피 GEN DOUGLAS MAC ARTHUS ARRIVING AT YONGPO AIRSTRIP AND EVAC OF WOUNDED, KOREA ; TURKISH TROOPS AND REFUGEES, PYONGYANG AIRSTRIP",  "소장처별", "년도", new List<string> {" 비행기, 활주로, 트럭, 환자, 소형 화기, 군중, 고문, 피난민, 보트, 군용차, 군용트럭"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한국전쟁, 평양, 한국전쟁, 순천, 터키인 평양, 싱량을 민간이들에게주다. KOREAN WAR, PYONGYANG, KOREA ; KOREAN WAR, SUNCHON ; TURKS, PYONGYANG ; FLOUR AND BARLEY ARE GIVEN TO THE PEOPLE, HUNGNAM",  "소장처별", "년도", new List<string> {" 군악대, 깃발, 행진, 피난민, 철로, 군용트럭, 탱크, 군용차, 휴식, 교통정리, 배급"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "제 9 군단직할부대 철수, 한국,  SINOYE 부근 ; 'C' 포대, 제82 포병대, 155MM 곡사포, 제1기갑 사단., 시변리 WITHDRAWAL OF IX CORPS TROOPS, KOREA, VICINITY OF SINOYE ; 'C' BATTERY, 82ND ARTILLERY, 155MM HOWITZER, 1ST CAV. DIV., SIBYON-NI",  "소장처별", "년도", new List<string> {" 대포, 포격, 책상, 군용차, 항공뷰, 연기"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한강을 건너는 피난민, 그리스 병력의 도착,  REFUGEES CROSS HAN RIVER, SEOUL, KOREA ; NEWLY ARRIVED GREEK TROOPS, SUWON, KOREA ; 2ND BATTALION, 187TH RCT. AREA, SUWON",  "소장처별", "년도", new List<string> {" 피난민, 배식, 행군, 체조, 광고지, 텐트, 열차, 주사위, 내기, 이발, 신문"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "원산 해변 상륙, 원산, 한국 ; 수중해체팀 ; 원산 해변에서 LANDING AT WONSAN BEACH, WONSAN, KOREA ; UNDERWATER DEMOLITION TEAMS ; ON THE BEACH AT WONSAN",  "소장처별", "년도", new List<string> {" 전함, 고무보트, 수중복, 보트, 기중기, 트럭, 헬리콥터"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "대전의 폐허; 잔혹 행위; 적장비,45MM 총,전몰 전우를 위한 카톨릭 미사, KOREAN WAR, RUINS OF TAEJON ; ATROCITIES ; ENEMY EQUIPMENT, 45MM GUN, KOREA ; KOREAN WAR, CATHOLIC SERVICES FOR FALLEN COMRADES, KIMPO",  "소장처별", "년도", new List<string> {" 폐허, 시신, 예배, 신부, 묘지"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한국 전쟁. 김포 공항, 인천, 한국 ; 제32 여단, 제7 사단, 제 KOREAN WAR. KIMPO AIRFIELD, INCHON, KOREA ; 32ND REFT, 7TH DIV, REPLACING 1ST DIV MARINES, INCHON",  "소장처별", "년도", new List<string> {" 비행기, 연설, 사진사, 행군, 군용차, 군중, 태극기, 참호, 쌍안경"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "미국해군전함 밸리 포지 (CV45) 탑승 공중 작전;인천에서의 활동(침입), AIR OPERATIONS ABOARD USS VALLEY FORGE (CV 45) AT SEA OFF KOREA ; ACTIVITIES IN INCHON HARBOR (INVASION), KOREA",  "소장처별", "년도", new List<string> {" 폐허, 전함, 포격, 환자, 연기, 탱크, 포탄, 시신"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한국에 대한 미국 해군 전함의 공중 공격 항공 영상 AERIAL MOTION PICTURES OF NAVY AERIAL STRIKES OVER KOREA FROM USS VALLEY FORGE",  "소장처별", "년도", new List<string> {" 전투기, 항공뷰, 연기"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한국 전쟁. 남한 훈련생, 대구 ; 남한 신병 ; 제 35 여단 사령부에 콜린스 장군, KOREAN WAR. SOUTH KOREAN TRAINEES, TAEGU ; SOUTH KOREAN RECRUITS ; GENERAL COLLINS AT 35TH REGIMENT CP, KOREA",  "소장처별", "년도", new List<string> {" 신체검사, 군용차, 회의, 훈련, 행군, 소형 화기"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "B-29 이 북한을 습격한다, ; B-29s,북한에 대한 기습 공격 B-29 RAID OVER NORTH KOREA, (BOMB DROP ON FRONTLINE TROOPS SUPPORT MISSION) ; B-29s, FEAF RAIDS ON NORTH KOREA",  "소장처별", "년도", new List<string> {" 폭격기, 폭격, 포탄, 항공뷰"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "212_대구 ; 군식당,; 롤 샐러드 '카터' ; 마산 전선의 전쟁 ;아킨 장군, 도쿄,일본 KOREAN WAR. TAEGU ; MESS HALL, KOREA ; ROLL SLATED 'CARTER' ; WAR ON MASAN FRONT ; GENERAL AKIN, TOKYO, JAPAN",  "소장처별", "년도", new List<string> {" 군악대, 길거리, 열차, 선박 선원, 화재, 환자, 비행기, 초가집, 포탄, 군용차, 군용트럭, 참호, 지뢰탐지기"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "안동; 크레이그 준장 소총 부대 인원을 인터뷰, 한국 마산에 통신센터 설치하다 KOREAN WAR, ANDONG ; BRIG GEN CRAIG INTERVIEWS MEMBERS OF RIFLE SQUAD AND SETTING UP COMMUNICATIONS CENTER AT CP, MASAN, KOREA",  "소장처별", "년도", new List<string> {" 노동자, 화재, 행군, 통신장비, 전봇대, 전선, 헬리콥터"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "미국해군전함 산디아오의 조지 클라이머와 , 한국으로 가는 도중 (제2 대대, 제5 해병대) The USS George Clymer at San Diego, California, and en route to Korea (2nd Batallion, 5th Marines)",  "소장처별", "년도", new List<string> {" 해군성. 1798-9/18/1947, 해군성. 바등 해협 (함모를 호위). 11/14/1945-9/18/1947, 국방부 해군성. 미국 해병대. 9/18/1947-, 화물선, 헬리콥터, 한국 전쟁, 1950-1953 "}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한국 영토에 선전 전단을 뿌리다 (제5 공군) ; 제5 공군 기지에서 한국 전쟁, 일본 THROWING PROPAGANDA LEAFLETS OVER KOREA TERRITORY (5TH AIR FORCE) ; KOREAN WAR AT THE 5TH AIR FORCE BASE, JAPAN",  "소장처별", "년도", new List<string> {" 조종석, 항공뷰, 전단, 비행기, 군용기, 포탄, 탄약, 군용트럭, 자동차"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한국 전쟁 (카톨릭 미사), 대전, 한국 ; 개신교 예배 ; 한국전쟁, 대전, 한국; 한국 전쟁 KOREAN WAR (CATHOLIC MASS), TAEJON, KOREA ; PROTESTANT SERVICES ; KOREAN WAR, TAEJON, KOREA ; KOREAN WAR",  "소장처별", "년도", new List<string> {" 교회, 예배, 신부, 광장, 소형 화기, 철로, 열차, 기관총, 폐허, 군용차, 군용트럭, 전쟁포로, 헌병대"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "탱크의 활약, 'A' CO., 제140 탱크 부대, 제40 사단, 한국 TANKS IN ACTION, 'A' CO., 140TH TANK BN, 40TH DIV, KOREA",  "소장처별", "년도", new List<string> {" 탱크, 포격, 연기, 포탄, 통신"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "제3 대대, 제19th 보병 연대, 한국, 서울 지역 ; 유엔 병력 철수, 서울 지역 3rd Batallion, 19th Infantry Regiment, Korea, Seoul Area ; Evacuation of UN Troops, Seoul Area",  "소장처별", "년도", new List<string> {" 행군, 송수신기, 군용트럭, 탱크, 화재, 연기, 부교, 기자재"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "F-80 ; 압록강 항공뷰, 한국(CAG)No.3항공기; 한국을 위한 혈액, 도쿄에서 평양, 북한 F-80'S OVER KOREA GASP ; AERIAL VIEWS OF STRIKE MISSIONS OVER YALU RIVER, KOREA BY CAG No. 3 AIRCRAFT ; BLOOD FOR KOREA, FROM TOKYO TO PYONGYANG, N. KOREA",  "소장처별", "년도", new List<string> {" 항공뷰, 포격, 대공 사격, 연기, 군용기, 군용트럭"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "제7 사단, 언기 강 부근 ; 미국 해병대, 울산 바깥의 해병1시단; 유엔이 공격을 시작하다,  KOREAN WAR, 7TH DIV, VICINITY UNGI RIVER ; US MARINES, FOX CO, 1ST MARINE DIV OUTSIDE OF WONSON ; UN JUMP OFF, KOREA",  "소장처별", "년도", new List<string> {" 항공뷰, 비행기, 사진사, 군용차, 천막, 행군, 탱크, 사격, 포격"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "제5 기갑 연대., 제1 기병 사단, 반격, 가평, 한국 ; 한국군1사단. ; CU,  5TH CAVALRY REGT., 1ST CAV. DIV., COUNTERATTACK, KAP YONG, KOREA ; 1ST ROK DIV. ; CU, ROK, 5TH CAVALRY REGT., 1ST CAV. DIV., COUNTERATTACK, KAP YONG, KOREA",  "소장처별", "년도", new List<string> {" 쌍안경, 기관총, 사격, 탱크, 포격, 박격포, 행군, 송수화기"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "티비에 나오는 자유 무역항 선원의 정신, 자유무역함 ; 미국해군전함 재취역, SPIRIT OF FREEPORT CREW ON TV, NEW YORK AND FREEPORT ; RECOMMISSION USS NEW JERSEY, BAYONNE, NJ ; CHURCH SERVICE, HYESANJIN, KOREA ; MANCHURIAN BORDER",  "소장처별", "년도", new List<string> {" 카메라, 함대, 부두, 군중, 연설, 자동차, 군사제, 비행기"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));

        
       

        saveData.Data0.Add(new Datajson("기록영상", 1949,  "에드워드 아몰드 장군의 진급, 청주,  ; 더글라스 맥아더 김포,제35연대 순찰,영등포, GEN EDWARD M ALMOND'S PROMOTION, CHUNGJU, KOREA ; GEN DOUGLAS MAC ARTHUR PRESENTATION, KIMPO, KOREA ; 35TH REGT CO PATROL, YONGDONGPO, KOREA",  "소장처별", "년도", new List<string> {" 자동차, 군용차, 깃발, 수여식, 쌍안경, 통신기, 연기, 밭 "}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "이탈리아 해군을 호위하는 구축함, 버지니아 ; 스웨덴 간호사 ; 캐나다 여단이 떠나다 TRANSFER OF THREE DESTROYER ESCORTS TO ITALIAN NAVY, NORFOLK, VIRGINIA ; SWEDISH NURSES (IN KOREA) ; CANADA'S SPECIAL BRIGADE DEPARTS! MANY FOR KOREA",  "소장처별", "년도", new List<string> {" 군악대, 연설, 깃발, 선박, 천막, 환자, 행군, 열차"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "유엔군 서울로 진격하다, 수원 남부 10 마일, 한국 ;  수원 남부 4-1/2 마일, 한국 ; 맥아더 장군,  UN TROOPS ADVANCE TOWARD SEOUL, 10 MILES NORTH OF SUWON, KOREA ; UN TROOPS ADVANCE TOWARD SEOUL, 4-1/2 MILES NORTH OF SUWON, KOREA ; GEN. MACARTHUR, SUWON KOREA",  "소장처별", "년도", new List<string> {" 강, 부교, 군용트럭, 배급, 책상, 쌀, 군중"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "크리스마스, ; 피난민, 크리스마스 트리, 서울, 리즈웨이 장군, 특수 근무, CHRISTMAS, KOREA ; REFUGEES, SEOUL ; LABORERS ; GEN MILBURN, SEOUL ; CHRISTMAS TREE, SEOUL ; TWO MEN OF THE 24TH INF DIV RECEIVE CHRISTMAS GIFTS, KOREA ; GEN RIDGWAY, NEW CG, SEOUL ; SPECIAL SERVICES, TAEGU",  "소장처별", "년도", new List<string> {" 군용차, 배식, 닭고기, 피난민, 강, 다리, 군용트럭, 크리스마스 트리, 기관총, 비행기, 활주로, 특수가방"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "제1 해병대 철수, 흥남, 한국 ; 제1 해병대 철수, 하가루 리에서 함흥으로, 장진호 철수 Withdrawal of 1st Marine, Hamhung, Korea ; Withdrawal of 1st Marines, Hagaru-re to Hamhung, North Korea, withdrawal from Chosin Reservoir Area",  "소장처별", "년도", new List<string> {" 군용트럭, 행군, 탱크, 천막, 군용차, 피난민"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "풍기 한국군 8사단 붙잡힌 NK 포로; 신호 구축 ; 사망 확인, 대전 ; 귀향 왜관 KOREAN WAR: NK PRISONERS TAKEN BY 8TH ROK DIV NEAR PUNGGI ; 3RD ROK VID, NORTH OF HANGNUNG ; SIGNAL CONSTRUCTION DUTIES, TAEGU ; IDENTIFICATION OF DEAD, TAEJON ; REFUGEES RETURNING HOME, WAEGWAN, KOREA",  "소장처별", "년도", new List<string> {" 포로, 행군, 군용차, 초가집, 태극기, 한국인, 전봇대, 전선, 피난민, 소, 철로"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "인천 ; O P 스미스 소장, 해병1사단 도시를 남한에게 넘기다 ; 국회의사당 ; 김포공항 KOREAN WAR. INCHON ; MAJ GEN O P SMITH, 1ST MARINE DIV TRUNING OVER CITY TO S K OFFICIALS ; CAPITOL BUILDING, SEOUL, KOREA ; KIMPO AIRFIELD",  "소장처별", "년도", new List<string> {" 보트, 환자, 인천, 태극기, 연설, 수여식, 탱크, 군용차, 군용기, 김포, 포탄, 국회의사당"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "미국해군전함 미주리 탑승 (한국 해안에서 모의 도착) ; '빅 모' 탑승, 진주만, ABOARD THE USS MISSOURI AT SEA (SIMULATED ARRIVAL OFF COAST OF KOREA) ; ABOARD THE 'BIG MO', PEARL HARBOR, TH AND AT SEA",  "소장처별", "년도", new List<string> {" 전함, 포격, 헬리콥터, 선원, 깃발, 레이더, 유엔 깃발"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한국 육사, 부산 ; 제24 보병 여단의 LIASON 비행기. ;  중박격포. 제5 기갑연대. 기갑 1사단 KOREAN ARMY GROUND SCHOOL (OCS), PUSAN ; LIASON PLANES OF 24TH INF. DIV., KYONGJU, KOREA ; HEAVY MORTAR CO. 5TH CAV. REGT., 1ST CAV. DIV.",  "소장처별", "년도", new List<string> {" 운동장, 시범, 발포, 사격 , 군용기, 항공뷰, 이발"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "극동 공군, 오키나와; C-119 , 제314 전투 화물 날개, 일본에서 김포,한국;이타즈케,일본 FAR EAST AIR FORCE, OKINAWA, RYUKYUS ISLANDS ; ABOARD C-119, 314TH COMBAT CARGO WING FROM ASHIYA AB, JAPAN TO KIMPO AB, KOREA ; AT ITAZUKE, JAPAN",  "소장처별", "년도", new List<string> {" 비행기,활주로,항공뷰,군용트럭,김포 공항, 환자, 적십자"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "엘런 스미스 한국 부대에 훈장 수여 이승대통령에게 훈장받다,; 리즈웨이, 오키나와 US ADM ALLAN E SMITH DECORATES KOREAN TROOPS AND RECEIVES DECORATION FROM PRES RHEE, CHINHAE, KOREA ; US ADM ALLAN E SMITH DECORATES KOREAN TROOPS AND RECEIVES DECORATION FROM PRES RHEE, CHINHAE (?), KOREA ; ARRIVAL OF LT GEN MATTHEW B RIDGWAY, OKINAWA",  "소장처별", "년도", new List<string> {" 수여식, 연설, 행진, 군악대, 깃발, 비행기, 자동차"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "프랭크 밀번 소장, I 군단, 안양,81MM 박격포 ; 제187연대, ; 제35 보병. 한강으로 향하다, MAJ. GEN. FRANK W. MILBURN, CG, I CORPS, ANYANG, KOREA ; NEW TYPE 81MM MORTAR, ANYANG ; 187TH REGIMENTAL COMBAT TEAM, KOREA ; 35TH INF. GOES TO THE HAN, YONGDONGPO ; ROKs AND 89TH TANK IN FIGHT, YONGDONGPO",  "소장처별", "년도", new List<string> {" 박격포, 행군, 기관총, 사격, 북한, 인공기, 한강, 다리, 전쟁포로, 탱크"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "리지웨이, 양평 ; , 흥남 ; 주한 군사 고문단,; 24 사단,; 레벤 C 엘런 소장, 대구, 서울,  GEN MATTHEW B RIDGWAY, YONGPYANG, KOREA ; EVACUATION, HUNGNAM ; KMAG, MUNSAN, KOREA ; LT GEN MATTHEW B RIDGWAY, 24TH DIV, KOREA ; MAJ GEN LEVEN C ALLEN, TAEGU, KOREA ; LT GEN MATTHEW B RIDGWAY, LOCATION UNKNOWN ; SEOUL, KOREA",  "소장처별", "년도", new List<string> {" 군용기, 군악대, 보트, 부두, 깃발, 선박, 비행기, 군용차, 천막, 사진사"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "마셜 국방장관 북대서양 국방위원회 제4차 개회식,; 한국 아몬드 장군에 경의 SECRETARY OF DEFENSE GEORGE C MARSHALL'S ADDRESS AT OPENING OF FOURTH MEETING OF THE NORTH ATLANTIC DEFENSE COMMITTEE, DEPARTMENTAL AUDITORIUM, WASHINGTON, D.C. ; KOREANS PAY TRIBUTE TO GEN EDWARD M ALMOND, HAMHUNG, KOREA",  "소장처별", "년도", new List<string> {" 자동차, 회의, 행렬, 태극기, 유엔국기, 연설, 군중, 군용기, 군악대"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "압록강 댐 공격 YALU RIVER DAM STRIKES",  "소장처별", "년도", new List<string> {" 압록 지앙강 (중국과 한국), 해군성. 복서 (항공모함). 4/16/1945-9/18/1947, 비행기, 카메라, 군기지"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "티본 고지에 대한 에어그라운드 공격 AIR-GROUND STRIKE ON T-BONE HILL",  "소장처별", "년도", new List<string> {" 공군 이등병, 공중 폭격, 위장(군사학), 전투, 회담, 발포, 군항공기, 탱크 (군사학), 샌드백, 계곡, 기관총, 포병"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "미국해군전함 컨솔레이션(AH-15) 부상자 헬리콥터 피난 HELICOPTER EVACUATION OF WOUNDED TO USS CONSOLATION (AH-15)",  "소장처별", "년도", new List<string> {" 아프리카계 미국인, 항공 조종사, 앰뷸런스, 헬리콥터, 전쟁 상해, 군병원, 병과 부상에 대한 전시구조, 군 헬리콥터, 경비대"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "B-29 폭격 B-29 Bomb Strike",  "소장처별", "년도", new List<string> {" 한국, B-29 폭격기"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "제1 해병 사단 시상 수여 (PROJ. 86-5 PRESENTATION OF AWARDS 1ST MARINE DIVISION (PROJ. 86-5",  "소장처별", "년도", new List<string> {" 판문점(한국), 의회와 협약, 해병대, 육군 장교, 경비대, 퍼플 하트, 실버 스타(medal) "}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "104번 전투 단신 : 한국 전쟁 Combat Bulletin Number 104 : Korean War",  "소장처별", "년도", new List<string> {" 군용차, 행진, 환자, 비행기, 공중보급, 군용기, 헬리콥터, 적십자, 도쿄군병원, 화물실 분리식 수송기"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "미국해군전함 프린스턴 (CV-37) 차단폭격 INTERDICTION BOMBING USS PRINCETON (CV-37)",  "소장처별", "년도", new List<string> {" 국방부. 해군성. 프린스턴 (항공모함). 9/18/1947-3/2/1959, 비행기, 탄약, 폭탄, 로켓 (대포), 선박"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "사진총 푸티지 MIG Kills Gun Camera Footage of MIG Kills",  "소장처별", "년도", new List<string> {" 항공뷰, 포격, 포격, 비행기"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "미국해군전함 필리핀 파다 (CV-47)에서 비행기 이륙; 비행기 대형; 기동 부대 PLANE TAKE-OFFS FROM THE USS PHILIPPINE SEA (CV-47); PLANE FORMATIONS; TASK FORCE",  "소장처별", "년도", new List<string> {" 해군성. 필리핀 바다 (항공모함). 5/11/1946-9/18/1947, 비행기, 대공포, 강, 군 기동부대, 폭풍 해일"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "군사 묘지 MILITARY CEMETERY",  "소장처별", "년도", new List<string> {" 군사묘지, 행진, 군트럭, 탱크, 선박, 보트"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "장진호 전투 그들 방식대로 싸운 후 수송선상 제1해병사단의 제5, 제7 연대의 잔유 REMNANTS OF THE 5TH AND 7TH REGIMENTS OF THE FIRST MARINE DIVISION ABOARD TRANSPORTS, AFTER FIGHTING THEIR WAY FROM CHOSIN RESERVOIR",  "소장처별", "년도", new List<string> {" 선박, 군용트럭, 철로, 탱크, 자동차"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "미국해군전함 프린스턴 (CV-37) 차단폭격 INTERDICTION BOMBING USS PRINCETON (CV-37)",  "소장처별", "년도", new List<string> {" 국방부 해군성 프린스턴(항공모함). 9/18/1947-3/2/1959, 지도, 항공 조종사, 항공모함, 비행기, 전함, 카메라, 구축함 (군함), 해군 장교, 선박"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "전쟁의 하루 ONE DAY OF WAR",  "소장처별", "년도", new List<string> {" 국방부 육군성. 미육군 워싱턴 군관구. 미육군 군악대. 7/1/1971-, 밴드 (음악), 퍼레이드, 철로, 선박, 군인, 트럭, 영국인, 지프차"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "포로 심문, 한국군8군단, CP INTERROGATION OF PRISONER, 8TH ROK DIV, CP",  "소장처별", "년도", new List<string> {" 전쟁포로, 지도, 대포, 포격, 송수화기, 기관총, 사격"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "기념일 광경, 제1 연대, 제1 해병사단 ANNIVERSARY SCENES, 1ST REGT, 1ST MARINE DIV",  "소장처별", "년도", new List<string> {" 양강도(한국), 불도저, 카드게임, 탱크, 이발, 환자, 빨래, 사격, 화재진화, 군행사"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "후퇴 EVACUATION",  "소장처별", "년도", new List<string> {" 영포(한국), 항공뷰, 비행기, 환자, 트럭, 이륙, 착륙 "}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "대포 폭발 477고지 ARTILLERY BLASTING HILL NO 477",  "소장처별", "년도", new List<string> {" 산, 연기, 소형화기, 참호, 들판, 카드게임"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "필리핀 부대 PHILLIPINE TROOPS",  "소장처별", "년도", new List<string> {" 창원(한국), 차량정비, 천막, 집합, 행진, 군악대, 군사제, 사진사, 카드게임"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한국군 8군단 한국 대통령 부대표장을 받다,한국군8군단CP EIGHTH ROK RECEIVES KOREAN PRESIDENTIAL UNIT CITATION, EIGHTH ROK CP",  "소장처별", "년도", new List<string> {" 태극기 , 군악단, 군용기, 사진사, 수여식, 상장, 수색, 전쟁포로"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "흥남 이야기 THE HUNGNAM STORY",  "소장처별", "년도", new List<string> {" 휴식, 전투기, 행군, 바주카, 동상, 군용차, 송수화기, 폭격, 폭발, 활주로, 탱크"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "중국인에게 살해당한 미국 포로 US PRISONERS KILLED BY CHINESE",  "소장처별", "년도", new List<string> {" 춘천(한국), 탱크, 사격, 군용트럭, 피난민, 포격, 기관총, 전쟁포로, 수색, 통조림"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "항공 철수 AIR EVACUATION",  "소장처별", "년도", new List<string> {" 흥남시(한국), 비행기, 군용트럭, 출항, 폭발, 연기, 불, 선박, 노숙, 피난민"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "평화 회담 PEACE TALKS",  "소장처별", "년도", new List<string> {" 판문점(한국), 군용차, 천막, 사진사, 영상촬영기사, 자동차, 헬리콥터, 착륙, 전봇대, 배전기사"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "휴전 협상 회담 CEASE-FIRE TALKS",  "소장처별", "년도", new List<string> {" 한국, 자동차, 헬리콥터, 사진촬영, 군용차, 방문"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "'평화를 위한 파트너십' 'PARTNERSHIP FOR PEACE'",  "소장처별", "년도", new List<string> {" 북한, 군용차, 열차, 비행기,보트, 태극기, 춤, 피난민, 회의, 배급, 전봇대, 전선, 전화국, 공병, 학생, 수녀, 소, 기관총"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "155MM 자주식 자주포 (제1 한국군 사단 지원) 155MM SELF-PROPELLED HOWITZERS (SUPPORTING 1ST ROK DIV)",  "소장처별", "년도", new List<string> {" 무산리 (경기도, 한국), 탱크, 포격, 소, 쟁기, 피난민, 폭발, 식사, 위장"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "전방 포병 관측자 FORWARD OBSERVER ARTILLERY",  "소장처별", "년도", new List<string> {" 송수화기, 연기, 포격, 대포, 작도, 군용차, 비포장도로, 탱크"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "제38 한국 보병군이 반격을 멈추다 (제23 보병 연대 제2 사단이 전선에 나가다) 38TH INF ROK STOPS COUNTERATTACK (23RD INF REGT 2ND DIV MOVING UP)",  "소장처별", "년도", new List<string> {" 양구군(한국), 군용차, 행군, 송수화기, 기관총, 사격, 박격포, 헬리콥터, 성조기, 왕립깃발, 수여식, 활주로"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한국 건 카메라 KOREAN GUN CAMERA",  "소장처별", "년도", new List<string> {" 비행기, 공항, 도시와 시내, 폭발, 농지, 철로, 로켓 (대포), 선박, 공격 (군사학), 비행 중대"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "일반 활동 ABD 미국해군전함 위스콘신 (BB-64) 한국 지역 GENERAL ACTIVITIES ABD USS WISCONSIN (BB-64) Korean Area",  "소장처별", "년도", new List<string> {" 해군성. 위스콘신 (전함). 4/16/1944-9/1947, 항공모함, 비행기, 대공포, 전함, 소형 화기, 헬리콥터, 선박 관리와 수리, 인명구조 공구와 공급"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "고무 보트 정찰 상륙 RUBBER BOAT RECON LANDING",  "소장처별", "년도", new List<string> {" 화천(한국), 지도, 브리핑, 고무보트, 의례, 군악대, 연설"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "지휘권 교대, 제1 해병사단 CHANGE OF COMMAND, FIRST MARINE DIVISION",  "소장처별", "년도", new List<string> {" 한국, 제랄드 C. 토마스, 1929-, 소형 화기, 회의, 군인, 육군 장교, 순양함 (군함) "}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "더글라스 맥아더 장군 GEN. DOUGLAS MACARTHUR",  "소장처별", "년도", new List<string> {" 김포군(한국), 비행기, 군용차, 수여식, 헬리콥터"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "수송대대 TRANSPORTATION CORPS",  "소장처별", "년도", new List<string> {" 인천(한국), 기중기, 포탄, 보트, 열차"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "흥남 이야기 THE HUNGNAM STORY",  "소장처별", "년도", new List<string> {" 군용트럭, 군용차, 함대, 포탄, 기중기, 환자, 탱크, 피난민, 공장, 폭파"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한국전쟁 KOREAN WAR",  "소장처별", "년도", new List<string> {" 수원시(한국), 비행기, 공항, 자동차, 피난민, 열차, 소정리, 바주카, 한국군"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "제24 사단의 공격 (전투 의료) 24TH DIV IN ATTACK (COMBAT MEDICS)",  "소장처별", "년도", new List<string> {" 한국(북한), 환자, 차, 적십자, 텐트, 헬리콥터, 천막, 트럭, 운송, 임시다리"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "더글라스 맥아더 장군의 전방 방문 GEN. DOUGLAS MACARTHUR VISITS FRONT",  "소장처별", "년도", new List<string> {" 수원시, 군용차, 목사, 탱크, 폐허, 성벽, 수색, 이동"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "리지웨이 장군 GEN. RIDGWAY",  "소장처별", "년도", new List<string> {" 한국, 군용차, 강아지, 탱크, 기관총, 사격, 비행기, 자동차, 수여식"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "폭격을 맞는 제27 보병 부대 (울프하운드) 27TH INF TROOPS (WOLFHOUNDS) UNDER FIRE",  "소장처별", "년도", new List<string> {" 안양(한국), 군용차, 탱크, 사격, 시신, 참호, 전투기, 폭격"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "은성 훈장 수여 PRESENTATION OF SILVER STARS",  "소장처별", "년도", new List<string> {" 지평리 (한국), 군용차, 차, 군의례, 연설, 성조기, 군악대"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "김포로부터의 고아 피난 EVACUATION OF ORPHANS FROM KIMPO",  "소장처별", "년도", new List<string> {" 한국, 피난민, 군용트럭, 고아, 비행기, 군인, 트럭, 배, 화물"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "C-46의 D.D.T 살포 D.D.T. SPRAYED BY C-46",  "소장처별", "년도", new List<string> {" 서울(한국), 비행기, 도시, 연료, 이륙, 항공샷, 포탄, 포격, 송수화기"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "탱크 보병 순찰 TANK-INFANTRY-PATROL",  "소장처별", "년도", new List<string> {" 한국(북한), 탱크, 관측, 포격, 초가집, 카드게임, 배급, 공중포격, 산, 연기"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "제65 한국군 순찰 중 65TH RCT PATROL IN FORCE",  "소장처별", "년도", new List<string> {" 오산 (경기도, 한국), 피난민, 탱크, 군용차, 포격, 비행기, 행군, 군용기"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "헌병대 활동 MP ACTIVITIES",  "소장처별", "년도", new List<string> {" 한국, 통신병, 도로, 천막, 군용차, 열차, 간판, 길거리"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "휴전 회담 CEASE-FIRE TALKS",  "소장처별", "년도", new List<string> {" 개성시(한국), 행군, 군용차, 부교, 회담"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "영국 순양함의 홍군용기/ 전폭기 선별신 SELECTED SCENES OF RED TROOPS/RIOTS PLANES FROM BRITISH CARRIER",  "소장처별", "년도", new List<string> {" 중국, 일본, 독일, 러시아, 한국, 판문점(한국), 조이, C. 터너 (찰스 터너), 1895-1956, 리즈웨이, 매슈 B. (매슈 벙커), 1895-1993, 공장, 소형 화기, 헬리콥터, 회의, 군용기, 배"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "드와이트 D. 아이젠하워 장군 도착 Arrival of General Dwight D. Eisenhower",  "소장처별", "년도", new List<string> {" 군용차, 군용트럭, 태극기, 시청, 인파, 군악대, 행진, 연설"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "전투 카메라맨의 역할 Role of the Combat Cameraman",  "소장처별", "년도", new List<string> {" 한국전쟁, 1950-1953, 사진가, 세계 대전, 1939-1945, 세계 대전, 1914-1918 "}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "중공군이 한국전쟁에 참전하다 Chinese Reds Enter the Korean War",  "소장처별", "년도", new List<string> {" 피난민, 행군, 환자, 군용차, 헬리콥터, 수술, 낙하산부대, 지프차, 기관총"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "CRIPPLED CHICK 프로젝트 PROJECT CRIPPLED CHICK",  "소장처별", "년도", new List<string> {" 국방부 해군성. 해군건설부대. 9/18/1947-, 공항, 농장, 지프차, 불도저, 건설장비"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "90.6 기동부대의 인천 지역 폭격 BOMBARDMENT OF INCHON AREA BY TASK GROUP 90.6",  "소장처별", "년도", new List<string> {" 인천(한국), 국방부. 해군성. 톨레도 (잠수함). 2/24/1995-, 대공포, 폭발, 항공, 의료 지원, 지뢰 (군폭발물), 해군 장교, 레이더, 병과 부상에 대한 전시 구조, 회전포탑"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한국 육군 활동 ROK ARMY ACTIVITIES",  "소장처별", "년도", new List<string> {" 양구군(한국), 행군, 사격, 산, 포격"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "제8 한국군, 제16 연대 전열 정비, 제10 군단 지구, 785 언덕 기지 8TH ROK, 16TH REGT ON LINE, X CORPS SECTOR, BASE HILL 785",  "소장처별", "년도", new List<string> {" 포격, 포탄, 송수화기, 적십자, 전쟁포로, 부상, 기관총"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "흥남 이야기 THE HUNGNAM STORY",  "소장처별", "년도", new List<string> {" 군용차, 공중보급, 군수품, 활주로, 탱크, 함대, 포격, 투하, 피난민"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "해병대원이 줄지어 나오다 MARINES COME STREAMING OUT",  "소장처별", "년도", new List<string> {" 진흥시(한국), 군용차, 도로, 군용트럭, 동상"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "제3 공병 전투 여단, 제24 사단, FUGASSE (네이팜) 준비 3RD ENGR COMBAT BN, 24TH DIV, PREPARE FUGASSE (NAPALM)",  "소장처별", "년도", new List<string> {" 한국, 연료제조, 연료, 폭발물 설치, 폭발"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "이승만 SYNGMAN RHEE",  "소장처별", "년도", new List<string> {" 군용차, 이승만, 피난민, 부교, 쇄빙선, 서울, 박격포, 포격"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "미국해군전함 레이테 선상 작전 OPERATIONS ABOARD THE USS LEYTE",  "소장처별", "년도", new List<string> {" 한국, 비행기, 포탄, 활주로, 항공기 유도사, 조종사"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "제96 화력 대대 & 제8 공병 96TH FA BATTALION & 8TH ENGINEERS",  "소장처별", "년도", new List<string> {" 한국, 헬리콥터, 탱크, 군용차, 행군, 밭, 쌍안경, 포격"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "공중투하, 제187 공수 연대 전투단 (RCT) AIRDROP, 187TH AIRBORNE REGIMENTAL COMBAT TEAM (RCT)",  "소장처별", "년도", new List<string> {" 대구 (한국), 비행기, 공중보급, 군수품, 환자, 행군, 적십자"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "김포 공군 기지 대니 케이트 공연단 DANNY KAYE TROUPE KIMPO AIR FORCE BASE",  "소장처별", "년도", new List<string> {" 대구(한국), 사진사, 군용차, 군행사, 군악대, 비행기, 자동차, 초가집, 쌍안경"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "김포 공군 기지 대니 케이트 쇼 DANNY KAYE SHOW KIMPO AIR FORCE BASE",  "소장처별", "년도", new List<string> {" 대구 (한국), 헬리콥터, 군악대, 공연, 군행사, 축구, 헬리콥터, 비행기"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "제1 전방 관측 대대 FIRST FORWARD OBSERVATION BATTALION",  "소장처별", "년도", new List<string> {" 창원 (한국), 군용차, 도로, 관측, 참호, 산, 송수화기, 들판"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "안나 로즈버그의 제17 연대, 제7 사단 방문 ANNA ROSENBERG'S VISIT TO 17TH REGT, 7TH DIV",  "소장처별", "년도", new List<string> {" 양강도 (한국), 군비행기, 천막, 군용차, 지도, 브리핑"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "제임스 A. 반 장군 함대와 제11 ROKs 연대 GENERAL JAMES A. VAN FLEET AND 11TH REGT ROKs",  "소장처별", "년도", new List<string> {" 임진강(한국), 군용기, 활주로, 천막, 군용트럭, 불도저, 돌다리, 위장, 연기, 사격, 탱크"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "에티오피아군 ETHIOPIAN TROOPS",  "소장처별", "년도", new List<string> {" 한국, 지도, 브리핑, 송수화기, 군용차, 군용트럭, 행군, 도로, 관측"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "제1 해병사단 FIRST MARINE DIV",  "소장처별", "년도", new List<string> {" 한국, 헬리콥터, 천막, 행진, 군수품, 항공샷 "}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "미해병대 제1 해병 사단, 부대가 헬리콥터를 통해 전방으로 이동 US MARINE CORPS 1ST MARINE DIV, TROOPS VIA HELICOPTER TO FRONT",  "소장처별", "년도", new List<string> {" 인제군(한국), 지도, 들판, 헬리콥터, 항공샷, 산, 행군"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "캐나다 여단 CANADIAN BRIGADE",  "소장처별", "년도", new List<string> {" 군용차, 텐트, 관측, 운반, 군수품, 군용식량, 참호, 포격, 배식"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "전쟁포로 PRISONERS OF WAR",  "소장처별", "년도", new List<string> {" 한국, 전쟁포로, 투항, 총검, 소형 화기, 부상, 군용트럭"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "휴전 교섭 회담 CEASE FIRE TALKS",  "소장처별", "년도", new List<string> {" 개성시(한국), 군용차, 전통건물, 사진사, 헬리콥터"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "인천, 한국 - 상륙 이후 INCHON, KOREAN - AFTER INVASION",  "소장처별", "년도", new List<string> {" 인천(한국), 맥아더 더글라스 1880-1964, 소형 화기, 요새화, 항구, 탱크 (군사학), 전쟁피해, 병과 부상에 대한 전시 구조, 지프차, 침입"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "BIG SWITCH 작전 OPERATION BIG SWITCH",  "소장처별", "년도", new List<string> {" 전쟁포로, 감옥, 철로, 트럭, Big Switch 작전, 1953 "}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한국전쟁 마지막 날 -- 벙커 인양 LAST DAY OF KOREAN WAR -- BUNKER SALVAGE",  "소장처별", "년도", new List<string> {" 전투, 브리핑, 벙커 (방어 시설), 의료인, 간호사, 인양 (폐기물 등), 탱크 (군사학), 군식당"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한국전쟁 마지막 날 -- 벙커 인양 LAST DAY OF KOREAN WAR -- BUNKER SALVAGE",  "소장처별", "년도", new List<string> {" 참호, 포탄, 탄약"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "전투기 사진 중대 (MN-7893) FIGHTER PHOTO SQUADRON (MN-7893)",  "소장처별", "년도", new List<string> {" 국방부. 해군성. 에식스 (항공모함). 1/16/1951-6/1/1973, 대공포, 위장 (군사학), 해병대, 군용기, 선박, 기관총"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "BIG SWITCH 작전 OPERATION BIG SWITCH",  "소장처별", "년도", new List<string> {" 버스, 아이들, 상륙 작전, 해병대, 우편 근무, Big Switch 작전, 1953, 총검, 경비대"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "'BIG SWITCH' 작전 자유의 마을/문산/판문점 OPERATION, 'BIG SWITCH' Freedom Village/Munsan/Panmunjom",  "소장처별", "년도", new List<string> {" 아프리카계 미국인, 앰뷸런스, 헬리콥터, 인터뷰, 상륙 작전, 의료 관리, 전쟁포로, Big Switch 작전, 1953, 종군 기자"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "휴전 협정 TRUCE TALKS",  "소장처별", "년도", new List<string> {" 판문점 (한국), 캐나다, 한국, 클락, 조셉 제임스, 1893-1971, 경비대"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "휴식 인원; 맹폭 & 소이탄 낙하; MIG-15 한국 지역 파괴 PERSONNEL RELAX; STRAFING & NAPALM BOMB DROPS; MIG-15 DESTROYED Korean Area",  "소장처별", "년도", new List<string> {" 해군성. 포그 밸리 (항공모함). 11/3/1946-9/19/1947, 비행기, 폭탄, 폭발, 항공, 해병대, 탱크, 보초 근무, 지프차, 트레이서 (탄약), 경비대"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "미국해군전함 컨솔레이션 (AH-15) 부상병 대피 USS CONSOLATION (AH-15) EVACUATES WOUNDED",  "소장처별", "년도", new List<string> {" 해군성. 컨솔레이션 (병원선). 5/22/1945-9/18/1947, 앰뷸런스, 헬리콥터, 군수품, 환자, 선박, 병과 부상에 대한 군사구조"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "종합적 항공모함 작전 GENERAL CARRIER OPERATIONS",  "소장처별", "년도", new List<string> {" 해군성. 복서 (항공모함). 4/16/1945-9/18/1947, 해군성. 챔플레인 호 (항공모함). 6/3/1945-9/18/1947, 항공모함, 비행기, 폭탄, 구축함 (군함), 트랙터, 연료공급"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "전쟁의 하루 ONE DAY OF WAR",  "소장처별", "년도", new List<string> {" 통신, 방어 시설, 해병대, 군수품, 라디오, 육군 장교, 군식당, 텐트, 군병원, 기관총"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "전쟁의 하루 ONE DAY OF WAR",  "소장처별", "년도", new List<string> {" 폭탄, 통신, 크레인, 기중기 등, 로켓 (포), 선박, 타이거캣 (전투기), 활주로 (항공학), GMC 덕 (군용트럭), 경비대, 연료 공급"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "UNC MAC (유엔 사령부, 군사 정전 위원회) 활동 UNC MAC (United Nations Command, Military Armistice Commission) ACTIVITIES",  "소장처별", "년도", new List<string> {" 인도, 판문점 (한국), 한국, 틴, 아서 H. (아서 홉슨), 1898-1987, 비행기, 회의와 조약, 헬리콥터, 한국인, 육군장교, 경비대"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "원산 항구 해군 작전 NAVAL OPERATIONS IN WONSAN HARBOR",  "소장처별", "년도", new List<string> {" 원산 (한국), 국방부. 해군성. 맨체스터 (경순양함). 9/18/1947-6/27/1956, 국방부. 해군성. 딜 (경화물수송함). 3/31/1949-9/8/1955, 탄약, 폭발, 항공, 상륙 작전, 해병대, 군수품, 지뢰 (군용 폭발물), 폴라리스 (미사일), 침입"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "제1 해병사단 활동 고도리와 하가루리  지역 ACTIVITIES OF THE FIRST MARINE DIVISION Koto-Ri and Hararu-Ri Areas",  "소장처별", "년도", new List<string> {" 해군, 육군장교, 사찰, 행진, 텐트, 군용헬기, 지프차, 와이어, 바주카"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "미국 해군 전함 필리핀 바다 (CV-47) 전투 중; 조종실 작전 USS PHILIPPINE SEA (CV-47) IN COMBAT; FLIGHT DECK OPERATIONS",  "소장처별", "년도", new List<string> {" 한국, 해군성. 주노 (경순양함). 2/14/1942-11/13/1942, 해군성. 필리핀 바다 (항공모함). 5/11/1946-9/18/1947, 항공모함, 비행기, 대공포, 선박, 표적 (군사학), 순양함 (군함) "}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "흥남 항구 활동 ACTIVITIES IN HUNGNAM HARBOR",  "소장처별", "년도", new List<string> {" 국방부. 해군성. 성 파울 (중순양함). 9/18/1947-4/30/1971, 앰뷸런스, 해변, 구축함 (군함), 민간인 대피, 항구, 병원, 해군, 군수품, 간호사"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "CL's, BB's, 그리고 DD's 참가; 피난민; U.N. 깃발 CL's, BB's, and DD's IN ACTION; REFUGEES; U.N. FLAG",  "소장처별", "년도", new List<string> {" 인천 (한국), 국방부. 해군성. 멘체스터 (경순양함). 9/18/1947-6/27/1956, 국방부. 해군성. 잉글리시 (구축함). 9/18/1947-5/15/1970, 해군성. 미시우리 (전함). 6/11/1944-9/1947, 대공포, 헬리콥터, 육군 장교, 연막"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한국 카메라총 KOREAN GUN CAMERA",  "소장처별", "년도", new List<string> {" 함흥 (한국), 해군성. 복서 (항공모함). 4/16/1945-9/18/1947, 폭탄, 카메라, 댐, 군기지, 선로, 공세 (군사학) "}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "제187 RCT 공수 187TH RCT AIRBORNE",  "소장처별", "년도", new List<string> {" 무산리 (경기도, 한국), 공중보급, 성조기, 탱크, 도로, 부상, 밭, 폐허"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "391 고지 탈환 RETAKING HILL 391",  "소장처별", "년도", new List<string> {" 한국 (북한), 철로, 탱크, 들판, 행군, 포격, 사격, 지뢰탐지기"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "전쟁 WAR",  "소장처별", "년도", new List<string> {" 수원시(한국), 비행기, 화재, 길거리, 도로, 선박"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "무기 시범 (화력 작전) ORDNANCE DEMONSTRATIONS (OPERATION FIREPOWER)",  "소장처별", "년도", new List<string> {" 대구(한국), 사격, 기관총, 박격포, 탱크, 야구장, 관중, 연설"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "532 엔지니어 보트 & 해안 여단, 제2 공병 여단 532ND ENGR BOAT & SHORE REGT, 2ND ENGR BRIGADE",  "소장처별", "년도", new List<string> {" 인천(서울), 연료, 보트, 배, 상륙 "}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "급습 단체 (특별활동 그룹 X 부대) 게릴라 공격 RAIDER COMPANIES (SPECIAL ACTIVITIES GROUP X CORPS) ATTACK ON GUERRILLAS",  "소장처별", "년도", new List<string> {" 포격, 성벽, 사격, 포격, 군수품, 헬리콥터, 환자"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "수색정찰 RECONNAISSANCE PATROL",  "소장처별", "년도", new List<string> {" 텐트, 군수품, 트럭, 견인, 배식, 이발, 세안"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "첫 전방관측대대 FIRST FORWARD OBSERVATION BATTALION",  "소장처별", "년도", new List<string> {" 창원(한국), 안테나, 관측장비, 통신, 송수신기, 김포(한국) "}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "심리전 PSYCHOLOGICAL WARFARE",  "소장처별", "년도", new List<string> {" 삼가리(한국), 비행기, 전단, 전단 투하, 구름, 인쇄공장, 포장, 창고, 트럭"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "K-14 고지 HILL K-14",  "소장처별", "년도", new List<string> {" 김포군(한국), 관측장비, 안테나, 탱크, 불타는 탱크, 포격"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "오마 N. 브래들리 장군 2 사단 활주로 방문 GEN. OMAR N. BRADLEY VISITS 2ND DIVISION AIRSTRIP",  "소장처별", "년도", new List<string> {" 헬기, 사진사, 군용기, 지도, 활주로, 탄약, 발포"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "D CO 작전 첫번째, 탱크 대대, 해병 사단 A DAY'S OPERATION WITH D CO., 1ST TANK BN, 1ST MARINE DIVISION",  "소장처별", "년도", new List<string> {" 한국(남한), 탱크, 텐트, 불도저, 보트, 포격, 헬리콥터, 군용차"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "비둘기 PIGEONS",  "소장처별", "년도", new List<string> {" 인제군(한국), 비둘기, 군용차, 천막, 본부, 태극기, 유엔기, 성조기"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "제65 보병, 제3 사단, 기동부대 65TH INF, 3RD DIV, ON TASK FORCE",  "소장처별", "년도", new List<string> {" 창원(한국), 들판, 탱크, 포격, 환자, 응급처치, 사격, 산 포격"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "포로 심문 INTERROGATION OF PRISONERS",  "소장처별", "년도", new List<string> {" 한국(북한), 천막, 전쟁포로, 대포, 포격, 통신, 사격, 군용차, 초가집, 환자"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "휴전 회담 재개 RESUMING ARMISTICE TALKS",  "소장처별", "년도", new List<string> {" 개성시, 다리, 군용차, 헬기, 자동차, 군중, 사진기자, 기모노"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "포병 훈련소 ARTILLERY TRAINING CENTER",  "소장처별", "년도", new List<string> {" 진해시(한국), 대포, 훈련, 천막, 위장, 박격포, 사격, 훈련장"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "교통을 통제하는 헌병대 MILITARY POLICE DIRECTING TRAFFIC",  "소장처별", "년도", new List<string> {" 의정부시(한국), 보트, 부교, 소, 탱크, 교통통제, 군용차, 주차장, 군용트럭"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "지뢰제거 순찰 MINE SWEEPING PATROL",  "소장처별", "년도", new List<string> {" 한국 (북한), 도로, 지뢰탐지기, 지뢰, 탱크, 관측, 불도저, 탱크"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "제630 공병이 인제로의 길을 뚫다 630TH ENGINEERS WIDENING ROAD TO INJE",  "소장처별", "년도", new List<string> {" 인제군, 산, 화약, 폭발, 불도저, 군용트럭"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "제58 공병들이 만든 부교 PONTON BRIDGE BUILT BY 58TH ENGINEERS",  "소장처별", "년도", new List<string> {" 임진강(한국), 배, 기중기, 군용트럭, 탱크"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "난민 REFUGEES",  "소장처별", "년도", new List<string> {" 창원 (한국), 난민, 초가집, 취사, 군용트럭, 미군"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "육군 목사 부서 전쟁포로 시설 DEPT OF ARMY CHAPALINS AT POW ENCLOSURE",  "소장처별", "년도", new List<string> {" 거제도 (한국), 군인, 군합창단, 연설"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "육군야전병원 (MASH) MOBILE ARMY SURGICAL HOSPITAL (MASH)",  "소장처별", "년도", new List<string> {" 홍천 (한국), 배식, 천막, 환자, 수술"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "휴전 회담 TRUCE TALKS",  "소장처별", "년도", new List<string> {" 판문점 (한국), 한국, 해리슨, 윌리엄 K. (윌리엄 캘리), 1895-1987, 클라크, 마크 W. (마크 웨인), 1896-1984, 멘덴홀, 윌리엄 K. (윌리엄 마르마두크), 1900-1987, 폭발, 사진사, 군수기자, 경비대"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "휴전 회담 TRUCE TALKS",  "소장처별", "년도", new List<string> {" 스웨덴, 스위스, 무산리 (한국, 경기도), 판문점 (한국), 해리슨, 윌리엄 K. (윌리엄 캘리), 1895-1987, 헬리콥터, 해병대, 사진사, 사찰, 종군 기자, 의장대, 불도저"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "도서관 스토크 쇼트 #1626 LIBRARY STOCK SHOT #1626",  "소장처별", "년도", new List<string> {" 회담, 소련, 군용차, 행진, 농민, 인공기, 북한군, 회의, 방사물질"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "BIG SWITCH 작전 OPERATION BIG SWITCH",  "소장처별", "년도", new List<string> {" 도쿄 (일본), 딘, 윌리엄 F. (윌리엄 프리셰), 1899-1981, 딘, 윌리엄 F. (윌리엄 프리셰), 1899-1981, 전쟁포로, Big Switch 작전, 1953 "}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "구축함전대 122 귀향 HOMECOMING OF DESDIV 122",  "소장처별", "년도", new List<string> {" 해군성. 브리스통 (군축함). 3/17/1945-9/18/1947, 해군성. 하이만 (군축함). 6/16/1944-9/18/1947, 군축함 (전함), 부두, 항구, 의례와 행사, 선원, 선박조종, 시민"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "필름 소개 '펜타곤 워싱턴'  FILM INTRODUCTIONS BY 'PENTAGON WASHINGTON'",  "소장처별", "년도", new List<string> {" 책상, 인터뷰, 군인, 난선, 명판, 곡사포"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "조지 C. 마셜 국방장관 연설, 육군사관학교 졸업식, 뉴욕 SECRETARY OF DEFENSE GEORGE C. MARSHALL'S SPEECH, WEST POINT GRADUATION, NEW YORK",  "소장처별", "년도", new List<string> {" 음성있음, 연설"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "유엔 안보리 검토 UN SECURITY COUNCIL REVIEW",  "소장처별", "년도", new List<string> {" 뉴욕 (N.Y.), 음성있음, 회담"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "매슈 B 리즈웨이 장군과 J 로턴 콜린스 장군 만남 MEETING BETWEEN GENS MATHEW B RIDGWAY AND J. LAWTON COLLINS",  "소장처별", "년도", new List<string> {" 국방부. 공군성. 가데나 공군 기지, 오키나와. ca. 9/18/1947-, 군용기, 활주로, 자동차, 헬기, 천막"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "해리 S. 트루먼 대통련 독립기념일 연설, 모누멘트 그룬즈, 워싱턴, DC PRESIDENT HARRY S. TRUMAN'S INDEPENDENCE DAY SPEECH, MONUMENT GROUNDS, WASHINGTON, DC",  "소장처별", "년도", new List<string> {" 연설, 음성있음 "}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "미국 산업 현장 (주 정부) INDUSTRIAL SCENES USA (STATE DEPT)",  "소장처별", "년도", new List<string> {" 공장, 화재, 열차, 민간인, 활주로, 군용기, 이륙, 공중보급"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "함대 활동 (후방지원) FLEET ACTIVITIES (BACKGROUND SUPPLEMENT)",  "소장처별", "년도", new List<string> {" 사세보시(일본), 선박, 미국대사, 헬기, 군용차, 행진, 장례식, 교회"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "탱크 보병 정찰 TANK INFANTRY PATROL",  "소장처별", "년도", new List<string> {" 환자, 군용차, 미군, 지원사격, 포격, 민간인, 판자선, 피난민, 천막"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "심리전 제 25사단  LIAISON (심리전) PSY-WAR TEAM 25TH DIVISION LIAISON (PSYCHOLOGICAL WARFARE)",  "소장처별", "년도", new List<string> {" 군용차, 국군, 통신병, 통신장비, 지도, 창고, 선전물, 서울, 군용기, 이륙 "}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "미국해군전함 BOXER (CV-2 탑승) ABOARD THE USS BOXER (CV-2",  "소장처별", "년도", new List<string> {" 해군성. 복서 (순양함). 4/16/1945-9/18/1947, 국방부. 해군성. 맨체스터 (경순양함). 9/18/1947-6/27/1956, 국방부. 해군성. 카트마이 산 (탄약선). 9/18/1947-8/14/1973, 개빈 제임스 M. (제임스 모리스), 1907-1990, 공군 조종사, 항공모함, 폭탄, 군수품, 해군 장교, 로켓"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "아이젠하워 장군의 워싱턴 출발, 항공 수송 본부 터미널 GEN. EISENHOWER'S DEPARTURE FROM WASHINGTON, MATS TERMINAL",  "소장처별", "년도", new List<string> {" 워싱턴(D.C), 음성있음(일부), 연설, 비행기, 이륙 "}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "앨번 윌리엄 바클리 부통령 기자회견 VICE PRESIDENT ALBEN W. BARKLEY AT PRESS CONFERENCE",  "소장처별", "년도", new List<string> {" 도쿄(일본), 부통령, 기자회견, 성조기, 일장기, 회담, 천막, 군용기"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "OMAR N. BRADLEY 장군 최전선 방문 GENERAL OMAR N. BRADLEY VISITS FRONT LINES",  "소장처별", "년도", new List<string> {" 미군, 군악대, 군용기, 수여식, 사진사, 국군, 군용차, 군용천막"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "포병 관측, 878 언덕 ARTILLERY OBSERVATION, HILL 878",  "소장처별", "년도", new List<string> {" 관측, 지도, 통신장비, 태극기, 군악단, 서울시청, 연설, 헬기, 교회"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));
        saveData.Data0.Add(new Datajson("기록영상", 1949,  "한국 현장, 서울; 제칠일안시일예수재림교회, 서울; 고아원 KOREAN SCENES, SEOUL ; SEVENTH DAY ADVENTIST CHURCH, SEOUL ; ORPHANAGE",  "소장처별", "년도", new List<string> {" 미군, 코리아타임즈, 제칠일안시일예수재림교회, 고아원, 수녀, 외국인교사, 목욕, 급식, 소독"}, 0, "없음", "/movies/00/9_유엔 서울로 후퇴, 서울.mp4", "/images/00/ing.png"));





 


 













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
        saveData.urljson.Add(new urljson("라이브러리3", "https://www.daum.net"));

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

        selectController.group_subbtn_title = year_group[0];


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
            if (select_type == 0)
            {

                selectController.year_subtitleObj.GetComponentInChildren<TextMeshProUGUI>().text = select_main + "년";
            }
            else
            {
                selectController.year_subtitleObj.GetComponentInChildren<TextMeshProUGUI>().text = select_main + "년대";

            }


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