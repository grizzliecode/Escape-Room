using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DifferencesScript : MonoBehaviour,IPointerDownHandler
{
    // Start is called before the first frame update
    public GameObject circle;
    bool touched = false;
    void Start()
    {
        touched =false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerDown(PointerEventData pointerEventData)
    {
        if(touched==false)
        {
            circle.SetActive(true);
            TheScript.s+=1;
            touched =true;
        }
    }
}
