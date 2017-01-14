using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cureffect : MonoBehaviour {

    private Vector3 pos;


	// Use this for initialization
	void Start () {
        pos = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {
        pos = Input.mousePosition;
        pos.z = 30.0f;
        pos = Camera.main.ScreenToWorldPoint(pos);
        transform.position = pos;
	}
}
