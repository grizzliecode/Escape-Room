using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCode : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject code;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift) || Input.GetKeyDown(KeyCode.Escape))
        {
            code.SetActive(false);
            Time.timeScale =1f;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.collider.tag=="player")
        {
            code.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
