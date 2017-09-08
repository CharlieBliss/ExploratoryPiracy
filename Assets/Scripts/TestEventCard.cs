using UnityEngine;
public class TestEventCard {
	public AssemblyCSharp.EventCard eventCard = new AssemblyCSharp.EventCard (null, null, null, null, null, null, null, null);
	public AssemblyCSharp.EventCard successCard = new AssemblyCSharp.EventCard (null, null, null, null, null, null, null, null);

	static void Main() {
		eventCard.Prompt = "A gentleman approaches me on the street, claiming one of mine crew cheated him at a nightly dice game. He demands satisfaction.";
		eventCard.Choice1 = new AssemblyCSharp.EventChoice ();
		eventCard.Choice1.choiceText = "Pistols at Dawn, then.";
		eventCard.Choice1.successChance = (50.0);
		eventCard.Choice1.successNextCard = successCard;
		successCard.Prompt = "This gentleman will trouble my crew no more, and the rest of the world will think twice about making these kinds of accusations";
			successCard.Choice1 = new AssemblyCSharp.EventChoice ();
		successCard.Choice1.choiceText = "Ashes to ashes...";
//		successCard.Choice1.eventResult = new AssemblyCSharp.EventResult ();
//		successCard.Choice1.eventResult.player.morale += 5;
//		successCard.Choice1.eventResult.player.loyalty += 5;
//		successCard.Choice1.eventResult.player.gold += 20;
	}
}
				
//				Choice1.failureNextCard = new EventCard() {
//					prompt = "Gah! A bullet catches the meat of my thigh. As the streets begin to dim, The gentleman takes what he is owed."
//					Choice1 = new EventChoice {
//						choiceText = "Was that hole always there...?"
//						eventResult = new EventResult {
//							player.morale -= 5;
//							player.loyalty += 5;
//							player.gold -= 20;
//							player.health -= 20;
//						}
//					}
//				}
//			}
//			choice2 = new EventChoice() {
//				choiceText = "No need for violence, friend. I'll gladly pay you what you're owed"
//				successChance = 100.0
//				successNextCard = new EventCard {
//					prompt = "The gentleman sneers. \"That ought to teach your crew not to bother their betters.\" He wanders off, counting his gold."
//					Choice1 = new EventChoice {
//						choiceText = "Better than losing an eye!"
//							eventResult = new EventResult {
//								Player.gold -= 20;
//							}
//						}
//				}
//
//			}
//			choice3 = new EventChoice() {
//			choiceText = "I don't answer for my Crew. If you have a problem, take it up with them"
//			double playerSkill = Math.max(player.diplomacy, player.skullduggery);
//			successChance = (playerSkill + 50.0)
//			successNextCard = new EventCard {
//				prompt = "The gentleman sneers. \"Bah, what's the use. They'd probably try to swindle me again anyway.\" He wanders off, muttering to himelf."
//					Choice1 = new EventChoice {
//					choiceText = "My gold stays where it belongs."
//					eventResult = new EventResult {
//						player.morale += 5;
//						playerSkill += 5;
//					}
//				}
//			}
//			failureNextCard = new EventCard {
//				prompt = "I accidentally said the name of my crew member as he walked by. It seems the gentleman will be getting his recompense yet."
//				Choice1 = new EventChoice {
//				choiceText = "Sorry, friend..."
//					eventResult = new EventResult {
//					player.morale -= 5;
//					player.loyalty -= 5;
//				}
//			}
//		}
//		}
//			
//		}
//		}
//	}
//}