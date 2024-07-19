using UnityEngine;
using UnityEngine.SceneManagement;

public class StartingMenuButtons : MonoBehaviour
{
    private GameObject temp;
    private string tempName;
    [SerializeField] private float changer = 10;
    public void Rotate(float change)
    {
        GetObject();
        temp.transform.rotation *= Quaternion.Euler(0, change, 0);
    }

    private void GetObject()
    {
        tempName = LoadModel.objectName;
         temp = GameObject.Find(tempName);
    }

    public void ChangeSize(float changer)
    {
        GetObject();
        float x = temp.transform.localScale.x;
        float y = temp.transform.localScale.y;
        float z = temp.transform.localScale.z;
        temp.transform.localScale = new Vector3(x - changer, y + changer, z + changer);
    }

    public void GoToScene(int a)
    {
        SceneManager.LoadScene(a);
    }
}
