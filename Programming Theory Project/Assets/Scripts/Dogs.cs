using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Dogs : MonoBehaviour
{
    private Animator dogAn;
    private float speed = 4;
    private float startDelay = 2.0f;
    private float repeatRate = 5.0f;
    private bool canMoveForward = true;
    private int zBorder = 45;

    // Start is called before the first frame update
    void Start()
    {
        dogAn = GetComponent<Animator>();
        InvokeRepeating("DogBark", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        DogMoveForward(speed);

        if(transform.position.z > zBorder)
        {
            Destroy(gameObject);
        }
    }

    protected virtual void DogMoveForward(float speed)
    {
        if (canMoveForward)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
    }

    private void DogBark()
    {
        SpecialMove(true);
        canMoveForward = false;
        dogAn.SetBool("Bark_b", true);
        StartCoroutine(BarkTime());
    }

    IEnumerator BarkTime()
    {
        yield return new WaitForSeconds(2);
        dogAn.SetBool("Bark_b", false);
        canMoveForward = true;
        SpecialMove(false);
    }

    protected abstract void SpecialMove(bool tf);
}
