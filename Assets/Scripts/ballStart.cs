using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballStart : MonoBehaviour {
    // Start is called before the first frame update
    void Start () {
        //gameObject.GetComponent<Rigidbody> ().AddForce (1000f, 0f, 1000f);
        gameObject.GetComponent<Rigidbody> ().velocity = new Vector3 (10f, 0f, 10f);
    }

    // Update is called once per frame
    void Update () {
        Vector3 tmp = this.transform.position;
        if(tmp.y < -1){
            Destroy(gameObject);
        }

    }

    void OnCollisionEnter (Collision col) {
        if (col.gameObject.tag == "deadZone") {
            Destroy (this.gameObject);
        }
    }

}