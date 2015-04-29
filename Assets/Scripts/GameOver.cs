using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour
{
	public bool lost;

	private Money mscr;
	private float initMoney;
	private WaveManager wavscr;
	private GameObject[] tiles;

	void Start ()
	{
		mscr = gameObject.GetComponent<Money>();
		wavscr = gameObject.GetComponent<WaveManager>();
		initMoney = mscr.money;
		tiles = GameObject.FindGameObjectsWithTag("Tile");
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (lost) {
			lost = false;
			wavscr.wavesCount = 0;
			GameObject[] towers = GameObject.FindGameObjectsWithTag("Tower");
			GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

			wavscr.CancelInvoke();
			wavscr.Cooldown = 4;
			wavscr.InvokeRepeating("Spawn", wavscr.iniPause, wavscr.Cooldown);

			foreach(GameObject tile in tiles)
			{
				tile.GetComponent<TileTaken>().isTaken = false;
			}

			for (int i = 0; i < towers.Length; i++) {
				Destroy (towers[i]);
			}

			for (int j = 0; j < enemies.Length; j++) {
				Destroy (enemies[j]);
			}



			GameObject[] projs = GameObject.FindGameObjectsWithTag("Projectile");

			for (int k = 0; k < projs.Length; k++) {
				Destroy (projs[k]);
			}

			mscr.money = initMoney;
		}
	}
}
