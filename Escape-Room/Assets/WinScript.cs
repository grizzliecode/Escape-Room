using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool restart = false;
    public static bool solved = false;
    public GameObject text;

    void Start()
    {
        text.SetActive(false);
        solved =false;
        restart=false;
    }
    public GameObject knight;
    public GameObject pawn;
    // Update is called once per frame
    void Update()
    {
        if(DragDrop.action == false)
        {
            if(knight.transform.position!=pawn.transform.position){
                StartCoroutine(loadingBack());
                }
                else{
                    solved = true;
                    SceneManager.LoadScene(0);
            }
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }

    IEnumerator loadingBack()
    {
        text.SetActive(true);
        yield return new WaitForSeconds(1);
        restart = true ;
        text.SetActive(false);
                SceneManager.LoadScene(2);
    }

}
