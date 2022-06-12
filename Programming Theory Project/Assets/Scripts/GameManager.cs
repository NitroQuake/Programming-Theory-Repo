using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] dogs;
    private float posY = 42.0333f;
    private float posZ = -31.5f;
    private float startDelay = 3;
    private float repeatRate = 2;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("RandomDog", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void RandomDog()
    {
        float randomX = Random.Range(-58, -49);
        Vector3 positon = new Vector3(randomX, posY, posZ);
        int index = Random.Range(0, dogs.Length);
        Instantiate(dogs[index], positon, transform.rotation);
    }
}
