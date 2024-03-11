using Data;
using Intefaces;
using Text;
using UnityEngine;

public class BotGate : Gate
{
	[SerializeField] private BallData _ballData;
	[SerializeField] private TextScore _textScore;
	[SerializeField] private PlayerScore _playerScore;

	protected override void OnBeforeRestartLevel(IBall ball)
	{
		_playerScore.IncreaseScore();
		_ballData.IncreaseSpeed();
			
		ball.SetSpeed(_ballData.Speed);
	}
}

