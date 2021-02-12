using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    float h;
    float v;
    Rigidbody rb;
    public int speed;
    public Text Count;
    public Text Win;
    public Button restart_btn;

    AudioSource au;
    MeshRenderer rend;
    
    
    int count;
    int collections_count;
    // Start is called before the first frame update
    void Start()
    {
        au = GetComponent<AudioSource>();
        rb = this.GetComponent<Rigidbody>();
        rend = GetComponent<MeshRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        h=Input.GetAxis("Horizontal");
        v=Input.GetAxis("Vertical");
        Count.text = "Count :" + count;
        
    }
    private void FixedUpdate()
    {
        Vector3 force = new Vector3(h,0,v);
        force *= speed;
        rb.AddForce(force *Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
      
        if (other.tag == "collection")
        {
            Destroy(other.gameObject);
            au.Play();
            count++;
            collections_count++;
            if (collections_count % 2 == 1)
            {
                rend.GetComponent<MeshRenderer>().material.color = Color.yellow;
                rend.transform.localScale = new Vector3(1.3f, 1.3f, 1.3f);//
            }
            else {
                rend.GetComponent<MeshRenderer>().material.color = Color.white;
                rend.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);//
            }
            if (collections_count == 8)
            {
                restart_btn.gameObject.SetActive(true);
                Win.gameObject.SetActive(true);
            }
        }
        if (other.tag == "lose")
        {
            Destroy(other.gameObject);
            count--;
          
        }
    }

   
}
