using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public int patientsCured;
    public int patientsHad;

    public static GameManager gameManager;

    private void Awake()
    {
        gameManager = this; 
        if (gameManager != this)
        {
            Destroy(this);
        }
        DontDestroyOnLoad(gameObject);
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
            RandomProblem.RandomProblemScript.GetRandomProblem();
        }
    }

    public void Restart()
    {
        patientsCured = 0;
        patientsHad = 0;
    }
}
