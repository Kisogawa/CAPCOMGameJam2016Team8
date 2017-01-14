using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Title : MonoBehaviour {
	public float count = 3.5f;
	public Text countText;
	public string playerName;
	public GameObject spawnManager;
	bool isStarted = false;
	public Result result;

	public GameObject startButton;
	public GameObject inputField;
	public Text inputFieldText;
	public GameObject timer;

	// Use this for initialization
	void Start () {

	}



	// Update is called once per frame
	void Update () {
		if (isStarted) {
			count -= Time.deltaTime;
			countText.text = count.ToString ("N0");
		}
	}
		
	public void OnClickStart()
	{
		countText.gameObject.SetActive(true);
		isStarted = true;
		Invoke("SetUp",3f);
	}

	public void InputLogger() {
		startButton.SetActive (true);
		playerName = inputFieldText.text;
		result.playerName.text = playerName;
		Debug.Log(playerName);
		inputField.SetActive (false);
	}
		
	void SetUp()
	{
		timer.SetActive (true);
		spawnManager.SetActive (true);
		gameObject.SetActive(false);
	}
}
