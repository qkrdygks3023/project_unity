using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class mediaback : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void mediabackBtn()
    {
        Debug.Log("mediabackBtn");
        SceneManager.LoadScene("MainScene");
    }
}
