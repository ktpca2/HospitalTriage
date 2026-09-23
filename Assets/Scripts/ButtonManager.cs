using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void ExitButton()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    public void StartButton()
    {
        SceneManager.LoadScene(1);
    }

    public void ResultsButton()
    {
        SceneManager.LoadScene(2);
    }
}
