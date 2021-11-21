using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Rendersoton : MonoBehaviour
{
    // Start is called before the first frame update
    public float maxTime=1;
    private float timer = 0;
    public GameObject sotonbox;
    public float height;
    void Start()
    {
        GameObject newsoton = Instantiate(sotonbox);
        newsoton.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    // Update is called once per frame
    void Update()
    {

        if (timer > maxTime)
        {
            GameObject newsoton = Instantiate(sotonbox);
            newsoton.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newsoton,15);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
