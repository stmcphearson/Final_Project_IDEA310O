using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialScript : MonoBehaviour
{

    public GameObject tutorialUI;
    public static bool tutorialActive = false;

    // Start is called before the first frame update
    void Start()
    {
        tutorialUI.SetActive(true);
        tutorialActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            tutorialUI.SetActive(false);
            tutorialActive = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            tutorialUI.SetActive(false);
            tutorialActive = false;
        }

    }

}
