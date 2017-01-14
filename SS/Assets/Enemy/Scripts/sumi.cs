using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sumi : MonoBehaviour {

	public static bool Issumi;
	public Canvas sumicanvas;
	public float count;
	public GameObject[] images;

	// Use this for initialization
	void Start () {
		Issumi = false;
	}
	
	// Update is called once per frame
	void Update () {
		sumicanvas.enabled = Issumi;
		if (Issumi) {
			DisplaySumi ();
			Invoke ("Delsumi", count);
		}
	}

	void DisplaySumi(){
		for (int i = 0; i < images.Length; i++) {
			Debug.Log ("p");
			iTween.ScaleTo (images [i], iTween.Hash ("x", 1, "y", 1, "time", 0.5f));
		}
	}

	void Delsumi(){
		for (int i = 0; i < images.Length; i++) {
			images [i].transform.localScale = new Vector3 (0, 0, 1);
		}
		Issumi = false;
	}
}
