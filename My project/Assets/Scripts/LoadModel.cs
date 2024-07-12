using UnityEngine;
using UnityEditor;
using Dummiesman;
using Unity.VisualScripting;

public class LoadModel : MonoBehaviour
{
    private string path;
    public static GameObject meshFilter;
    public static string objectName;
    [SerializeField] private bool isFirstScene = true;
    private GameObject[] loaded = new GameObject[1];

    private void Start()
    {
        if (!isFirstScene)
            OpenExplorer();
        if (PlayerPrefs.HasKey("path") && loaded[0] == null)
        {
            path = PlayerPrefs.GetString("path");
            OBJLoader ol = new OBJLoader();
            LoadMesh(ol, loaded);
        }
    }

    public void OpenExplorer()
    {
        OBJLoader ol = new OBJLoader();
        if (isFirstScene)
        {
            loaded[0].SetActive(false);
            path = EditorUtility.OpenFilePanel("Choose your model", "", "obj");
            PlayerPrefs.SetString("path", path);
        }
        if (PlayerPrefs.HasKey("path"))
        {
            path = PlayerPrefs.GetString("path");
        }
        LoadMesh(ol, loaded);
    }

    private void LoadMesh(OBJLoader ol, GameObject[] loaded)
    {
        meshFilter = ol.Load(path);
        objectName = meshFilter.name;
        loaded[0] = meshFilter;
        meshFilter.transform.position = isFirstScene ? new Vector3(18, -40, 360) : new Vector3(0, -10, 200);
        meshFilter.transform.localScale = new Vector3(8, 8, 8);
        Transform[] children = meshFilter.GetComponentsInChildren<Transform>();
        foreach (var child in children)
        {
            child.AddComponent<MeshCollider>();
            child.GetComponent<MeshCollider>().convex = true;
        }
    }
}
