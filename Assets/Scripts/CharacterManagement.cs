using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static UnityEditor.Experimental.GraphView.GraphView;

public class CharacterManagement : MonoBehaviour
{
    public GameObject[] playerCharacters;

    // Start is called before the first frame update
    void Start()
    {
        playerCharacters[0].SetActive(true);
        playerCharacters[1].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (CharacterSelect.activeCharacter == 1)
        {
            playerCharacters[0].SetActive(true);
            playerCharacters[1].SetActive(false);
        }
        else if (CharacterSelect.activeCharacter == 2)
        {
            playerCharacters[0].SetActive(false);
            playerCharacters[1].SetActive(true);
        }
    }

    /*public void setActiveCharacter()
    {
        if (CharacterSelect.activeCharacter == 1)
        {
            playerCharacters[0].SetActive(true);
            playerCharacters[1].SetActive(false);
        }
        else if (CharacterSelect.activeCharacter == 2)
        {
            playerCharacters[0].SetActive(false);
            playerCharacters[1].SetActive(true);
        }
    }*/

}
