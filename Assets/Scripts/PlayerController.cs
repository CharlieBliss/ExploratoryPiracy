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
	public IEnumerator MoveToPosition(Rigidbody rb, Vector3 movement, float time) {
		canMove = false;
		var currentPos = rb.position;
		float t = 0f;
		while(t < 1)
		{
			t += Time.deltaTime / time;
			rb.position = Vector3.Lerp(rb.position, movement, t);
			yield return null;
		}
		canMove = true;
	}
	public void AttemptMove (bool moveUp, bool moveDown, bool moveLeft, bool moveRight)
	{
		// Changes the rotation of the sprite to match the direction of movement
		var moveMap = new []{
			new {
				direction = moveUp,
				rotation = 0,
				movement = new Vector3(0, 2 ,0)
			},
			new {
				direction = moveDown,
				rotation = 180,
				movement = new Vector3(0, -2 , 0)
			},
			new {
				direction = moveLeft,
				rotation = 90,
				movement = new Vector3(-2, 0 , 0)
			},
			new {
				direction = moveRight,
				rotation = -90,
				movement = new Vector3(2, 0 , 0)
			}
		};

				
		Vector3 rotates = new Vector3(0,0,0);
		Vector3 movement = new Vector3(0,0,0);
		foreach (var direction in moveMap) {
			if (direction.direction) {
				rotates = new Vector3 (0, 0, direction.rotation);
				movement = rb.position + direction.movement;
			}
		}

		StartCoroutine(MoveToPosition (rb, movement, 0.25f));
			

		transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.Euler(rotates), .9f);
		//Tries to use Lerp to make each movement take a little bit of time
//		rb.position = Vector3.Lerp(rb.position, movement, );

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

			if (gameController.turn != 0)
				return;

//			moveHorizontal = (int)(Input.GetAxisRaw ("Horizontal"));
//			moveVertical = (int)(Input.GetAxisRaw ("Vertical"));
			bool moveUp = Input.GetKeyDown (KeyCode.UpArrow);
			bool moveDown = Input.GetKeyDown (KeyCode.DownArrow);
			bool moveLeft = Input.GetKeyUp (KeyCode.LeftArrow);
			bool moveRight = Input.GetKeyUp (KeyCode.RightArrow);

//			if (moveHorizontal != 0) {
//				moveVertical = 0;
//			}

			if (moveUp || moveDown || moveLeft || moveRight) {
				AttemptMove (moveUp, moveDown, moveLeft, moveRight);
			}
		}
	}
}