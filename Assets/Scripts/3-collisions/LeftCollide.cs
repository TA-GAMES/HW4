using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftCollide : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.gameObject.transform.position = new Vector3(10.4f, collision.gameObject.transform.position.y, 0f);
        }
    }
}
