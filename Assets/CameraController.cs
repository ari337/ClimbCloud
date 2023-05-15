using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject player;

    private void Start()
    {
        player = GameObject.Find("cat");
    }

    private void Update()
    {
        Vector3 playerPos=player.transform.position;    
        transform.position=new Vector3(transform.position.x,playerPos.y,transform.position.z);
    }
}
