using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour {
    
    private bool lockon;
    

	// Use this for initialization
	void Start () {
        lockon = false;
	}
	
	// Update is called once per frame
	void Update () {
        Ray Curpos = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        //Debug.Log(Curpos.direction.x);

        if (Physics.Raycast(Curpos, out hit, 100.0f))
        {
            lockon = true;
            Debug.Log("lockon true");
        }

        if (Input.GetMouseButtonDown(1))
        {
            lockon = false;
            Debug.Log("lockon false");
        }
	}
}
