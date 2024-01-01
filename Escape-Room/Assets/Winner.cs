using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Winner : MonoBehaviour
{
    public GameObject inputField;
    public string verif;
    public GameObject endScreen;
    public GameObject coderScreen;

    void Update()
    {
         verif=inputField.GetComponent<Text>().text;
        if(Input.GetKeyDown(KeyCode.Return))
        {
            if(verif == "6781")
            {
                coderScreen.SetActive(false);
                endScreen.SetActive(true);
            }
        }
    }

    public void Quit()
    {
        Application.Quit();
    }
    }
