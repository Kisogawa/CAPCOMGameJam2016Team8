using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sumi : MonoBehaviour {

	public static bool Issumi;
	public Canvas sumicanvas;
	public float count;

	// Use this for initialization
	void Start () {
		Issumi = false;
	}
	
	// Update is called once per frame
	void Update () {
		sumicanvas.enabled = Issumi;
		if(Issumi)
		Invoke ("Delsumi", count);
			

	}
	void Delsumi(){
		Issumi = false;
	}
}
