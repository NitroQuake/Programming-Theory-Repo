using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIHandler : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI isViewing;

    private void Start()
    {
        isViewing.SetText(MainManager.Instance.playerName + " is viewing");
    }

    public void MenuButton()
    {
        SceneManager.LoadScene(0);
    }
}
