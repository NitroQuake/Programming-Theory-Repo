using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GermanShepherd : Dogs
{
    private float speedGS = 6;
    public GameObject bone;

    // POLYMORPHISM
    protected override void DogMoveForward()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speedGS);
    }

    // POLYMORPHISM
    protected override void SpecialMove(bool tf)
    {
        bone.SetActive(tf);
    }
}
