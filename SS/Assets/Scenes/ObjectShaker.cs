using UnityEngine;
using System.Collections;

public class ObjectShaker : MonoBehaviour {
	public GameObject cam;


	public void Shake(){
		iTween.ShakePosition(cam,iTween.Hash("x",0.3f,"y",0.3f,"time",0.5f));
	}

}