using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeltConveyorManager : MonoBehaviour {

	public GameObject Conveyor;
	public float Lengh;                 //ベルトコンベアの長さ
	public float Speed;                 //ベルトコンベアの速さ
	public Vector3 Size;				//コンベアの大きさ

	private void Start()
	{

		//メッシュのY方向の大きさを取得する
		float sizeY = Size.x*8;

		//全体の長さを計算する
		float totalLen = Lengh * 2 + sizeY * Mathf.PI;

		//一週回るのにかかる時間の計算
		int totalCount = (int)((totalLen) / Speed);

		//コンベアの必要個数を計算する
		int num = (int)(totalLen / (sizeY*1.3));

		//一気にスポーンする
		for (int i = 0; i < num; i++)
		{
			Spown(totalCount*i / num);
		}
	}

	void Spown(int Count)
	{
		var prefab = Instantiate(Conveyor, transform.localPosition, transform.rotation) as GameObject;
		prefab.GetComponent<Conveyor>().Count = Count;
		prefab.GetComponent<Conveyor>().Lengh = Lengh;
		prefab.GetComponent<Conveyor>().Speed = Speed;
		prefab.GetComponent<Conveyor>().Size = Size;

	}
}
