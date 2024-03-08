using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveRB: MonoBehaviour
{
    Rigidbody rb;
    public int speed = 3;
    void Start()
{
    rb = GetComponent<Rigidbody>();
}
    void FixedUpdate()
{ 
    float horizontal = Input.GetAxis("Horizontal");
    float vertical = Input.GetAxis("Vertical");

    Vector3 move = new Vector3(horizontal, 0, vertical);
    rb.MovePosition(transform.position + move*Time.deltaTime*speed);
}


}