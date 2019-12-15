using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour {
    GameObject player;
    GameObject yuka;
    float playableRange;
    // Start is called before the first frame update
    void Start () {
        player = GameObject.Find ("player");
        yuka = GameObject.Find ("Yuka");
        playableRange = yuka.transform.localScale.x - player.transform.localScale.x;
    }

    // Update is called once per frame
    void Update () {
        if (player.transform.position.x <= playableRange / 2) {
            if (Input.GetKey (KeyCode.RightArrow)) {
                transform.position += transform.right * 0.1f;
            }
        }
        if (player.transform.position.x >= -playableRange / 2) {
            if (Input.GetKey (KeyCode.LeftArrow)) {
                transform.position -= transform.right * 0.1f;
            }
        }
    }
}