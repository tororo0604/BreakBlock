using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockCreate : MonoBehaviour {

    public GameObject blockPrefab;

    void Awake() {
        GameMaster gameMaster
         = GameObject.Find("Master").GetComponent<GameMaster>();
        ScoreScript scoreScript
         = GameObject.Find("ScoreArea").GetComponent<ScoreScript>();
        for (int x = 0; x < 8; x++) {
            for (int z = 0; z < 5; z++) {
                GameObject block = Instantiate (blockPrefab,
                    new Vector3 (-4.2f + 1.2f * x, 0f, 9f - 1f * z),
                    Quaternion.identity);
                block.GetComponent<blockScript>().gameMaster = gameMaster;
                block.GetComponent<blockScript>().scoreScript = scoreScript;
                
            }
        }
    }

    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {

    }

}