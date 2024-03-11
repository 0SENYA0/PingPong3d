using UnityEngine;

namespace Data
{
	[CreateAssetMenu(fileName = "PlayerScore", menuName = "ScriptableObject/PlayerScore", order = 0)]
	public class PlayerScore : ScriptableObject
	{
		public int Score { get; private set; }

		public int VictorySeries { get; private set; }

		public void IncreaseVictorySeries() =>
			VictorySeries++;

		public void ResetVictorySeries() =>
			VictorySeries = 0;
		
		public void IncreaseScore() =>
			Score++;

		public void ResetScore() =>
			Score = 0;
	}
}