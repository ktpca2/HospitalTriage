using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public int patientsCured;
    private int patientsHad;

    public static GameManager gameManager;

    private RandomProblem ProblemScript;

    private void Awake()
    {
        gameManager = this; 
        if (gameManager != this)
        {
            Destroy(this);
        }

        ProblemScript = gameObject.GetComponent<RandomProblem>();
    }

    public void NextPatient()
    {
        patientsHad++;
        if(patientsHad > 4)
        {
            SceneManager.LoadScene(3);
        }
        else
        {
            ProblemScript.GetRandomProblem();
        }
    }


}
