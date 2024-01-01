using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArcScript : MonoBehaviour
{
    public GameObject ArcadeButon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loadArcade()
    {
        SceneManager.LoadScene(3);
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.collider.tag == "player" && ArcadeMaster.suma<18)
        {
                ArcadeButon.SetActive(true);
        }
    }

    private void OnCollisionExit2D(Collision2D collision) {
        ArcadeButon.SetActive(false);
    }
}
