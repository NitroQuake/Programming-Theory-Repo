using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GermanShepherd : Dogs
{
    private float speedGS = 6;
    public GameObject bone;

    protected override void DogMoveForward(float speed)
    {
        base.DogMoveForward(speedGS);
    }

    protected override void SpecialMove(bool tf)
    {
        bone.SetActive(tf);
    }
}
