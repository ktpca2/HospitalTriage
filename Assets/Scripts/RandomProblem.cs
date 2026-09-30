using System.Collections.Generic;
using UnityEngine;

public class RandomProblem : MonoBehaviour
{
    Dictionary<int, string> Problems = new()
    {
        {1, "Heart Attack"},
        {2, "Severe Allergic Reaction"},
        {3, "Frequent Seizures"},

        {4, "Broken Bone"},
        {5, "Profuse Bleeding"},
        {6, "Impalement"},

        {7, "Panic Attack"},
        {8, "Worsening Diabetes"},
        {9, "Dead"},

        {10, "Swollen Limb"},
        {11, "Under-dose"},
        {12, "Out of Prescription Medicine"},

        {13, "Vomiting > 72H"},
        {14, "Diarrhoea > 72H"},
        {15, "Unexplained Sudden Rash"},

        {16, "Flu-like Symptoms"},
        {17, "Back Pains"},
        {18, "Standard Appointment"},
    };

    void Start()
    {
        int randomKey = Random.Range(1, Problems.Count + 1);

        Debug.Log(Problems[randomKey]);
    }
}