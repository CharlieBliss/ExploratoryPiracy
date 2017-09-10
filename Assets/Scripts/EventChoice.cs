using System;
using UnityEngine.Events; 
using UnityEngine.UI;


namespace AssemblyCSharp
{
	public class EventChoice {
		public float successChance { get; set; }
		public string choiceText { get; set; }
		public UnityAction onClick { get; set; }
		public EventCard successNextCard;
		public EventCard failureNextCard;
		public EventCard altNextCard;
//		public EventResult eventResult;

		public Button button;
		public EventChoice (string ChoiceText, float SuccessChance, AssemblyCSharp.EventCard SuccessNextCard, AssemblyCSharp.EventCard FailureNextCard, AssemblyCSharp.EventCard AltNextCard ) {
			successChance = SuccessChance;
			choiceText = ChoiceText;
			successNextCard = SuccessNextCard;
			failureNextCard = FailureNextCard;
			altNextCard = AltNextCard;

		}
	}
}

