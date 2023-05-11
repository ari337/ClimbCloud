using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    float jumpForce = 680.0f;
    float walkForce = 30.0f;
    float maxWalkSpeed = 2.0f;

    private void Start()
    {
        rigid2D=GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigid2D.AddForce(transform.up*this.jumpForce);

        }

        //좌우 이동
        int key = 0;
        if(Input.GetKey(KeyCode.RightArrow)) key = 1;
        if(Input.GetKey(KeyCode.LeftArrow)) key = -1;

        //플레이어 속도
        float speedx=Mathf.Abs(rigid2D.velocity.x);
        if(speedx < maxWalkSpeed)
        {
            rigid2D.AddForce(transform.right * key * walkForce);
        }

        //움직이는 방향에 따라 반전한다.
        if(key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }
        
    }
}
