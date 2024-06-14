
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dummiesman;

public class LoadObjectOnNewScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        OBJLoader ol = new OBJLoader();
        string path = PlayerPrefs.GetString("path");
        GameObject go = ol.Load(path);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
