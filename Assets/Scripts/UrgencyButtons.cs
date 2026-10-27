using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UrgencyButtons : MonoBehaviour
{
    [SerializeField] int urgency;

    public void Start()
    {
        transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "U" + urgency;
    }

    public void OnClick()
    {
        if (urgency == RandomProblem.Severity)
        {
            GameManager.gameManager.patientsCured++;
        }

        GameManager.gameManager.NextPatient();
    }
}
