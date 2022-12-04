using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class worldScreen : MonoBehaviour
{
    // Start is called before the first frame update

    public int timer = 0;
    public int endtime;
    public GameObject prefab;

    void Start()
    {
        StartCoroutine(Timer());
    }

    // Update is called once per frame
    void Update()
    {


        //마우스 오른쪽 클릭
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(Timer());
            timer = 0;
            //마우스 좌표 값 
            Vector3 mousePos = Input.mousePosition;
            //마우스 좌표값을 월드 좌표로 변환
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);

            //prefab을 생성
            GameObject pre = Instantiate(prefab, mousePos, Quaternion.identity);
            //Canvas 아래에 생성
            pre.transform.SetParent(GameObject.Find("Canvas").transform);

        }
    }


    IEnumerator Timer()
    {
        Debug.Log("Timer - " + timer);
        timer = 0;

        while (timer < 10800)
        {
            // Debug.Log("Timer - " + timer);
            timer++;

            if (timer >= 10790)
            {
                // Debug.Log("- end -");
                SceneManager.LoadScene("MainScene");
            }

            yield return new WaitForSeconds(1f);
        }
    }
}
