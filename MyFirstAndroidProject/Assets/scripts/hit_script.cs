using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit_script : MonoBehaviour
{
    float timer;
    bool hasMoved = false;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0) //if first finger is on screen
        {

            Touch[] myTouches = Input.touches;
            Touch myFirstTouch = myTouches[0];
            print(myFirstTouch.position);
            timer += Time.deltaTime;
            switch (myFirstTouch.phase)
            {
                case TouchPhase.Began:

                    timer = 0;
                    break;

                case TouchPhase.Stationary:
                    break;

                case TouchPhase.Moved:
                    //try making it move with finger
                    Ray ray = Camera.main.ScreenPointToRay(myFirstTouch.position);
                    RaycastHit hit;
                    if (Physics.Raycast(ray, out hit))
                    {
                        Itouchable touched_object = hit.transform.GetComponent<Itouchable>();

                        float distance = Vector3.Distance(Camera.main.transform.position, hit.transform.position);
                    }
                    hasMoved = true;
                    break;

                case TouchPhase.Ended:
                    if(timer < 1 && !hasMoved)
                    {
                        hasMoved = true;
                        Ray myRay = Camera.main.ScreenPointToRay(myFirstTouch.position);
                        Debug.DrawRay(myRay.origin, 15 * myRay.direction);
                        RaycastHit hitInfo;
                        if (Physics.Raycast(myRay, out hitInfo))
                        {
                            //make object you touch move up 1 by y
                            //print("hit");
                            //hitInfo.transform.position += Vector3.up*Time.deltaTime;
                            Itouchable touched_object = hitInfo.transform.GetComponent<Itouchable>();

                            touched_object.ChangeColor();
                            if (touched_object is spaceship_script)
                            {
                                //touched_object as spaceship_script
                            }
                            touched_object.OnTap();

                        }
                    }

                    break;
            }

            

            
            
            //acceleration += 15 * Vector3.up;
        }
    }
}
