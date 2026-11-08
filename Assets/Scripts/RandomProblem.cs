using System.Collections.Generic;
using UnityEngine;

public class RandomProblem : MonoBehaviour
{
    public static RandomProblem RandomProblemScript;

    private int lastProblemIndex = -1;

    public static int Severity;
    public static TMPro.TextMeshProUGUI DisplayText;
    
    Dictionary<int, string> Problems = new()
    {
        {0, "Heart Attack"},
        {1, "Severe Allergic Reaction"},
        {2, "Frequent Seizures"},

        {3, "Broken Bone"},
        {4, "Profuse Bleeding"},
        {5, "Impalement"},

        {6, "Panic Attack"},
        {7, "Worsening Diabetes"},
        {8, "Dead"},

        {9, "Swollen Limb"},
        {10, "Under-dose"},
        {11, "Out of Prescription Medicine"},

        {12, "Vomiting > 72H"},
        {13, "Diarrhoea > 72H"},
        {14, "Unexplained Sudden Rash"},

        {15, "Flu-like Symptoms"},
        {16, "Back Pains"},
        {17, "Standard Appointment"},
    };

    private void Start()
    {
        RandomProblemScript = this;
        if (RandomProblemScript != this)
        {
            Destroy(gameObject);
        }

        GetRandomProblem();
    }

    public string GetRandomProblem()
    {
        if (Problems == null || Problems.Count == 0)
        {
            return string.Empty;
        }

        if (Problems.Count == 1)
        {
            lastProblemIndex = 0;
            Severity = 0;
            DisplayText.text = Problems[0];
            return Problems[0];
        }

        int randomKey;
        do
        {
            randomKey = Random.Range(0, Problems.Count);
        }
        while (randomKey == lastProblemIndex); 

        lastProblemIndex = randomKey;

        Severity = Mathf.FloorToInt(randomKey / 3);
        Debug.Log(Severity);
        DisplayText.text = Problems[randomKey];

        return Problems[randomKey];
    }
}