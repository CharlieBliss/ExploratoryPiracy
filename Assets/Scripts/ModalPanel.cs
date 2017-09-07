using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events; 
using UnityEngine.EventSystems; 

public class ModalPanel : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

	public Text prompt;
	public Image image;
	public Button option1;
	public Button option2;
	public Button option3;
	public Button option4;
	public Button option5;
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

	public void Options (string prompt, UnityAction event1, UnityAction event2, UnityAction event3, UnityAction event4, UnityAction event5) {
		modalPanelObject.SetActive (true);
		Button[] allButtons = new Button[] { option1, option2, option3, option4, option5 };
		this.prompt.text = prompt;
		foreach (Button option in allButtons) {
			option.onClick.RemoveAllListeners ();
			option.onClick.AddListener (event1);
			option.onClick.AddListener (ClosePanel);
			option.gameObject.SetActive (true);
		}
	}

	void ClosePanel() {
		modalPanelObject.SetActive (false);
	}
	// Use this for initialization
	public void OnPointerEnter(PointerEventData eventData)
	{
		
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}
}