using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerstatus : MonoBehaviour
{
    public int HP;
    public float speed = 10;
    public float turnSpeed = 50f;
    [SerializeField]
    [HideInInspector]
    private int Dmg = 10;

    private void OnCollisionEnter(Collision collision)
    {

        HP -= Dmg;
        Debug.Log("va cham roi");
    }
    }
