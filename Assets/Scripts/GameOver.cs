using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {
	public bool lost;
	private Money mscr;
	private float initMoney;
	private WaveManager wavscr;

	void Start () {
		mscr = gameObject.GetComponent<Money> ();
		wavscr = gameObject.GetComponent<WaveManager> ();
		initMoney = mscr.money;
	}
	
	// Update is called once per frame
	void Update () {
	    if (lost) 
		{
			lost = false;
			wavscr.NumOut = 0;
			wavscr.resetcd();
			GameObject[] towers = GameObject.FindGameObjectsWithTag("Tower");
			GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
			for(int i=0; i<towers.Length; i++)
			{
				Destroy(towers[i]);
			}
			for(int j=0; j<enemies.Length; j++)
			{
				Destroy(enemies[j]);
			}
			GameObject[] tiles = GameObject.FindGameObjectsWithTag("Tile");
			for(int n=0; n<=tiles.Length; n++)
			{
				TileTaken tscr = tiles[n].GetComponent<TileTaken>();
				tscr.isTaken = false ;
			}
			GameObject[] projs = GameObject.FindGameObjectsWithTag("Projectile");
			for(int k=0; k<= projs.Length;k++)
			{
				Destroy(projs[k]);
			}
			mscr.money = initMoney;
		}
	}
}
