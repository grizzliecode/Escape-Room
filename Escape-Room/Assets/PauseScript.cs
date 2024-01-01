using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    public static bool ispaused = false;
    public GameObject pauzaMenu;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            if(ispaused == false)
            {
                PauseAction();
            }
        }
    }

    public void PauseAction()
    {
        pauzaMenu.SetActive(true);
        Time.timeScale = 0f;
        ispaused = true;
    }

    public void Resume()
    {
        pauzaMenu.SetActive(false);
        Time.timeScale = 1f;
        ispaused = false;
    }

    public void Quiting()
    {
        Application.Quit();
    }
}
