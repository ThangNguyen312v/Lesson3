using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    protected Rigidbody Cube;
    // Start is called before the first frame update
    void Start()
    {
        Cube = GetComponent<Rigidbody>();
        Cube.velocity = new Vector3(10, 10, 0);
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
