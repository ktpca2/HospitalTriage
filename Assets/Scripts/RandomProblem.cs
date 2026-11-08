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
        {0, "I'm having a heart attack!"},
        {1, "I'm having an allergic reaction and can't breathe!"},
        {2, "Patient is unresponsive due to an internal brain bleed."},

        {3, "My face started to droop and I'm slurring my words."},
        {4, "I am having major pains in my chest!"},
        {5, "Patient is barely breathing due to asthma"},

        {6, "I have an 38.5C fever and I'm feeling unwell."},
        {7, "My stomach is hurting quite a bit."},
        {8, "I think I fractured my arm, it's all swollen!"},

        {9, "I fell and have minor cuts all over me."},
        {10, "I sprained my ankle!"},
        {11, "My ears are constantly hurting!"},

        {12, "I have a runny nose and keep sneezing."},
        {13, "I'm having some stomach aches."},
        {14, "I found a rash on my back."},

        {15, "I have a headache."},
        {16, "I'm coughing a lot."},
        {17, "I'm here for my standard appointment."},
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