using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour {
    public int blockNum;
    public int ballNum;
    public int ballLife;
    public Text ballLifeText;
    private string highScoreKey = "HIGH_SCORE";

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

        if(ballLifeText.text != ballLife.ToString()){
            ballLifeText.text = ballLife.ToString();
        }
    }

    public void GameOver() {
        SceneManager.LoadScene("ResultScene");
    }
    public void Reset(){
        SceneManager.LoadScene("GameScene");
        ScoreScript scoreScript = GameObject.Find("ScoreArea").GetComponent<ScoreScript>();
        PlayerPrefs.SetInt (highScoreKey, 0);
        scoreScript.highScore = 0;
    }
    public void GoTitle(){
        SceneManager.LoadScene("TitleScene");
    }
}