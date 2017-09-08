using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events; 
using UnityEngine.EventSystems; 

public class RingIslandTrigger : MonoBehaviour {
	private ModalPanel modalPanel;
	private UnityAction myOption1;
	private UnityAction myOption2;
	private UnityAction myOption4;
	private UnityAction myOption5;
	private UnityAction myOption3;
	public Image image;

	// Use this for initialization

	void Awake() {
		modalPanel = ModalPanel.Instance ();

		myOption1 = new UnityAction (TestOption1);
		myOption2 = new UnityAction (TestOption2);
		myOption3 = new UnityAction (TestOption3);
		myOption4 = new UnityAction (TestOption4);
		myOption5 = new UnityAction (TestOption5);
	}

	void OnTriggerEnter(Collider col) {
		print ("Ring Island");
		modalPanel.Options ("You find a lonely man on this deserted island. He speaks in crazed language about the end of the world. As you approach the him, he points a finger to the sky", image, myOption1, myOption2, myOption3, myOption4, myOption5);
	}

	void TestOption1 () {
		print ("Options 1");
	}
	void TestOption2 () {
		print ("Options 2");
	}
	void TestOption3 () {
		print ("Options 3");
	}
	void TestOption4() {
		print ("Options 4");
	}
	void TestOption5 () {
		print ("Options 5");
	}
}
