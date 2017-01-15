using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMarker : MonoBehaviour {

	private int Counter = 0;
	private Vector3 tmp;        //サイズを設定する際の一時変数

	void Start()
	{
	}
	// Update is called once per frame
	void Update ()
	{
		Counter++;//カウントを進める
		if (!GetComponent<Canvas>().enabled)
		{
			Counter = 0;
			return;
		}
		float size = 0;
		size = Counter * 0.3f;
		if (size > 3) size = 3;

		//サイズを変更する
		tmp.x = size;
		tmp.y = size;
		tmp.z = size;
		transform.localScale = tmp;
	}
}
