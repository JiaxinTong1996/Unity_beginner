using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerControlller : MonoBehaviour
{

    float x;
    float z;
    float y;
    Rigidbody rb;
    public int speed;

    public Text Count;
    public Text Win;
    public Text Fail;
    public Button Restart_btn;
    private AudioSource music_coin;
    
    int count;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        music_coin = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");
        y = Input.GetAxis("Jump");
        Count.text = "Count : " + count;
    }
    private void FixedUpdate()
    {
        Vector3 force = new Vector3(x,y*10,z);
        force *= speed;
        rb.AddForce(force);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Water")
        {
            Restart_btn.gameObject.SetActive(true);
            Fail.gameObject.SetActive(true);
        }


        if (other.tag == "C")
        {
            music_coin.Play();
            Destroy(other.gameObject);
            count++;
            if (count == 4)
            {
                //win
                Restart_btn.gameObject.SetActive(true);
                Win.gameObject.SetActive(true);
            }
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene("SampleScene",LoadSceneMode.Single);
    }
}
