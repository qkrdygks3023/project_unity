using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clickImpact : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("ani");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator ani()
    {
        int i = 10;
        int k = 0;
        while (i > 0)
        {
            i -= 1;           
             k += 1;              
     
            float f = i * 2 / 10.0f;
            //pauseBtn color 변경
            Color color = gameObject.GetComponent<Image>().color;
            color.a = f;
            gameObject.GetComponent<Image>().color = color;


            
            //gameObject transform 사이즈 키우기 
            gameObject.transform.localScale = new Vector2(k/2, k/2);        



            yield return new WaitForSeconds(0.01f);
        }


        Destroy(gameObject);
    }
}
