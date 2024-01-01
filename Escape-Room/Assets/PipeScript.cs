using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PipeScript : MonoBehaviour,IPointerDownHandler
{
    // Start is called before the first frame update
    public Rigidbody2D pipo;
    //RectTransform rectTransform;
    public int s1;
    public float rot;
    public float rot2;

    public bool wasMoved = false;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(pipo.rotation <0)
        {
            pipo.rotation=360-pipo.rotation;
        }
        

    }
    public void OnPointerDown(PointerEventData pointerEventData)
    {
        StartCoroutine(rotatate());
    }

    IEnumerator rotatate()
    {
        float prot=pipo.rotation;
        for(int j=1;j<=6;j++)
        {
            yield return new WaitForSeconds(0.1f);
            pipo.rotation+=15;
        }
        if(pipo.rotation >= 360) pipo.rotation -= 360;
        if(prot%360 == rot%360 || prot%360 == (rot2%360))
        {
            ArcadeMaster.suma-=1;
            s1=0;
            wasMoved=false;
        }
        else
        {
             if(pipo.rotation%360 == rot%360 || pipo.rotation%360 == (rot2%360))
             {
                 ArcadeMaster.suma+=1;
                 wasMoved=true;
             }
        }
    }
}
