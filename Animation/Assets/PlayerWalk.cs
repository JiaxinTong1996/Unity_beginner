using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    //float h;
    //float v;
    //Rigidbody rb;
    //public int speed;
    public Animator animator;
    // Start is called before the first frame update
    
    void Start()
    {
        //rb = this.GetComponent<Rigidbody>(); 
    }
    
    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
        Vector3 horizontal = new Vector3(0.05f, 0.0f, 0.0f);
        if (transform.position.x < 3)
        {
            transform.position = transform.position + horizontal;
        }
        
        //h = Input.GetAxis("Horizontal");
        //v = Input.GetAxis("Vertical");

    }
    /*
    private void FixedUpdate()
    {
        Vector2 force = new Vector2(h,v);
        force *= speed;
        rb.AddForce(force);
    }
    */
}
