using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class translator : MonoBehaviour {
        public float speed = 1;
        public float lenght = 100;
        private float compteur = 0;
        public Vector3 direction;
        // Start is called before the first frame update
        void Start() {

        }

        // Update is called once per frame
        void Update() {
            compteur += 1;
            if (compteur > 10 * lenght) { compteur = 0; }
            if (compteur > 10 * lenght / 2) { transform.Translate(direction * Time.deltaTime * speed); }
            if (compteur < 10 * lenght / 2) { transform.Translate(-direction * Time.deltaTime * speed); }
        }
}
