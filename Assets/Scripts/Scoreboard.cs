using TMPro;
using UnityEngine;

public class Scoreboard : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreboardText;

    private ApiClient api;

    private void Awake()
    {
        api = FindAnyObjectByType<ApiClient>();
    }

    public void Refresh()
    {
        StartCoroutine(api.GetResults(ShowResults, ShowError));
    }

    private void ShowResults(ResultList list)
    {
        // hier vul je straks het tekstveld
    }

    private void ShowError(string message)
    {
        scoreboardText.text = "Geen verbinding met de API.";
        Debug.LogError(message);
    }
}