using System;
using System.Collections.Generic;
using System.Linq;

namespace ScrambledCards
{
	public class Program
	{
		static string[] fullDeck = new[]
		{
			"D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9", "D0", "DJ", "DQ", "DK", "DA",
			"H2", "H3", "H4", "H5", "H6", "H7", "H8", "H9", "H0", "HJ", "HQ", "HK", "HA",
			"S2", "S3", "S4", "S5", "S6", "S7", "S8", "S9", "S0", "SJ", "SQ", "SK", "SA",
			"K2", "K3", "K4", "K5", "K6", "K7", "K8", "K9", "K0", "KJ", "KQ", "KK", "KA"
		};

		static void Main(string[] args)
		{
			string[] scrambledCards = new[]
			{
				"D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9", "D0", "DJ", "DQ", "DK", "DA",
				"H2", "H3", "H4", "H5", "H6", "H7", "H8", "H9", "H0", "HJ", "HQ", "HK", "HA",
				"S2", "S3", "S4", "S5", "S7", "S8", "S9", "S0", "SJ", "SQ", "SK", "SA",
				"K2", "K3", "K4", "K5", "K6", "K7", "K8", "K9", "K0", "KJ", "KQ", "KK", "KA",
				"D2", "D3", "D4", "D5", "D6", "D8", "D9", "D0", "DJ", "DQ",
				"H2", "H3", "H4", "H5", "H6", "H7", "H8", "H9", "H0", "HJ", "HQ", "HK", "HA",
				"S2", "S3", "S4", "S5", "S6", "S7", "S8", "S9", "S0", "SJ", "SQ", "SK", "SA",
				"K2", "K3", "K4", "K5", "K6", "K7", "K8", "K9", "K0", "KJ", "KQ", "KK", "KA",
				"D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9", "D0", "DJ", "DQ", "DK", "DA",
				"H2", "H3", "H4", "H5", "H6", "H7", "H8", "H9", "H0", "HJ", "HQ", "HK", "HA",
				"S2", "S3", "S4", "S5", "S6", "S7", "S8", "S9", "S0", "SJ", "SQ", "SK", "SA",
				"K2", "K3", "K4", "K5", "K6", "K7", "K8", "K9", "K0", "KJ", "KQ", "KK", "KA",
				"D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9", "D0", "DJ", "DQ", "DK", "DA",
				"H2", "H3", "H4", "H5", "H6", "H7", "H8", "H9", "H0", "HJ", "HQ", "HK", "HA",
				"S2", "S3", "S4", "S5", "S6", "S7", "S8", "S9", "S0", "SJ", "SQ", "SK", "SA",
				"K2", "K3", "K4", "K5", "K6", "K7", "K8", "K9", "K0", "KJ", "KQ", "KK"
			};

			CardsChallenge(scrambledCards);
			Console.ReadLine();
		}

		private static void CardsChallenge(string[] scrambledCards)
		{
			string[] sortedCards = scrambledCards.OrderBy(x => x).ToArray();

			Dictionary<string, int> cardsWithCount = new Dictionary<string, int>();

			foreach (string card in fullDeck)
				cardsWithCount[card] = sortedCards.Count(x => x == card);

			Console.WriteLine($"Number of scrambled full decks - {cardsWithCount.Values.Min()}");
		}
	}
}