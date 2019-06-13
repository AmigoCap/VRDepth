using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour {


    public float speed = 5;
    public int hauteur = 0;
    private Rigidbody rb;

    void Start() {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate() {
        hauteur = 0;
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.X)) {
            hauteur = -1;
        }
        if (Input.GetKey(KeyCode.Z)) {
            hauteur = 1;
        }
        Vector3 movement = new Vector3(moveHorizontal, hauteur, moveVertical);
        transform.Translate(movement * Time.deltaTime * speed);

  
    }
}