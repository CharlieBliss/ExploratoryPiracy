using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events; 
using UnityEngine.EventSystems; 

public class ModalPanel : MonoBehaviour {

	public Text prompt;
	public Image image;
	public GameObject modalPanelObject;
	public TestEventCard testEventCard;

	private static ModalPanel modalPanel;

	public static ModalPanel Instance () {
		if (!modalPanel) {
			modalPanel = FindObjectOfType(typeof (ModalPanel)) as ModalPanel;
			if (!modalPanel) {
				Debug.LogError ("There needs to be one active ModalPanel script on a GameObject");
			}
		}
		return modalPanel;
	}

	public void Options (string prompt, Image image, UnityAction event1, UnityAction event2, UnityAction event3, UnityAction event4, UnityAction event5) {
		modalPanelObject.SetActive (true);

//		var allButtons = new [] {
//			new AssemblyCSharp.EventChoice {
//				button = option1,
//				onClick = event1
//			},
//			new AssemblyCSharp.EventChoice {
//				button = option1,
//				onClick = event1
//			},
//			new AssemblyCSharp.EventChoice {
//				button = option1,
//				onClick = event1
//			},
//			new AssemblyCSharp.EventChoice {
//				button = option1,
//				onClick = event1
//			},
//			new AssemblyCSharp.EventChoice {
//				button = option1,
//				onClick = event1
//			},
//		};

		this.prompt.text = testEventCard.eventCard.Prompt;
		this.image = testEventCard.eventCard.Image;
		this.prompt.gameObject.SetActive (true);
		this.image.gameObject.SetActive (true);

		foreach (var option in testEventCard.eventCard.allButtons) {
			option.button.onClick.RemoveAllListeners ();
			option.button.onClick.AddListener (option.onClick);
			option.button.onClick.AddListener (ClosePanel);
			option.button.gameObject.SetActive (true);
		}
	}

	void ClosePanel() {
		this.prompt.gameObject.SetActive (false);
		this.image.gameObject.SetActive (false);
		modalPanelObject.SetActive (false);
	}
}