using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pug : Dogs
{
    private float speedP = 2;

    // POLYMORPHISM
    protected override void DogMoveForward()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speedP);
    }

    // POLYMORPHISM
    protected override void SpecialMove(bool tf)
    {
        if (tf)
        {
            Debug.Log("Woof!");
        }
    }
}

