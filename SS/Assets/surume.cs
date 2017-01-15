using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class surume : MonoBehaviour {
	public Transform goal;
	// Use this for initialization
	void Start () {
		iTween.MoveTo (this.gameObject,iTween.Hash("position", goal.position, "time", 3f));
	}
	

}
