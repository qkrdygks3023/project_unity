using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rowScrollMoveBtn : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject rowScroll;
    public int moveSize;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void moveLeft()
    {
        Debug.Log("moveLeft");
        //rowScroll Pos x left move
        if (rowScroll.GetComponent<RectTransform>().anchoredPosition.x < 0)
        {
            StartCoroutine("moveLeftCoroutine");

        }


    }

    public void moveRight()
    {
        Debug.Log("moveRight");

        StartCoroutine("moveRightCoroutine");
    }

    IEnumerator moveLeftCoroutine()
    {
        int i = 100;
        while (i > 0)
        {
            i -= 1;
            rowScroll.transform.position = new Vector3(rowScroll.transform.position.x + moveSize, rowScroll.transform.position.y, rowScroll.transform.position.z);
            Debug.Log(rowScroll.transform.position.x);
            Debug.Log(rowScroll.GetComponent<RectTransform>().anchoredPosition.x);


            if (rowScroll.GetComponent<RectTransform>().anchoredPosition.x > 0)
            {
                break;
            }

            yield return new WaitForSeconds(0.01f);
        }
    }

    IEnumerator moveRightCoroutine()
    {

        //rowScroll width
        int rowScrollWidth = ((int)rowScroll.GetComponent<RectTransform>().rect.width / 2) * -1;

        int i = 100;
        while (i > 0)
        {
            i -= 1;
            rowScroll.transform.position = new Vector3(rowScroll.transform.position.x - moveSize, rowScroll.transform.position.y, rowScroll.transform.position.z);

            Debug.Log(rowScrollWidth); //-1323
            Debug.Log(rowScroll.GetComponent<RectTransform>().anchoredPosition.x);  //-454.352
            Debug.Log(rowScroll.GetComponent<RectTransform>().rect.width);
            Debug.Log(rowScroll.GetComponent<RectTransform>().sizeDelta.x);



            //스크롤 없음
            if (rowScroll.GetComponent<RectTransform>().rect.width < 2300)
            {
                break;
            }

            //스코롤 끝 부분            
            if (rowScroll.GetComponent<RectTransform>().anchoredPosition.x < rowScroll.GetComponent<RectTransform>().sizeDelta.x * -1)
            {
                break;
            }

            // 5 - 2205 // 6 = 2646 // 7 = 3087 // 8 = 3528 // 9 = 3969 // 10 = 4410 // 11 = 4851 // 12 = 5292 // 13 = 5733 // 14 = 6174 // 15 = 6615 // 16 = 7056 // 17 = 7497 // 18 = 7938 // 19 = 8379 // 20 = 8820 // 21 = 9261 // 22 = 9702 // 23 = 10143 // 24 = 10584 // 25 = 11025 // 26 = 11466 // 27 = 11907 // 28 = 12348 // 29 = 12789 // 30 = 13230 // 31 = 13671 // 32 = 14112 // 33 = 14553 // 34 = 14994 // 35 = 15435 // 36 = 15876 // 37 = 16317 // 38 = 16758 // 39 = 17199 // 40 = 17640 // 41 = 18081 // 42 = 18522 // 43 = 18963 // 44 = 19404 // 45 = 19845 // 46 = 20286 // 47 = 20727 // 48 = 21168 // 49 = 21609 // 50 = 22050 // 51 = 22491 // 52 = 22932 // 53 = 23373 // 54 = 23814 // 55 = 24255 // 56 = 24696 // 57 = 25137 // 58 = 25578 // 59 = 26019 // 60 = 26460 // 61 = 26901 // 62 = 27342 // 63 = 27783 // 64 = 28224 // 65 = 28665 // 66 = 29106 // 67 = 29547 // 68 = 29988 // 69 = 30429 // 70 = 30870 // 71 = 31311 // 72 = 31752 // 73 = 32193 // 74 = 32634 // 75 = 33075 // 76 = 33516 // 77 = 33957 // 78
            // 1 - 

            // 441 * 9 = 3969 
            // 3969 / 2 = 1984.5

            //rowScroll W Delta


            yield return new WaitForSeconds(0.01f);
        }
    }
}
