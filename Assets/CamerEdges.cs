using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerEdges : MonoBehaviour
{
    public bool mapBounds = true;
    public Vector3 leftEdge;
    public Vector3 rightEdge;
   

    void Update()
    {
        if (mapBounds)
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, leftEdge.x, rightEdge.x), Mathf.Clamp(transform.position.y, leftEdge.y, rightEdge.y), Mathf.Clamp(transform.position.z, leftEdge.z, rightEdge.z));
        }
    }
}
