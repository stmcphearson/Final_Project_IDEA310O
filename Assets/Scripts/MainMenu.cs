using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using static UnityEditor.Experimental.GraphView.GraphView;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenuUI;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Play()
    {
        SceneManager.LoadScene("Level1");
        //levelSelectUI.SetActive(false);
        Time.timeScale = 1f; // Resume game time
    }

    public void LevelSelect()
    {
        SceneManager.LoadScene("LevelSelect");

        mainMenuUI.SetActive(false);
        Time.timeScale = 0f;
    }

    public void loadCharacterSelect()
    {
        SceneManager.LoadScene("CharacterSelect");

        mainMenuUI.SetActive(false);
        Time.timeScale = 0f;
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }

}