using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rowitemClick : MonoBehaviour
{
    // Start is called before the first frame update
    public int index;
    dataController dataController;
    selectController selectController;
    public bool isLoad = false;


    void Start()
    {
        dataController = FindObjectOfType<dataController>();
        selectController = FindObjectOfType<selectController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void itemClick()
    {

        dataController.selectGrid(index);
        selectController.select(false);
    }
}
