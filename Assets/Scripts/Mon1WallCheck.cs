using UnityEngine;
using System.Collections;

public class Mon1WallCheck : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D _collision)
    {
        transform.parent.gameObject.GetComponent<Mon1Controller>().Flip();
    }
}