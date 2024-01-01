using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Drop : MonoBehaviour,IDropHandler
{
   public void OnDrop(PointerEventData eventData)
   {
       if(eventData!=null)
         {
             eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition=GetComponent<RectTransform>().anchoredPosition;
         }
   }
}
