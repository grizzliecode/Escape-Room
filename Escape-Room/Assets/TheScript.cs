using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TheScript : MonoBehaviour
{
    public static int s=0;
    public static bool solved = false;
    // Start is called before the first frame update
    void Start()
    {
        solved = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(s==5)
        {
            SF();
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Rev();
        }
    }

    void SF()
    {
        solved=true;
        SceneManager.LoadScene(0);
    }

    void Rev()
    {
        SceneManager.LoadScene(0);
    }
}
