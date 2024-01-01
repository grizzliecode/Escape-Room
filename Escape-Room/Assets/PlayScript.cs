using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayScript : MonoBehaviour
{
    bool sitCorrect =false;
    float indx = - 3000f;
    float indy=-3000f;
    public GameObject trapa;
    public GameObject letter;
    public Animator transition;
    public float tranTime = 1f;
    public GameObject Choose;
    public GameObject player;
    public GameObject wB;
    public GameObject Card1,Card2,Card3,Card4,Card5,Card6;
    public GameObject chessLeter,ArcadeLetter, PictureLetter;
    Vector3 playerCord;
    // Start is called before the first frame update
    void Start()
    {
        Choose.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(TheScript.solved == true)
        {
            PictureLetter.SetActive(true);
        }
        if(ArcadeMaster.suma==18)
        {
            ArcadeLetter.SetActive(true);
        }
        if(WinScript.solved == true)
        {
            chessLeter.SetActive(true);
        }
        playerCord.x=1f;
        playerCord.y=1f;
        if(sitCorrect==false){
         if(player.transform.position.x<wB.transform.position.x+playerCord.x && player.transform.position.y<wB.transform.position.y+playerCord.y && player.transform.position.x>=wB.transform.position.x && player.transform.position.y>=wB.transform.position.y)
        {
            Choose.SetActive(true); 
        }
        else
        {
            Choose.SetActive(false);
        }
        }
        indx=MasterScript.N;
        indy=MasterScript.M;
        if(sitCorrect==false && indy >-100f && indx>-100f)
        {
             SetDown();
        }
    }

    public void ChooseScene()
    {
        StartCoroutine(LoadLevel(1-SceneManager.GetActiveScene().buildIndex));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(tranTime);  
        SceneManager.LoadScene(levelIndex);
    }

    void SetDown()
    {
        if(indx==-2.5f && indy==1) Card1.SetActive(true);
        else if(indx==1.5f && indy == 1) Card2.SetActive(true);
        else if(indx == 5.5f && indy ==1) Card3.SetActive(true);
        else if(indx== -2.5f && indy ==-2.8f) Card4.SetActive(true);
        else if(indx == 1.5f && indy == -2.8f) 
        {
            Card5.SetActive(true);
            sitCorrect = true;
            trapa.SetActive(true);
            letter.SetActive(true);
        }
        else if(indx==5.5f && indy==-2.8f) Card6.SetActive(true);

    }
}
