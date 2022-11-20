using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeBtn : MonoBehaviour
{
    // Start is called before the first frame update
    selectController selectController;

    void Start()
    {
        selectController = FindObjectOfType<selectController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void close_Btn()
    {
        selectController.newBody.gameObject.SetActive(false);
    }
}
