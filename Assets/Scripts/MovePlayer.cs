using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    //[SerializeField] private int speed;
    /*private string directionKey;
    private string lastDirectionKey;*/
    
    private float elapsedTime;
    private float desiredDuration = 3f;
    [SerializeField] private Vector2[] endPositions;
    private Vector2 startPosition;
    private Vector2 endPosition;
    private int i = 0;
    private float percentageComplete;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        endPosition = endPositions[1];
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        percentageComplete = elapsedTime / desiredDuration;

        transform.position = Vector2.Lerp(startPosition, endPosition, percentageComplete);

        if (percentageComplete >= 1f)
        {
            i = (i + 1) % endPositions.Length;
            elapsedTime = 0;
            percentageComplete = 0;
            startPosition = endPosition;
            endPosition = endPositions[i];
        }

       
        //HandleMovement();
    }

    // void HandleMovement()
    // {
    //     directionKey = Input.inputString;
    //     if (directionKey != "")
    //     {
    //         lastDirectionKey = directionKey;
    //     }
    //
    //     switch (lastDirectionKey)
    //     {
    //         case "w":
    //             transform.position = new Vector2(transform.position.x,
    //                 transform.position.y + (speed * Time.deltaTime));
    //             break;
    //         case "s":
    //             transform.position = new Vector2(transform.position.x,
    //                 transform.position.y + (-speed * Time.deltaTime));
    //             break;
    //         case "a":
    //             transform.position = new Vector2(transform.position.x + (-speed * Time.deltaTime),
    //                 transform.position.y);
    //             break;
    //         case "d":
    //             transform.position = new Vector2(transform.position.x + (speed * Time.deltaTime),
    //                 transform.position.y);
    //             break;
    //     }
    // }
}