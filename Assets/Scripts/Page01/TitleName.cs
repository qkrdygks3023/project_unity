using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class TitleName : MonoBehaviour
{
    // Start is called before the first frame update

    public TextMeshProUGUI textMeshPro;
    public GameObject pageController;
    public int stageNum;
    public List<string> stagetitle;
    public string subtitle;

    void Awake()
    {
        stagetitle = new List<string> { "기록영상", "전쟁영화", "다큐멘터리", "구술영상" };
    }

    void Start()
    {



        // stageNum =  GameObject.Find("pageController").GetComponent<pageController>().stageNum;
        stageNum = pageController.GetComponent<pageController>().stageNum;


        stageController(stageNum);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void stageController(int stageNum)
    {
        subtitle = stagetitle[stageNum];
        Debug.Log(subtitle);

        textMeshPro.text = subtitle;





    }


}
