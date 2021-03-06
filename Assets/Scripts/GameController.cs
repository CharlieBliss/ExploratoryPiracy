using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public int tileCount = 0;
	public Vector3 tileSize = new Vector3(0,0,0);
	public GameObject playerShip;
	public GameObject ringIsland;
	public GameObject winterIsland;
	public GameObject tropicIsland;
	public GameObject background;
	public GameObject waterTile;
	public GameObject backgroundMap;
	private GameObject[] allIslands;
	private bool initialized = false;
	private int currentTiles = 0;
	public int mapHeight = 0;
	public int mapWidth = 0;
	public int tileVertical = 0;
	public int tileHorizontal = 0;
	public int turn = 0;
	// Use this for initialization


	void initializeGame () {
		allIslands = new GameObject[] {
			ringIsland,
			tropicIsland,
		};
		int currentHorizontal = tileHorizontal;
		int currentVertical = 0;
	

		while (currentTiles < tileCount || currentVertical  / 2 - 1 < mapWidth) {
			var islandRand = Random.value;
			var newTile = waterTile;
			if (currentHorizontal < mapHeight) {
				if (islandRand > 0.95f) {
					newTile = allIslands [Random.Range (0, allIslands.Length)];
				}
				var placedTile = Instantiate (newTile, new Vector3 (tileVertical, currentHorizontal, 0), Quaternion.identity);
				placedTile.transform.parent = background.transform;
					currentHorizontal += 1;
					currentTiles += 1;
			} else {
				if (tileVertical < mapHeight) {
					if (islandRand > 0.95f) {
						newTile = allIslands [Random.Range (0, allIslands.Length)];
					}
				}
				var placedTile = Instantiate (newTile, new Vector3 (tileVertical, currentHorizontal, 0), Quaternion.identity);
				placedTile.transform.parent = background.transform;
				currentHorizontal = tileHorizontal;
				tileVertical += 1;
				currentVertical++;
				currentTiles += 1;
			}
		}

		initialized = true;
	}
	void Start () {
		if (!initialized) {
			initializeGame ();
			turn = 0;
		}
	}
								
	
	// Update is called once per frame
	void Update () {
		
	}
}
