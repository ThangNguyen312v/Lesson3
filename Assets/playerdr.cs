using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerdr : MonoBehaviour
{
    public playerstatus Playerstatus;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        // Điều chỉnh inertia tensor
        rb.inertiaTensor = new Vector3(1, 1, 1); // Điều chỉnh giá trị này tùy theo nhu cầu
        rb.inertiaTensorRotation = Quaternion.identity;
    
        Playerstatus = FindAnyObjectByType<playerstatus>();
    }
    void Update()
    {
        float moveDirection = Input.GetAxis("Vertical") * Playerstatus.speed * Time.deltaTime;
        float turnDirection = Input.GetAxis("Horizontal") * Playerstatus.turnSpeed * Time.deltaTime;

        transform.Translate(0, 0, moveDirection);
        transform.Rotate(0, turnDirection, 0);
    }
}
