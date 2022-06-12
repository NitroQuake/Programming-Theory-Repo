using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField input;

    public void StartButton()
    {
        SceneManager.LoadScene(1);
    }

    public void SaveViewerName()
    {
        MainManager.Instance.SaveName(input.text);
    }
}
