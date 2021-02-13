using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraController : MonoBehaviour
{
    Vector3 offset;
    public Transform player;
    AudioSource background;//
    // Start is called before the first frame update
    void Start()
    {
        offset = player.position - transform.position;
        background = GetComponent<AudioSource>();
        background.Play();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position - offset;

    }
    public void Restart()
    {
        SceneManager.LoadScene("SampleScene",LoadSceneMode.Single);
    }

}
