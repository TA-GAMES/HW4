using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component moves its object up/down/left/right
 * as long as the up/down/left/right arrow key is held pressed.
 */
public class MovementArrows : MonoBehaviour
{
    [Tooltip("Movement speed in meters per second")]
    [SerializeField]
    float speed = 3f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.position += new Vector3(0, speed * Time.deltaTime, 0);
        else if (Input.GetKey(KeyCode.DownArrow))
            transform.position += new Vector3(0, -speed * Time.deltaTime, 0);
        else if (Input.GetKey(KeyCode.LeftArrow))
            transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        else if (Input.GetKey(KeyCode.RightArrow))
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            if (Input.GetKey(KeyCode.UpArrow))
                transform.position += new Vector3(0, -speed * Time.deltaTime, 0);
            else if (Input.GetKey(KeyCode.DownArrow))
                transform.position += new Vector3(0, speed * Time.deltaTime, 0);
            else if (Input.GetKey(KeyCode.LeftArrow))
                transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
            else if (Input.GetKey(KeyCode.RightArrow))
                transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        }
    }
}
