using UnityEngine;

public class LearningManager : MonoBehaviour
{
    [SerializeField] MoveToTargetAgent moveToTargetAgent;
    public GameObject[] finishes;

    public void DeactivateFinishes()
    {
        foreach (var finish in finishes) finish.SetActive(false);
    }
}
