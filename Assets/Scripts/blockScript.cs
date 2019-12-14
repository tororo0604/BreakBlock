using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockScript : MonoBehaviour {

    public GameObject blockPrefab;

    // Start is called before the first frame update
    void Start () {
        for (int x = 0; x < 8; x++) {
            for (int z = 0; z < 5; z++) {
                Instantiate (blockPrefab,
                    new Vector3 (-4.2f + 1.2f * x, 0f, 9f - 1f * z),
                    Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update () {
        
    }

}