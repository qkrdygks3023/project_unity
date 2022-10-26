using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading;
using System.Threading.Tasks;

public class SceneController : MonoBehaviour
{
    public Button btn01, btn02, btn03, btn04;
    public int stageNum;

    public GameObject ScenePanel;



    // Start is called before the first frame update
    int mainNum;
     void Start()
    {
         btn01.onClick.AddListener(delegate
        {

            StartCoroutine(pnanelAni(0));          
    

        });
        btn02.onClick.AddListener(delegate
        {
         StartCoroutine(pnanelAni(1));          

        });
        btn03.onClick.AddListener(delegate
        {
            StartCoroutine(pnanelAni(2));          

        });
         btn04.onClick.AddListener  (delegate
        {
              StartCoroutine(pnanelAni(3));   

        });



    }

    // Update is called once per frame
    void Update()
    {

    }




    IEnumerator pnanelAni(int stageNum)
    {
        for (int i = 0; i < 101; i++)
        {
            float f = i / 100.0f;
            Color color = ScenePanel.GetComponent<Image>().color;
            color.a = f;
            ScenePanel.GetComponent<Image>().color = color;

            if (i < 30)
            {
                yield return new WaitForSeconds(0.01f);

            }
            else
            {
                yield return new WaitForSeconds(0.009f);

            }
        }        
        onClickBtn(stageNum);
    }





    void onClickBtn(int stageNum)
    {   
        mainNumController(stageNum);
        sceneChange();

    }
    void onClickBtn02()
    {
        Debug.Log("btn02");
        stageNum = 1;
        mainNumController(stageNum);
        sceneChange();
    }
    void onClickBtn03()
    {
        Debug.Log("btn03");
        stageNum = 2;
        mainNumController(stageNum);
        sceneChange();
    }
    void onClickBtn04()
    {
        Debug.Log("btn04");
        stageNum = 3;
        mainNumController(stageNum);
        sceneChange();
    }

    public void mainNumController(int Num)
    {
        GameObject.Find("MainController").GetComponent<MainController>().mainNumController(Num);
    }

    public void sceneChange()
    {
        SceneManager.LoadScene("PageScene");
    }

}
