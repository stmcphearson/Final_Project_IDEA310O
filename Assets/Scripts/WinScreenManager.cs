using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreenManager : MonoBehaviour
{
    public GameObject winScreenUI;
    public static bool gameWon = false;
    public string nextLevelName;

    // Start is called before the first frame update
    void Start()
    {
        winScreenUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void NextLevel()
    {
        SceneManager.LoadScene(nextLevelName);
        //player.transform.position = respawnPoint.position;

        winScreenUI.SetActive(false);
        gameWon = false;
        Time.timeScale = 1f; // Resume game time
    }

    public void RestartLevel()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
        //player.transform.position = respawnPoint.position;

        winScreenUI.SetActive(false);
        gameWon = false;
        Time.timeScale = 1f; // Resume game time
    }

    public void LevelSelect()
    {
        SceneManager.LoadScene("LevelSelect");

        winScreenUI.SetActive(false);
        gameWon = false;
        Time.timeScale = 0f;
    }

    public void QuitMainMenu()
    {
        SceneManager.LoadScene("MainMenu");

        winScreenUI.SetActive(false);
        gameWon = false;
        Time.timeScale = 0f;
    }

}