using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    public float moveForce;
    private Rigidbody rb;
    private float xAxis;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        xAxis = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        xAxis = Input.GetAxis("Horizontal");
        
    }

    void FixedUpdate()
    {
        Vector3 force = new Vector3(xAxis * moveForce, 0f, 0f);
        rb.AddForce(force);

        if (xAxis == 0)
        {
            transform.position = new Vector3(transform.position.x, 11.2f, transform.position.z);

        }
        else
        {
            transform.position = new Vector3(transform.position.x, 10f, transform.position.z);
        }
    }
}
