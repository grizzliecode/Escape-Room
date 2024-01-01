using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MasterScript : MonoBehaviour
{
    public Animator anim;
    public GameObject box;
    public static float N;
    public static float M;
    // Start is called before the first frame update
    void Start()
    {
        M=0;
        N=0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            N=box.transform.position.x;
            M=box.transform.position.y;
            GoBack();
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            GoBack();
        }
    }

    void GoBack()
    {
        StartCoroutine(loadBack());
    }

    IEnumerator loadBack()
    {
        anim.SetTrigger("Start");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("MainRoom");
    }
}
