using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveController : MonoBehaviour
{

    [Header("Position")]
    public Transform player;
    public float horizontalOffset;

    // Update is called once per frame
    private void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.x = player.position.x + horizontalOffset;
        transform.position = newPosition;
    }
}
