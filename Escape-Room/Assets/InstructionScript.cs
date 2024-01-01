using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject instructiuni;
    public GameObject buton;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
        {
            instructiuni.SetActive(false);
            buton.SetActive(false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.collider.tag=="player")
        {
            buton.SetActive(true);
        }
    }
    private void OnCollisionExit2D(Collision2D collision) {
        buton.SetActive(false);
    }

    public void OpenInstruction()
    {
        instructiuni.SetActive(true);
    }
}
