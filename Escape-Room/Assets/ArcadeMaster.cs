using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ArcadeMaster : MonoBehaviour
{
    public GameObject LightBulb;
    public GameObject textul;
    public static int suma = 5;
    //public Animator anim;
    public static bool can_play = true;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T)) suma++;
        textul.GetComponent<Text>().text=suma.ToString();
        if(suma == 18)
        {
            EndGame();
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            StartCoroutine(goBack());
        }
    }

    void EndGame()
    {
        can_play = false;
        StartCoroutine(loadBack());
    }

     IEnumerator loadBack()
     {
        LightBulb.SetActive(true);
        yield return new WaitForSeconds(2f);
        //anim.SetTrigger("Start");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("MainRoom");
     }

     IEnumerator goBack()
     {
         yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("MainRoom");
     }

}
