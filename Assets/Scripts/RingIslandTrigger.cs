using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events; 
using UnityEngine.EventSystems; 

public class RingIslandTrigger : MonoBehaviour {
	private ModalPanel modalPanel;
	public Image image;
	public TestEventCard testEventCard;
	public bool used;

	// Use this for initialization

	void Awake() {
		modalPanel = ModalPanel.Instance ();
	}

	void OnTriggerEnter(Collider col) {
		if (col.name == "Player" && used == false) {
			modalPanel.Options (testEventCard.eventCard);
			used = true;
		}
	}
}
