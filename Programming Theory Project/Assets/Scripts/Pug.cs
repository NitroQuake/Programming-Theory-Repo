using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pug : Dogs
{
    private float speedP = 2;
    public GameObject bone;

    protected override void DogMoveForward(float speed)
    {
        base.DogMoveForward(speedP);
    }

    protected override void SpecialMove(bool tf)
    {
        if (tf)
        {
            Debug.Log("Woof!");
        }
    }
}

