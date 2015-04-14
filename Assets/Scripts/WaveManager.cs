using UnityEngine;
using System.Collections;

public class WaveManager : MonoBehaviour {

	public int wavesCount;
	public float iniPause;
	public GameObject[] Enemies;
	public float Cooldown;
	public float waveTime;
	public float cdDecrement;

	private float stopwatch;
	private GameObject[] enemies;
	

	// Use this for initialization
	void Start () {
		InvokeRepeating("Spawn", iniPause, Cooldown);
		stopwatch = 0f;
		enemies = (GameObject[])Enemies.Clone();
	}
	
	// Update is called once per frame
	void Update () {
		stopwatch += Time.deltaTime;
		if(stopwatch >= waveTime)
		{
			stopwatch = 0f;
			CancelInvoke();

			//Уменшение задержки спауна врагов с каждой волной
			if(Cooldown > 0.5f)
			{
				Cooldown -= cdDecrement;
			}

			wavesCount++;

			//Новая волна
			InvokeRepeating("Spawn", iniPause, Cooldown);
		}
	}

	void Spawn()
	{
		Vector3 pos = new Vector3(4.4f, 1.13f, Random.Range(-2, 3));
		int index = Random.Range(0, Enemies.Length);
		Instantiate(enemies[index], pos, Quaternion.identity);
	}
}
