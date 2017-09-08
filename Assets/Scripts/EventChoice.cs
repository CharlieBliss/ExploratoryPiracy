using System;
using UnityEngine.Events; 
using UnityEngine.UI;


namespace AssemblyCSharp
{
	public class EventChoice {
		public double successChance { get; set; }
		public string choiceText { get; set; }
		public UnityAction onClick { get; set; }
		public EventCard successNextCard;
		public EventCard failureNextCard;
		public EventCard altNextCard;
//		public EventResult eventResult;

		public Button button;
		public EventChoice () {
			successChance = 0.0;
			choiceText = "";
		}
	}
}

