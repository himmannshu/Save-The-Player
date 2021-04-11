using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{
    float speed = 0.1f;

    float screenWidth;

    void Start()
    {

        float randomNum = Random.Range(1, 3);
        transform.localScale = new Vector3(randomNum, randomNum, randomNum);
        transform.rotation = Quaternion.Euler(0, 0, Random.Range(-5, 5));
        /*      screenWidth = Camera.main.aspect * Camera.main.orthographicSize;
                Vector2 direction = new Vector2(Random.Range(-screenWidth, screenWidth), Random.Range(-Camera.main.orthographicSize, -Camera.main.orthographicSize / 3));
                velocity = speed * direction.normalized;
         */
    }

    void Update()
    {
        if (transform.position.y < -Camera.main.orthographicSize)
        {
            Destroy(gameObject);
        }


        transform.Translate(Vector2.down * speed);
    }
}
