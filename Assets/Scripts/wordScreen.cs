using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class worldScreen : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;

    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    { 
         
        
        //마우스 오른쪽 클릭
        if(Input.GetMouseButtonDown(0)){
             //마우스 좌표 값 
              Vector3 mousePos = Input.mousePosition;
            //마우스 좌표값을 월드 좌표로 변환
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);  

            //prefab을 생성
           GameObject pre =  Instantiate(prefab, mousePos, Quaternion.identity);
            //Canvas 아래에 생성
            pre.transform.SetParent(GameObject.Find("Canvas").transform);


        
            Debug.Log("마우스 좌표값 : " + mousePos);
            Debug.Log("월드 좌표값 : " + worldPos);
        }
    }
}
