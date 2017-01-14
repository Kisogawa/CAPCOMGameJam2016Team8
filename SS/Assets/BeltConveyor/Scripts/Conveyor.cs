using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conveyor : MonoBehaviour {

    public float Timer;
    public float Interval;
    public float MoveSpeedX;    //移動速度(左方向が正)
    public float DelTime;       //消える位置

    private Vector3 m_pos;  //ゲームオブジェクトの位置

    void Start()
    {
        m_pos = transform.localPosition;  // 形状位置を保持
    }

    void Update () {
        Timer += Time.deltaTime;

        if (Timer > Interval)
        {
            m_pos.x -= MoveSpeedX;
            transform.localPosition = m_pos;  // 形状位置を更新
            Timer = 0;
        }
    }
}
