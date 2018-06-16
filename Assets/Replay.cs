using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Replay : MonoBehaviour
{

    public Transform player;
    private Vector3 startingPosition;
    private Quaternion startingRotation;
    void Start()
    {
        startingPosition = player.position;
        startingRotation = player.rotation;
    }

    public void ResetPosition()
    {
        player.transform.position = startingPosition;
        player.transform.rotation = startingRotation;
    }
}
