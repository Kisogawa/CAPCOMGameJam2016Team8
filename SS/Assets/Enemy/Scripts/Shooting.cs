using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {
	//プレハブ
	public	GameObject bullet;
	//弾の発射位置
	public Transform ShootPosition;
	public float bulletTime = 0.5f;
	public void Shoot(){
		var prefab = Instantiate (bullet, ShootPosition.position, Quaternion.identity) as GameObject;
		iTween.MoveTo(prefab,iTween.Hash("position",gameObject.transform.position+new Vector3(-2,0,0),"time",bulletTime,"easeType",iTween.EaseType.linear));
	}


}
