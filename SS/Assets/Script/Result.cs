using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Result : MonoBehaviour {
	public Text resultScore;
	public Text playerName;
	public float countUpSpeed;


	void Start()
	{
		DisplayScore();
	}

	void DisplayScore()
	{
		iTween.ValueTo (gameObject, iTween.Hash ("from", 0, "to", ScoreManager.score, "time", 1, "onUpdate", "UpdateScoreDisplay"));
	}

	void UpdateScoreDisplay(int newScore)
	{
		resultScore.text = newScore.ToString()+"円";
	}

	public void OnClick()
	{ 
		SceneManager.LoadScene ("Main");
	}
}
