using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoginScreen : MonoBehaviour
{
    public InputField usernameInput;

    public void StartGame()
    {
        string username = usernameInput.text;
        if (!string.IsNullOrEmpty(username))
        {
            PlayerPrefs.SetString("Username", username);
            SceneManager.LoadScene("GameScene");
        }
        else
        {
            Debug.Log("Please enter a username!");
        }
    }
}
