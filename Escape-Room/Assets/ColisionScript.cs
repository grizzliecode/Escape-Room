using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColisionScript : MonoBehaviour
{
    public GameObject table;
    // Start is called before the first frame update
    void Start()
    {
       // table= gameObject.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.collider.tag =="player" && WinScript.solved == false)
        {
            SceneManager.LoadScene(2);
        }
    }

    /// <summary>
    /// Sent when a collider on another object stops touching this
    /// object's collider (2D physics only).
    /// </summary>
    /// <param name="other">The Collision2D data associated with this collision.</param>
    void OnCollisionExit2D(Collision2D collision)
    {
        
    }
}
