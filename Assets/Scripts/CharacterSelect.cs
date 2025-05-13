using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelect : MonoBehaviour
{
    public GameObject characterSelectUI;
    public GameObject[] playerCharacters;
    public static int activeCharacter = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void chooseCharacter1()
    {
        playerCharacters[0].SetActive(true);
        playerCharacters[1].SetActive(false);
        activeCharacter = 1;
    }
    public void chooseCharacter2()
    {
        playerCharacters[0].SetActive(false);
        playerCharacters[1].SetActive(true);
        activeCharacter = 2;
    }

    public void loadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        //levelSelectUI.SetActive(false);
        Time.timeScale = 1f; // Resume game time
    }

}
