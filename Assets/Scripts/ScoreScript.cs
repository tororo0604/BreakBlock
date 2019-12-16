using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {
    // スコアを表示する
    public Text scoreText;
    // ハイスコアを表示する
    public Text highScoreText;

    // スコア
    public int score;
    // ハイスコア
    public int highScore;
    
    private string highScoreKey = "HIGH_SCORE";

    // Start is called before the first frame update
    void Start () {
        highScore = PlayerPrefs.GetInt (highScoreKey, 0);
        highScoreText.text = highScore.ToString ();
    }

    // Update is called once per frame
    void Update () {

        if (score > highScore) {
            highScore = score;
            highScoreText.text = highScore.ToString ();
            PlayerPrefs.SetInt (highScoreKey, highScore);
        }
        if (scoreText.text != score.ToString ()) {
            scoreText.text = score.ToString ();
        }
    }

    public void addScore () {
        score += 100;
    }

}