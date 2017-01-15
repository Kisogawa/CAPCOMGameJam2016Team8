using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sumi : MonoBehaviour {
	public AudioSource sumiSound;
	public AudioClip sound;
	public static bool Issumi;
	public Canvas sumicanvas;
	public float count;
	public GameObject[] images;
	bool Isplaysound;
	bool isdel;
	bool issize;

	// Use this for initialization
	void Start () {
		Issumi = isdel = false;
		Isplaysound = false;
		issize = false;
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (Issumi);
		sumicanvas.enabled = Issumi;
		if (Issumi) {
			Playsound ();
			DisplaySumi ();
			oncedelsumi ();
		}
	}

	void DisplaySumi(){
		if (!issize) {
			for (int i = 0; i < images.Length; i++) {
				iTween.ScaleTo (images [i], iTween.Hash ("x", 1, "y", 1, "time", 0.3f));
			}
			issize = true;
		}
	}

	void Delsumi(){
		for (int i = 0; i < images.Length; i++) {
			images [i].transform.localScale = new Vector3 (0, 0, 1);
		}
		Issumi = false;
		isdel = false;
		Isplaysound = false;
		issize = false;
	}
	void Playsound(){
		if (!Isplaysound) {
			Debug.Log ("a");
			Isplaysound = true;
			SeManager.Instance.Play ("magic-poison1");
		}
	}

	void oncedelsumi (){
		if (!isdel) {
			isdel = true;
			Invoke ("Delsumi", count);
		}
	}
}
