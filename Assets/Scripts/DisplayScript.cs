using TMPro;
using UnityEngine;

public class ProblemUI : MonoBehaviour
{
    public void Awake()
    {
        RandomProblem.DisplayText = this.transform.GetComponent<TMPro.TextMeshProUGUI>();
    }
}