using UnityEngine;

public class SpawnManager : MonoBehaviour
{

	//イカ、ダイオウイカ、タコの順
    public GameObject[] Characters;
    public float spawnTime; 
	public float spawnTime_min;
    public Transform spawnPoint;
	int wave;
	public float waveInterval = 10;
	public float reducePerWave = 0.5f;
	float waveTimer;
	float timer;

	public float daiouIkaProb;
	public float takoProb;

	void Update()
	{
		timer += Time.deltaTime;
		waveTimer += Time.deltaTime;
		setWave ();

		if(timer > Mathf.Max(spawnTime_min,spawnTime - wave*reducePerWave))
		{
			Spawn ();
			timer = 0;
		}
	}

	void setWave()
	{
		if (waveTimer > waveInterval) 
		{
			wave++;
			waveTimer = 0;
		}
	}

	void Spawn()
	{
		GameObject spawnCharacter = null;

		if (Random.value < daiouIkaProb) 
		{
			spawnCharacter = Characters [1];
		}
		if (Random.value < takoProb) 
		{
			spawnCharacter = Characters [2]; 
		}

		if (!spawnCharacter)
		{
			spawnCharacter = Characters [0];
		}


		var prefab = Instantiate (spawnCharacter, spawnPoint.position, spawnPoint.rotation) as GameObject;
		prefab.transform.SetParent (transform);
	}
}
