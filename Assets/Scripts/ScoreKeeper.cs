using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;				//	We need this in order to handle the Text object

public class ScoreKeeper : MonoBehaviour {
    public GameObject bossFormation;
    public GameObject enemyFormation;
	public static int score = 0;			//	Player's score
	public Text scoreText;					//	So we can modify the score's Text

	// Use this for initialization
	void Start () {
		Reset ();
		scoreText.text = score.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		if(score >= 150*14)
        {
            bossFormation.SetActive(true);
            enemyFormation.SetActive(false);
        }
	}

	public void Score(int points) {
		score += points;
		scoreText.text = score.ToString ();
	}

	public static void Reset() {
		score = 0;
		// scoreText.text = score.ToString ();
	}
}
