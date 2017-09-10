using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events; 
using UnityEngine.EventSystems; 

public class ModalPanel : MonoBehaviour {

	public Text prompt;
	public Image image;
	public Button option1;
	public Button option2;
	public Button option3;
	public Button option4;
	public Button option5;
	private UnityAction newAction;
	public PlayerController player;


	public GameObject modalPanelObject;

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

	void TestOption1 (AssemblyCSharp.EventCard eventCard) {
		Options(eventCard);
	}

	public void Options (AssemblyCSharp.EventCard eventCard) {
		var allButtons = new [] {
			new {
				name = option1,
				choice = eventCard.Choice1
			},
			new {
				name = option2,
				choice = eventCard.Choice2,
			},
			new {
				name = option3,
				choice = eventCard.Choice3,
			},
			new {
				name = option4,
				choice = eventCard.Choice4,
			},
			new {
				name = option5,
				choice = eventCard.Choice5,
			}
		};

		foreach (var option in allButtons) {
			option.name.gameObject.SetActive (false);

			if (option.choice != null) {
				modalPanelObject.SetActive (true);
				player.canMove = false;


				this.prompt.text = eventCard.Prompt;
				this.prompt.gameObject.SetActive (true);
				option.name.gameObject.SetActive (true);
				option.name.gameObject.GetComponentsInChildren<Text> () [0].text = option.choice.choiceText;
			
				option.name.onClick.RemoveAllListeners ();
				if (option.choice.successChance == 0) {
					option.name.onClick.AddListener (ClosePanel);
				} else {
					float random = Random.value;
					print (random);
					print(option.choice.successChance);
					if (random >= .99 && option.choice.altNextCard != null) {
						option.name.onClick.AddListener (delegate {
							TestOption1 (option.choice.altNextCard);
						});
					}
					if (option.choice.successChance > random * 100) {
						option.name.onClick.AddListener (delegate {
							TestOption1 (option.choice.successNextCard);
						});
					} else if (option.choice.successChance != 0) {
						option.name.onClick.AddListener (delegate {
							TestOption1 (option.choice.failureNextCard);
						});
					}
				}
			}
		}
	}



	void ClosePanel() {
		this.prompt.gameObject.SetActive (false);
		this.image.gameObject.SetActive (false);
		modalPanelObject.SetActive (false);
		player.canMove = true;
	}
}