using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component moves its object up/down/left/right
 * as long as the W/S/A/D key is held pressed.
 */

public class MovementLetters : MonoBehaviour
{

    [Tooltip("Movement speed in meters per second")]
    [SerializeField]
    float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            transform.position += new Vector3(0, speed * Time.deltaTime, 0);
        else if (Input.GetKey(KeyCode.S))
            transform.position += new Vector3(0, -speed * Time.deltaTime, 0);
        else if (Input.GetKey(KeyCode.A))
            transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        else if (Input.GetKey(KeyCode.D))
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
    }
}
