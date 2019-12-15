using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScript : MonoBehaviour {

    public GameMaster gameMaster;

    // Start is called before the first frame update
    void Start () {
        //gameObject.GetComponent<Rigidbody> ().AddForce (1000f, 0f, 1000f);
        gameObject.GetComponent<Rigidbody> ().velocity
         = new Vector3 ((Random.value - 0.5f) * 20f, 0f, 10f);
        gameMaster.ballNum++;
    }

    // Update is called once per frame
    void Update () {
        Vector3 tmp = this.transform.position;
        if (tmp.y < -1) {
            gameMaster.ballNum--;
            gameMaster.ballLife--;
            Destroy (gameObject);
        }
    }

    void OnCollisionEnter (Collision col) {
        if (col.gameObject.tag == "deadZone") {
            gameMaster.ballNum--;
            gameMaster.ballLife--;
            Destroy (gameObject);
        }
    }

}