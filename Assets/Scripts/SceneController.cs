using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
     public Button btn01, btn02, btn03, btn04;
     public int stageNum;



    
    // Start is called before the first frame update
    int mainNum;
    void Start()
    {
        btn01.onClick.AddListener(delegate {
            onClickBtn01();
        });
        btn02.onClick.AddListener(delegate {
            onClickBtn02();
        }); 
        btn03.onClick.AddListener(delegate {
            onClickBtn03();
        });
        btn04.onClick.AddListener(delegate {
            onClickBtn04();
        });
        

     
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void onClickBtn01(){
        Debug.Log("btn01");
        stageNum = 0;         
        mainNumController(stageNum);
        sceneChange();
     
    }
    void onClickBtn02(){
        Debug.Log("btn02");
        stageNum = 1;   
           mainNumController(stageNum);
           sceneChange();
    }void onClickBtn03(){
        Debug.Log("btn03");
        stageNum = 2;   
           mainNumController(stageNum);
           sceneChange();
    }void onClickBtn04(){
        Debug.Log("btn04");
        stageNum = 3;   
           mainNumController(stageNum);
           sceneChange();
    } 

    public void mainNumController(int Num){
         GameObject.Find("MainController").GetComponent<MainController>().mainNumController(Num) ;  
    }

    public void sceneChange(){
        SceneManager.LoadScene("PageScene");
    }
    
}
