using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour {
    
    private bool lockon;
	public int Getscore;
	public Canvas RockonImage;
	public bool Istako;

	public GameObject explosion;
	public GameObject surume;

	// Use this for initialization
	void Start () {
        lockon = false;
		RockonImage.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        Ray Curpos = Camera.main.ScreenPointToRay(Input.mousePosition);


        if (Input.GetMouseButtonDown(1))
        {
            this.lockon = false;
            Debug.Log("lockon false");
        }
		if (Input.GetMouseButtonDown(0) && lockon) {
			ScoreManager.score += Getscore;
			if (Istako) {
				sumi.Issumi = true;
			} else {
				
			}
			GetComponent<Shooting> ().Shoot ();
			Invoke ("Explosion", 0.5f);
			Destroy (gameObject,0.5f);
		}
		RockonImage.enabled = this.lockon;
	}
	void OnMouseOver(){
		if(!sumi.Issumi)
		this.lockon = true;
	}

	void Explosion(){
		Instantiate (surume, transform.position, Quaternion.identity);
		Instantiate (explosion, transform.position, Quaternion.identity);
	}
}
