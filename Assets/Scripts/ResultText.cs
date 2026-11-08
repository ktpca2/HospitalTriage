using UnityEngine;
using TMPro;

public class ResultText : MonoBehaviour
{
    private void Start()
    {
        transform.GetComponent<TMPro.TextMeshProUGUI>().text = "You succesfully cured " + GameManager.gameManager.patientsCured + "/" + GameManager.gameManager.patientsHad + " patients!";
    }
}
