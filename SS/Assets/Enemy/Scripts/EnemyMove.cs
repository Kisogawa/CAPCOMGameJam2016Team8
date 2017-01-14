using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

	public float Speed;
	Vector3 position;
	// Use this for initialization
	void Start () {
		position = transform.localPosition;
		transform.localPosition = position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.localPosition +=new Vector3 (Speed,0,0);
	}
}
