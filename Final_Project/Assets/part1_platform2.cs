using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class part1_platform2 : MonoBehaviour
{
    float initpos = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rot = new Vector3(0, Mathf.PingPong(initpos, 1), 0);
        
       

    }
}
