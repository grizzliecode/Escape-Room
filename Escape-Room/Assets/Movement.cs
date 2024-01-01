using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D pvt;

    public float speed= 5f;

    Vector2 pos;

    // Update is called once per frame
    void Update()
    {
        pos.x=Input.GetAxisRaw("Horizontal");
        pos.y=Input.GetAxisRaw("Vertical");
        
    }

     void FixedUpdate() {
       pvt.MovePosition(pvt.position+pos*speed*Time.fixedDeltaTime);

       if(pos.x == 1 && pos.y == 0)
       {
           pvt.rotation = 0-90;
       }
       else if(pos.x == -1 && pos.y == 0)
       {
           pvt.rotation= 180-90;
       }
       else if(pos.x == 0 && pos.y == 1) pvt.rotation=90-90;
       else if(pos.x == 0 && pos.y == -1) pvt.rotation=270-90;
       else if(pos.x == 1 && pos.y == 1) pvt.rotation= 45-90;
       else if(pos.x == 1 && pos.y == -1) pvt.rotation=315-90;
        else if(pos.x == -1 && pos.y == -1) pvt.rotation=225-90;
         else if(pos.x == -1 && pos.y == 1) pvt.rotation=135-90;
   }
}
