using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems; 

public class ButtonBehavior : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

	public Text text;
	// Use this for initialization
	public void OnPointerEnter(PointerEventData eventData)
	{
		text.color = Color.grey;
		text.fontStyle = FontStyle.Bold;
	}

	public void OnPointerExit(PointerEventData eventData)
	{
		text.color = Color.black;
		text.fontStyle = FontStyle.Normal;
	}
}