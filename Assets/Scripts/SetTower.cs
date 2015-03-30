using UnityEngine;
using System.Collections;

public class SetTower : MonoBehaviour {
	public int Selected;
	public GameObject[] towers;
	public float[] prices;
	public GameObject Tile;
	private Money mscr; 
	// Use this for initialization
	void Start () {
		mscr = GameObject.Find ("GameLogic").GetComponent<Money> ();
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast(ray, out hit, 20))
		{
           if(hit.transform.tag == "Tile")
			{
				Tile = hit.transform.gameObject;
			}
			else 
			{
				Tile = null;
			}
		}
		if(Input.GetMouseButtonDown(0) && Tile !=null)
			{
				TileTaken tscr = Tile.GetComponent<TileTaken>();
				if(!tscr.isTaken && mscr.money >= prices[Selected])
				{
					mscr.money -= prices[Selected];
					Vector3 pos =  new Vector3(Tile.transform.position.x,1F, Tile.transform.position.z);
					tscr.Tower = (GameObject)Instantiate(towers[Selected],pos,Quaternion.identity);
					tscr.isTaken = true;
				}
			}
		}
	}

