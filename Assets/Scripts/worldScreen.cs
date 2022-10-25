using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wordScreen : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target ;

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

        
            Debug.Log("마우스 좌표값 : " + mousePos);
            Debug.Log("월드 좌표값 : " + worldPos);
        }
    }
}
