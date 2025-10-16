using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enumy : MonoBehaviour
{
    public float speed;
    Rigidbody enumyRb;
    GameObject player;

    void Start()
    {
        enumyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");    
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = ((player.transform.position - transform.position).normalized);
        enumyRb.AddForce(lookDirection * speed);
    }
}
