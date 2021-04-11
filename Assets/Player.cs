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
        Vector3 movement = new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0);
        Vector3 direction = movement.normalized;
        Vector3 velocity = direction * speed;
        transform.Translate(velocity * Time.deltaTime);
    }
}
