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
	private bool initialized = false;
	private int currentTiles = 0;
	public int mapHeight = 0;
	public int mapWidth = 0;
	public int tileVertical = 0;
	public int tileHorizontal = 0;
	public int turn = 0;
	// Use this for initialization


	void OnDrawGizmos() {
		Gizmos.color = Color.green;
		Gizmos.DrawLine (new Vector3(-mapWidth, mapHeight, 0), new Vector3(mapWidth,mapHeight, 0));
		Gizmos.DrawLine (new Vector3(mapWidth, mapHeight, 0), new Vector3(mapWidth, -mapHeight, 0));
		Gizmos.DrawLine (new Vector3(mapWidth, -mapHeight, 0), new Vector3(-mapWidth, -mapHeight, 0));
		Gizmos.DrawLine (new Vector3(-mapWidth, -mapHeight, 0), new Vector3(-mapWidth,mapHeight, 0));
	}
	void initializeGame () {
		int currentHorizontal = tileHorizontal;
		int currentVertical = 0;
	

		while (currentTiles < tileCount || currentVertical  / 2 - 1 < mapWidth) {
			var islandRand = Random.value;
			var newTile = winterIsland;
			if (currentHorizontal < mapHeight) {
				if (islandRand > .99f) {
					newTile = ringIsland;
				}
				else if (islandRand > .97f) {
					newTile = tropicIsland;
				}
				else if (islandRand < .95f) {
					newTile = waterTile;
				}
				var placedTile = Instantiate (newTile, new Vector3 (tileVertical, currentHorizontal, 0), Quaternion.identity);
				placedTile.transform.parent = background.transform;
					currentHorizontal += 1;
					currentTiles += 1;
			} else {
				if (tileVertical < mapHeight) {
					if (islandRand > .99f) {
						newTile = ringIsland;
					}
					else if (islandRand > .97f) {
						newTile = tropicIsland;
					}
					else if (islandRand < .95f) {
						newTile = waterTile;
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
