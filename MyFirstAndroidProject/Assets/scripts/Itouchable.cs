using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Itouchable 
{
    void OnTap();
    void OnDrag(Ray collidingRay);
    void ChangeColor();
}
