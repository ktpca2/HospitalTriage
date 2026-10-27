using System.Collections.Generic;
using UnityEngine;

public class RandomProblem : MonoBehaviour
{
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
        GetRandomProblem();
    }

    public string GetRandomProblem()
    {
        int randomKey = Random.Range(0, Problems.Count);
        Severity = Mathf.FloorToInt(randomKey / 3);
        Debug.Log(Severity);
        DisplayText.text = Problems[randomKey];
        return Problems[randomKey];
    }
}