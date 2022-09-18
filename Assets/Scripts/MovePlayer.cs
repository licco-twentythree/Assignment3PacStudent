using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] private int speed;
    private string directionKey;

    private string lastDirectionKey;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovement();
    }

    void HandleMovement()
    {
        directionKey = Input.inputString;
        if (directionKey != "")
        {
            lastDirectionKey = directionKey;
        }

        switch (lastDirectionKey)
        {
            case "w":
                transform.position = new Vector2(transform.position.x,
                    transform.position.y + (speed * Time.deltaTime));
                break;
            case "s":
                transform.position = new Vector2(transform.position.x,
                    transform.position.y + (-speed * Time.deltaTime));
                break;
            case "a":
                transform.position = new Vector2(transform.position.x + (-speed * Time.deltaTime),
                    transform.position.y);
                break;
            case "d":
                transform.position = new Vector2(transform.position.x + (speed * Time.deltaTime),
                    transform.position.y);
                break;
        }
    }
}