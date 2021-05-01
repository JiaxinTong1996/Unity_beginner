using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    Vector3 offset;
    public Transform player;

    private AudioSource music_back;


    // Start is called before the first frame update
    void Start()
    {
        offset = player.position - transform.position;
        music_back = GetComponent<AudioSource>();
        music_back.Play();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position - offset;
        
    }
}
