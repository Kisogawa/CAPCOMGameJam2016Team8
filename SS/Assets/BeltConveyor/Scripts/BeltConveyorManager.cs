using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeltConveyorManager : MonoBehaviour {

	public GameObject Conveyor;
	public float Lengh;                 //ベルトコンベアの長さ
	public float Speed;					//ベルトコンベアの速さ

	private void Start()
	{
		//一気にスポーンする
		for (int i = 0; i < Lengh * 3.7; i++)
		{
			Spown(i*60);
		}
	}

	void Spown(int Count)
	{
		var prefab = Instantiate(Conveyor, transform.localPosition, transform.rotation) as GameObject;
		prefab.GetComponent<Conveyor>().Count = Count;
		prefab.GetComponent<Conveyor>().Lengh = Lengh;
		prefab.GetComponent<Conveyor>().Speed = Speed;

	}
}
