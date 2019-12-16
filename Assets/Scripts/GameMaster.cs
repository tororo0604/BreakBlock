using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour {
    public int blockNum;
    public int ballNum;
    public int ballLife;

    // Start is called before the first frame update
    void Start () {
        ballLife = 10;
    }

    // Update is called once per frame
    void Update () {
        if(ballLife == 0 || blockNum == 0){
            GameOver();
        }

        if(Input.GetKeyDown(KeyCode.R)){
            Reset();
        }
        if(Input.GetKeyDown(KeyCode.T)){
            GoTitle();
        }
    }

    public void GameOver() {
        SceneManager.LoadScene("ResultScene");
    }
    public void Reset(){
        SceneManager.LoadScene("GameScene");
    }
    public void GoTitle(){
        SceneManager.LoadScene("TitleScene");
    }
}