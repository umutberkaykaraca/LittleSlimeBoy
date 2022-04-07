using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawIsTurning : MonoBehaviour
{

    public float TurnSpeed;

    // The rotation speed of the saw is adjusted in the z-axis.
    void Update()
    {
        transform.Rotate(0,0,TurnSpeed);
    }
}
