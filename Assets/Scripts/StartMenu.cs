using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    [SerializeField]
    TMP_InputField NameInput;

    public void StartMainScene()
    {
        SceneData.PlayerName = NameInput.text;

        SceneManager.LoadScene(1);
    }
}
