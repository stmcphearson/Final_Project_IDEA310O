using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinZone : MonoBehaviour
{

    public GameObject winScreenUI;

    // Start is called before the first frame update
    void Start()
    {
        winScreenUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            winScreenUI.SetActive(true);
            Time.timeScale = 0f; // Freeze game time
            WinScreenManager.gameWon = true;
        }
    }

}
