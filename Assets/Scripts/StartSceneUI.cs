using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class StartSceneUI : MonoBehaviour
{
    [SerializeField] TMP_InputField usernameInput;

    public void StartButtonClick()
    {
        DataManager.Instance.username = usernameInput.text;
        SceneManager.LoadScene("MainScene");
    }
}
