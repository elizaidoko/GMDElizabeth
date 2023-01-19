using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceship_script : MonoBehaviour
{
    Vector3 acceleration, velocity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        

        if(Input.touchCount > 0)
        {
            //Touch[] myTouches = Input.touches;
            //Touch myFirstTouch = myTouches[0];
            //print(myFirstTouch.position);
            //Ray myRay = Camera.main.ScreenPointToRay(myFirstTouch.position);
            //Debug.DrawRay(myRay.origin, 15 * myRay.direction);
            //if (Physics.Raycast(myRay))
            //{
            //    print("hit");
            //}
            //acceleration += 15 * Vector3.up;
        }

        velocity += acceleration * Time.deltaTime; // v = u + at

        transform.position += velocity * Time.deltaTime;// s = ut
        
    }

    internal void changeColor(Color color)
    {
        GetComponent<Renderer>().material.color = color; ;
    }
}
