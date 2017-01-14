using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//テキストにくっつける
public class Timer : MonoBehaviour {
	Text text;
	bool isTimeOver;
	public GameObject resultcanvas;
	public float limitTime;


	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		limitTime -= Time.deltaTime;
		text.text = "残り"+limitTime.ToString("N1");
		if(limitTime <= 0){
			Timeover();
			text.text = " ";
		}
	}
	void Timeover(){
		resultcanvas.SetActive (true);
	}

}
