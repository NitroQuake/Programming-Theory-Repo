using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beagle : Dogs
{
    private Rigidbody beagleRb;
    private float jumpForce = 10;

    protected override void SpecialMove(bool tf)
    {
        if (tf)
        {
            beagleRb = GetComponent<Rigidbody>();

            beagleRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
