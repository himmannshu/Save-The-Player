using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public float speed = 5;

    void Start()
    {

    }


    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        Vector2 velocity = Vector2.right * x * speed;

        /* If the object reaches  ... */

        float screenWidth = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).x;
        float screenRight = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, 0)).x;

        if (transform.position.x < screenRight && transform.position.x > screenWidth)
        {
            transform.Translate(velocity * Time.deltaTime);
        }
        else if (transform.position.x >= screenRight)
        {
            transform.position = new Vector2(screenWidth + transform.localScale.x / 2f, transform.position.y);
        }
        else if (transform.position.x <= screenWidth)
        {
            transform.position = new Vector2(screenRight - transform.localScale.x / 2f, transform.position.y);
        }

    }
}
