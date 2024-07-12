using UnityEngine;

public class ArrowsControl : MonoBehaviour
{
    [SerializeField] GameObject posArrows;
    [SerializeField] GameObject sizeArrows;
    [SerializeField] GameObject rotArrows;
    [SerializeField] GameObject allArrows;

    private void Update()
    {
        if (States.isEditMode == false)

            allArrows.SetActive(false);
        else allArrows.SetActive(true);
    }

    public void ActivateDifferentArrows(int arrows)
    {
        if (arrows == 1)
        {
            posArrows.SetActive(true);
            sizeArrows.SetActive(false);
            rotArrows.SetActive(false);
        }
        else if (arrows == 2)
        {
            sizeArrows.SetActive(true);
            rotArrows.SetActive(false);
            posArrows.SetActive(false);
        }
        else if (arrows == 3)
        {
            rotArrows.SetActive(true);
            posArrows.SetActive(false);
            sizeArrows.SetActive(false);
        }
    }
}
