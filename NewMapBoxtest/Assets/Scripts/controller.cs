using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour {


    public float speed = 5;
    public int hauteur = 0;
    private Rigidbody rb;
    public Transform myChildObject;
    public Transform myParentObject;
    public bool detachChild = false;
    public ParticleSystem particles;
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

        if (Input.GetKey(KeyCode.M)) {
                particles.Pause();
                myChildObject.parent = null;
        }
        if (Input.GetKey(KeyCode.N)) {
            myChildObject.transform.parent = myParentObject.transform;
            myChildObject.transform.localPosition = new Vector3(0, 0, 0);
            myChildObject.transform.localRotation = new Quaternion(0, 0, 0, 0);
            particles.Play();
            
        }
    }
}
