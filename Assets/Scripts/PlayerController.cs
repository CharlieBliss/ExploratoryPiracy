using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public Rigidbody rb;
	public GameController gameController;
	public int speed;
	public bool canMove = true;
	public double personalCombat;
	public double diplomacy;
	public double skullduggery;
	public int gold;
	public double morale;
	public double shipCombat;
	public double luck;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void AttemptMove (int xDir, int yDir)
	{
		float horizontal = (float)xDir * 0.5f;
		float vertical = (float)yDir * 0.5f;
		//Tries to use Lerp to make each movement take a little bit of time
		rb.position = Vector3.Lerp(rb.position, rb.position + new Vector3(horizontal, vertical, 0), 10f);

		//Set the playersTurn boolean of GameManager to false now that players turn is over.
	}

	void OnTriggerEnter(Collider col) {
		print("Player");
	}

	void Update ()
	{
		if (canMove) {
			rb.position = new Vector3 (
				Mathf.Clamp (rb.position.x, -gameController.mapWidth, gameController.mapWidth),
				Mathf.Clamp (rb.position.y, -gameController.mapHeight, gameController.mapHeight),
				0.0f
			);
			int moveHorizontal = 0;
			int moveVertical = 0;

			if (gameController.turn != 0)
				return;

			moveHorizontal = (int)(Input.GetAxisRaw ("Horizontal"));
			moveVertical = (int)(Input.GetAxisRaw ("Vertical"));

			if (moveHorizontal != 0) {
				moveVertical = 0;
			}

			if (moveHorizontal != 0 || moveVertical != 0) {
				AttemptMove (moveHorizontal, moveVertical);
			}
		}
	}
}