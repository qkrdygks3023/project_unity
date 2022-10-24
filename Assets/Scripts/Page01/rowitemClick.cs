using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rowitemClick : MonoBehaviour
{
    // Start is called before the first frame update
    public int index;
    dataController dataController;
    selectController selectController;


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
        Debug.Log("itemClick");
        Debug.Log("itemClick - " + index);
        dataController.selectGrid(index);
        selectController.select();
    }
}
