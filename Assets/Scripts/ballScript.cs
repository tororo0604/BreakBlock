using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScript : MonoBehaviour {

    public GameObject ballPrefab;
    public GameObject player;

    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        
        if(Input.GetKeyDown(KeyCode.Space)){
//        if (Input.GetMouseButtonDown (0)) {
            Vector3 pp = GameObject.Find ("player").transform.position;
            Instantiate (ballPrefab,
                new Vector3 (pp.x, pp.y - 0.2f, pp.z + 1),
                Quaternion.identity);
            //           gameObject.GetComponent<Rigidbody> ().AddForce (1000f, 0f, 1000f);
            //gameObject.GetComponent<Rigidbody> ().velocity = new Vector3 (10f, 0f, 10f);
        }
    }


}