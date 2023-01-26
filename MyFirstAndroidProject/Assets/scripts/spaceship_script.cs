using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceship_script : MonoBehaviour, Itouchable
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

    public void ChangeColor()
    {

        if (GetComponent<Renderer>().material.color == Color.black)
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        else
            GetComponent<Renderer>().material.color = Color.black;
    }

    public void OnTap()
    {
        throw new NotImplementedException("IDk how this is a spaceship");
    }

    public void OnDrag(Ray collidingRay)
    {
        throw new NotImplementedException();
    }
}
