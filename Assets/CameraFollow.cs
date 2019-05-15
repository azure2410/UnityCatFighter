using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform cat;
    public float dist= 30.0f;
    public float smoothDamp = 2.0f;
    public float vel;
    float mapHeight;
    float mapWidth;
    private void playerGame()
    {
        GetComponent<UnityEngine.Camera>().orthographicSize = ((Screen.height / 2) / dist);
    }
    private void Update()
    {
        float newPosition = Mathf.SmoothDamp(transform.position.y, cat.position.y, ref vel, smoothDamp);
        transform.position = new Vector3(transform.position.x, newPosition, transform.position.z);
        transform.position = new Vector3(cat.position.x, cat.position.y, transform.position.z);
       mapHeight = 2.0f * GetComponent<UnityEngine.Camera>().orthographicSize;
       mapWidth = mapHeight*GetComponent<UnityEngine.Camera>().aspect;
    }

}
