using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WelcomeMessage : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI welcomeMessageText;

    void Start()
    {
        welcomeMessageText.text = $"Hi, {DataManager.Instance.username}\nPress Space To Jump";
    }
}
