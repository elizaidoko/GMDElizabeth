using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour, Itouchable
{
    public void OnDrag(Ray collidingRay)
    {
        throw new System.NotImplementedException();
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
        throw new System.NotImplementedException("Sphere tapped");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
