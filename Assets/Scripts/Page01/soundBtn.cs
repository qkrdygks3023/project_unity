using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundBtn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject soundController;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void soundOn()
    {

        if (soundController.activeSelf)
        {
            soundController.SetActive(false);
        }
        else
        {
            soundController.SetActive(true);
        }

    }


}
