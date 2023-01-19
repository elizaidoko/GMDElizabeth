using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit_script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch[] myTouches = Input.touches;
            Touch myFirstTouch = myTouches[0];
            print(myFirstTouch.position);
            Ray myRay = Camera.main.ScreenPointToRay(myFirstTouch.position);
            Debug.DrawRay(myRay.origin, 15 * myRay.direction);
            RaycastHit hitInfo;
            if (Physics.Raycast(myRay, out hitInfo))
            {
                //make object you touch move up 1 by y
                //print("hit");
                //hitInfo.transform.position += Vector3.up*Time.deltaTime;
                spaceship_script touched_spaceship = hitInfo.transform.GetComponent<spaceship_script>();
                touched_spaceship.changeColor(Color.red);
                
            }
            
            //acceleration += 15 * Vector3.up;
        }
    }
}
