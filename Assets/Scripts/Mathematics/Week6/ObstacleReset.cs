using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleReset : MonoBehaviour
{
    private float startX;
    private float startY;
    private float startZ;

    private void Start()
    {
        startX = transform.position.x;
        startY = transform.position.y;
        startZ = transform.position.z;
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Fin")
        {
            transform.position = new Vector3(startX, startY, startZ);
        }
    }
}