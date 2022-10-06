using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GridController : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
    public int numberToCreate;
    void Start()
    {
        sliverGrid();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void sliverGrid(){
    GameObject newObj;
    for (int i = 0; i < numberToCreate; i++)
    {
        newObj = (GameObject)Instantiate(prefab, transform);
        newObj.GetComponentInChildren<Image>().color = Random.ColorHSV();
    }
    }
}
