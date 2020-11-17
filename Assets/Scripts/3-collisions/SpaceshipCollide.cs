using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipCollide : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
    private int lifes = 3;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == triggeringTag && enabled)
        {
            lifes--;
            Destroy(other.gameObject);
            if (lifes < 1)
                Destroy(this.gameObject);
        }
    }
}
