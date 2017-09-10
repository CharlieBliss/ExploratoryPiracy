using System;
using UnityEngine.UI;
using UnityEngine;


namespace AssemblyCSharp
{
	public class EventCard {
		public string Prompt;
		public Image Image;
		public AudioSource SoundEffect;

		public EventChoice Choice1;
		public EventChoice Choice2;
		public EventChoice Choice3;
		public EventChoice Choice4;
		public EventChoice Choice5;
		public EventChoice[] allButtons;


		public EventCard (string prompt, Image image, AudioSource soundEffect, EventChoice choice1, EventChoice choice2, EventChoice choice3, EventChoice choice4, EventChoice choice5) {
			Prompt = prompt;
			Image = image;
			SoundEffect = soundEffect;
			Choice1 = choice1;
			Choice2 = choice2;
			Choice3 = choice3;
			Choice4 = choice4;
			Choice5 = choice5;


			allButtons = new EventChoice [] {
				choice1,
				choice2,
				choice3,
				choice4,
				choice5,
			};
		}
	}
}

