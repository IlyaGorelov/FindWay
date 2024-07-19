using UnityEngine;
using Dummiesman;

public class LoadObjectOnNewScene : MonoBehaviour
{
    void Start()
    {
        OBJLoader ol = new OBJLoader();
        string path = PlayerPrefs.GetString("path");
        GameObject go = ol.Load(path);
        go.transform.localScale = new Vector3(-go.transform.localScale.x, go.transform.localScale.y, go.transform.localScale.z);
    }
}
