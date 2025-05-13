using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public GameObject levelSelectUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loadLevel1()
    {
        SceneManager.LoadScene("Level1");
        //levelSelectUI.SetActive(false);
        Time.timeScale = 1f; // Resume game time
    }

    public void loadLevel2()
    {
        SceneManager.LoadScene("Level2");
        //levelSelectUI.SetActive(false);
        Time.timeScale = 1f; // Resume game time
    }

    public void loadLevel3()
    {
        SceneManager.LoadScene("Level3");
        //levelSelectUI.SetActive(false);
        Time.timeScale = 1f; // Resume game time
    }

    public void loadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        //levelSelectUI.SetActive(false);
        Time.timeScale = 1f; // Resume game time
    }

}
