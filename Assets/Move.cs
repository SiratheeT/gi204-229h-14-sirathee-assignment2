using UnityEngine;
using System.Collections;
public class move : MonoBehaviour { 
    public float speed = 2;

    void Update() {
        if (Input.GetKey(KeyCode.W)) {
            transform.Translate(0, -speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.S)) { 
            transform.Translate(0, speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.A)) { 
        transform.Translate(speed*Time.deltaTime,0,0);
        }
        if (Input.GetKey(KeyCode.D)) {
         transform.Translate(-speed*Time.deltaTime,0,0); 
        }
    }
}