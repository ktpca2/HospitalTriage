using TMPro;
using UnityEngine;

public class ProblemUI : MonoBehaviour
{
    public RandomProblem randomProblem;
    public TMP_Text problemText;

    void Start()
    {
        problemText.text = randomProblem.GetRandomProblem();
    }
}