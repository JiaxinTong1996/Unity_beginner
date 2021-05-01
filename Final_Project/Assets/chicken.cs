using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chicken : MonoBehaviour
{
    float x;
    float z;
    float y;
    Rigidbody rb;
    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");
        y = Input.GetAxis("Jump");
    }
    private void FixedUpdate()
    {
        Vector3 force = new Vector3(x, y * 10, z);
        force *= speed;
        rb.AddForce(force);
    }
}
