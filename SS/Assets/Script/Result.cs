using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Result : MonoBehaviour {
	public Text resultScore;
	public float countUpSpeed;


	void Start()
	{
		ScoreManager.score = 1000;
		DisplayScore();
	}

	void DisplayScore()
	{
		iTween.ValueTo (gameObject, iTween.Hash ("from", 0, "to", ScoreManager.score, "time", 1, "onUpdate", "UpdateScoreDisplay"));
	}

	void UpdateScoreDisplay(int newScore)
	{
		resultScore.text = newScore.ToString();
	}

	public void OnClick()
	{ 
		SceneManager.LoadScene ("Test", LoadSceneMode.Additive);
	}
}
