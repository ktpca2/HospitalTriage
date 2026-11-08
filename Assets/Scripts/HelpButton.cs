using UnityEngine;

public class HelpButton : MonoBehaviour
{
    [SerializeField] GameObject helpDisplay;

    private void Awake()
    {
        helpDisplay.SetActive(false);
    }

    public void OnPress()
    {
        if (!helpDisplay.activeSelf)
        {
            helpDisplay.SetActive(true);
        }
        else
        {
            helpDisplay.SetActive(false);
        }
    }
}
