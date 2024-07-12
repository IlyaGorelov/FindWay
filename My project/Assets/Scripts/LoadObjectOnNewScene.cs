using UnityEngine;
using Dummiesman;

public class LoadObjectOnNewScene : MonoBehaviour
{
    void Start()
    {
        OBJLoader ol = new OBJLoader();
        string path = PlayerPrefs.GetString("path");
        GameObject go = ol.Load(path);
    }
}
