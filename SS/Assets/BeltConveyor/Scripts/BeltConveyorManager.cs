using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeltConveyorManager : MonoBehaviour {

	public GameObject Conveyor;
	public float Timer;
    public float Interval;
    public Transform SpawnPosition;

    void Update () {
		Timer += Time.deltaTime;

		if (Timer > Interval)
		{
            Spown();
            Timer = 0;
        }

	}

    void Spown()
    {
        var prefab = Instantiate(Conveyor, SpawnPosition.position, SpawnPosition.rotation) as GameObject;
    }
}
