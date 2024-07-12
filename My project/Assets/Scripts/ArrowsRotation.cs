using UnityEngine;

public class ArrowsRotation : MonoBehaviour
{
    [SerializeField] GameObject arrowsObject;
    [SerializeField] GameObject arrowsImage;

    private void Update()
    {
        if(States.selectedBlock != null)
        {
            arrowsImage.SetActive(true);
            arrowsObject.transform.rotation=Quaternion.Inverse(Camera.main.transform.rotation);
            if(States.mode == States.EditModeState.Rotate)
            {
              arrowsObject.transform.rotation *= States.selectedBlock.transform.rotation;
            }
        }
        else
        {
            arrowsImage.SetActive(false);
        }
    }

    // On ArrowsCamera
}
