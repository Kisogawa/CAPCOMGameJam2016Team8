using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {
	//プレハブ
	public	GameObject bullet;
	//弾の発射位置
	public Transform ShootPosition;
	public float bulletTime = 1;
	public void Shoot(){
		var prefab = Instantiate (bullet, ShootPosition.position, Quaternion.identity) as GameObject;
		iTween.MoveTo(prefab,iTween.Hash("position",gameObject.transform.position,"time",bulletTime,"easeType",iTween.EaseType.linear));
	}


}
