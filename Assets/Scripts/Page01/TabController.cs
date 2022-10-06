using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TabController : MonoBehaviour
{
    // public List<TabController> tabControllers = new List<TabController>[TabController];
    // string[] Avengers = new string[3];
    public  Button[] TabControllers = new  Button[4];
    public string title;
    void Start()
    {
         title =  TabControllers[0].GetComponent<GetName>().title;
        TabControllers[0].onClick.AddListener(delegate {
            title =  TabControllers[0].GetComponent<GetName>().title;
           
              call(title);
        });

        TabControllers[1].onClick.AddListener(delegate {
            title =  TabControllers[1].GetComponent<GetName>().title;
                call(title);
        });
        
        TabControllers[2].onClick.AddListener(delegate {
            title =  TabControllers[2].GetComponent<GetName>().title;
                call(title);
        });
        
        TabControllers[3].onClick.AddListener(delegate {
            title =  TabControllers[3].GetComponent<GetName>().title;
                call(title);
        });
        
   
     
 

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void call(string title){
         
            Debug.Log(title);
    }
}
