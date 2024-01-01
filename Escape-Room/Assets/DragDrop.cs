using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
using UnityEngine.SceneManagement;  
using UnityEngine.EventSystems;
  
public class DragDrop: MonoBehaviour,IPointerDownHandler, IBeginDragHandler, IEndDragHandler,IDragHandler,IDropHandler {   

    public static bool action = true;
    RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    private void Start() {
        if(WinScript.restart == true ) action =true;
    }
    private void Awake() {
        rectTransform=GetComponent<RectTransform>();
        canvasGroup=GetComponent<CanvasGroup>();
    }
   public void OnPointerDown(PointerEventData pointerEventData)
    {
        Debug.Log("mouseDown");
    }
     public void OnBeginDrag(PointerEventData eventData)
     {
         Debug.Log("start_drag");
         //canvasGroup.blocksRaycasts = false;
     }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("drag");
        rectTransform.anchoredPosition+=eventData.delta;
    }

     public void OnEndDrag(PointerEventData eventData)
     {
            Debug.Log("end_drag");
            action = false ;
           // canvasGroup.blocksRaycasts = true;
           
     }

     public void OnDrop(PointerEventData eventData)
     {
         if(eventData!=null)
         {
             action = false;
             eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition=GetComponent<RectTransform>().anchoredPosition;
             canvasGroup.alpha =0;
         }
     }
}
