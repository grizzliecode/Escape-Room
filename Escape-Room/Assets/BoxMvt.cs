using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMvt : MonoBehaviour
{
    public float a = 4f;
    public float b = 3.8f;
public GameObject Box;
Vector2 pos;
Vector3 playerPos;

private void Start() {
    playerPos.x=1.5f;
    playerPos.y=1f;
    playerPos.z=0;
    Box.transform.position = playerPos;
}
     void Update()
    {
        pos.x=0;
        if(Input.GetKeyDown(KeyCode.RightArrow)) pos.x=1f;
        if(Input.GetKeyDown(KeyCode.LeftArrow)) pos.x = -1f;
        pos.y=Input.GetAxisRaw("Vertical");
        playerPos.x=Box.transform.position.x;
        playerPos.y=Box.transform.position.y;
        playerPos.z=0f;
    }

    private void FixedUpdate() {
        if(playerPos.x+a*pos.x <= 5.5f && playerPos.x+a*pos.x >= -4.5f)
        {
            playerPos.x=playerPos.x+a*pos.x*(Time.deltaTime/Time.deltaTime);
            Box.transform.position = playerPos;
        }
        if(playerPos.y+b*pos.y <= 1 && playerPos.y+b*pos.y >= -2.8f)
        {
            playerPos.y=playerPos.y+b*pos.y;
            Box.transform.position = playerPos;
        }
    }

}
