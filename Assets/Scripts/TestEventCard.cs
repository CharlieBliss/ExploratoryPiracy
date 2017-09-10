using UnityEngine;
public class TestEventCard : MonoBehaviour {
	public AssemblyCSharp.EventCard eventCard = new AssemblyCSharp.EventCard (null, null, null, null, null, null, null, null);
	public GameObject player;

	void Main() {
		eventCard.Prompt = "A gentleman approaches me on the street, claiming one of mine crew cheated him at a nightly dice game. He demands satisfaction.";
		eventCard.Choice1 = new AssemblyCSharp.EventChoice (
			"Pistols at Dawn, then.",
			50.0f,
			null,
			null,
			null
		);
		eventCard.Choice1.successNextCard = new AssemblyCSharp.EventCard (
			"My draw is quick and my aim true. This gentleman will trouble my crew no more, and the rest of the world will think twice about making these kinds of accusations",
			null,
			null,
			new AssemblyCSharp.EventChoice ("Ashes to Ashes...", 0.0f, null, null, null),
			null,
			null,
			null,
			null
		);
		eventCard.Choice1.failureNextCard = new AssemblyCSharp.EventCard (
			"Gah! A bullet catches the meat of my thigh. As the streets begin to dim, The gentleman takes what he is owed.",
			null,
			null,
			new AssemblyCSharp.EventChoice ("Was that hole always there...?", 0.0f, null, null, null),
			null,
			null,
			null,
			null
		);
		eventCard.Choice2 = new AssemblyCSharp.EventChoice (
			"No need for violence, friend. I'll gladly pay you what you're owed.",
			100.0f,
			null,
			null,
			null
		);
		eventCard.Choice2.successNextCard = new AssemblyCSharp.EventCard (
			"The gentleman sneers. \"That ought to teach your crew not to bother their betters.\" He wanders off, counting his gold.",
			null,
			null,
			new AssemblyCSharp.EventChoice ("Better than losing an eye.", 0.0f, null, null, null),
			null,
			null,
			null,
			null
		);
		eventCard.Choice3 = new AssemblyCSharp.EventChoice (
			"I don't answer for my crew. If you have a problem, take it up with them.",
			50.0f,
			null,
			null,
			null
		);
		eventCard.Choice3.successNextCard = new AssemblyCSharp.EventCard (
			"The gentleman sneers. \"Bah, what's the use. They'd probably try to swindle me again anyway.\" He wanders off, muttering to himelf.",
			null,
			null,
			new AssemblyCSharp.EventChoice ("My gold stays where it belongs.", 0.0f, null, null, null),
			null,
			null,
			null,
			null
		);
		eventCard.Choice3.failureNextCard = new AssemblyCSharp.EventCard (
			"The gentleman tracks down the crew member who he claims swindled him. It seems he will be getting his recompense yet.",
			null,
			null,
			new AssemblyCSharp.EventChoice ("Sorry, friend...", 0.0f, null, null, null),
			null,
			null,
			null,
			null
		);

		}
	}