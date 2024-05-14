using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject recordsPanel;

    private void Start()
    {
        mainMenuPanel.SetActive(false);
//        recordsPanel.SetActive(false);
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Open");
            bool isMainMenuActive = mainMenuPanel.activeSelf;
            mainMenuPanel.SetActive(!isMainMenuActive);

            Time.timeScale = isMainMenuActive ? 1f : 0f;
        }
    }

    public void ViewRecords()
    {
        recordsPanel.SetActive(true);
    }

    public void CloseRecords()
    {
        recordsPanel.SetActive(false);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ExitGame()
    {
//        PlayerPrefs.Save();
        Application.Quit();
    }
}
