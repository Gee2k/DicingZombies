using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDice : MonoBehaviour
{

    static Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space))
        {
            float dirX = Random.Range(0, 30);
            float dirY = Random.Range(0, 30);
            float dirZ = Random.Range(0, 30);
            transform.position = new Vector3(0, 0.2f, 0);
            transform.rotation = Quaternion.identity;
            rb.AddForce(transform.up * 10);
            rb.AddTorque(dirX, dirY, dirZ);
        }
    }
}
