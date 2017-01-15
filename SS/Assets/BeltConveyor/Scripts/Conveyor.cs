using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conveyor : MonoBehaviour
{

	public float Speed;         //ベルトコンベアの速さ(上側が左移動で正)
	public float Lengh;         //ベルトコンベアの長さ
	public Vector3 Size;		//コンベアの大きさ

	public int Count;			//カウンタ
	public Vector3 SpownPos;	//スポーン位置

	private void Start()
	{
		SpownPos = transform.localPosition;
		transform.localScale = Size;
	}

	void Update()
	{

		//メッシュのY方向の大きさを取得する
		float sizeY = transform.localScale.y*8;

		//全体の長さを計算する
		float totalLen = Lengh * 2 + sizeY * Mathf.PI;

		//一週回るのにかかる時間の計算
		int totalCount = (int)((totalLen) / Speed);

		Count = (Count + 1) % totalCount;
		//Count++;

		//最初の直線ラインの時
		if (Count < Lengh / Speed)
		{
			//左方向に移動
			transform.rotation = Quaternion.Euler(90, 90, -90);
			Vector3 pos = SpownPos;
			pos.x -= Speed * Count;
			transform.localPosition = pos;
		}
		else if (Count < (Lengh + (sizeY * Mathf.PI) / 2) / Speed)
		{
			//左側の回るとこ
			float omega = Speed / sizeY*2;//角速度の計算
			transform.Rotate(new Vector3(0, -omega * 180 / Mathf.PI, 0));//度に変換し加算する
		}
		else if (Count < (Lengh*2 + (sizeY * Mathf.PI) / 2) / Speed)
		{
			transform.rotation = Quaternion.Euler(270, 0, 0);
			//右方向に移動
			Vector3 pos = SpownPos;
			pos.x -= Speed * ((Lengh * 2 + (sizeY * Mathf.PI) / 2) / Speed - Count);
			transform.localPosition = pos;
		}
		else
		{
			//右側の回るとこ
			float omega = Speed / sizeY*2;//角速度の計算
			transform.Rotate(new Vector3(0, -omega * 180 / Mathf.PI, 0));//度に変換し加算する
		}
	}

}
