using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{

    public Transform player;
    private Vector3 offset;
    void Start()
    {
        offset = transform.position - player.position;
    }

    void LateUpdate()
    {
        this.transform.position = new Vector3(this.transform.position.x, player.position.y, player.position.z);
        this.transform.LookAt(player);
    }
}
