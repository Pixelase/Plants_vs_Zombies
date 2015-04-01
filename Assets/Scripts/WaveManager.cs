using UnityEngine;
using System.Collections;

public class WaveManager : MonoBehaviour {

	public int NumOut;
	public float iniPause;
	public GameObject[] Enemies;
	public float Cooldown;
	private float cd;

	// Use this for initialization
	void Start () {
		NumOut = 0;
		cd = Cooldown * iniPause;
	}
	
	// Update is called once per frame
	void Update () {
		if(cd > 0)
		{
			cd -= Time.deltaTime;
		}
		else
		{
			cd = Cooldown;
			Vector3 pos = new Vector3(4.4F, 1.13F, Random.Range(-2, 3));
			int index = Random.Range(0, Enemies.Length);
			Instantiate(Enemies[index], pos, Quaternion.identity);
			NumOut++;
		}
	}
}
