using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballCreate : MonoBehaviour {

    public GameObject masterObj;
    public GameObject ballPrefab;
    public GameObject player;
    public GameMaster gameMaster;


    // Start is called before the first frame update
    void Start () {
        masterObj = GameObject.Find ("Master");
        gameMaster = masterObj.GetComponent<GameMaster>();
    }

    // Update is called once per frame
    void Update () {

        Vector3 pp = GameObject.Find ("player").transform.position;
        if (Input.GetKeyDown (KeyCode.Space)) {
            // if (Input.GetMouseButtonDown (0)) {
            if (gameMaster.ballNum < gameMaster.ballLife) {
                GameObject ball = Instantiate (ballPrefab,
                    new Vector3 (pp.x, pp.y - 0.2f, pp.z + 1),
                    Quaternion.identity);
                ball.GetComponent<ballScript> ().gameMaster = gameMaster;
                //gameObject.GetComponent<Rigidbody> ().AddForce (1000f, 0f, 1000f);
                //gameObject.GetComponent<Rigidbody> ().velocity = new Vector3 (10f, 0f, 10f);
            }
        }
    }

}