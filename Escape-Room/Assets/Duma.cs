using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Duma : MonoBehaviour
{
    public GameObject buton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if(TheScript.solved == false)
        {
            buton.SetActive(true);
        }
    }

    private void OnCollisionExit2D(Collision2D collision) {
        buton.SetActive(false);
    }

    public void FindDifferences()
    {
        SceneManager.LoadScene(4);
    }
}
