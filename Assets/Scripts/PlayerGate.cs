using Data;
using Intefaces;
using Text;
using UnityEngine;

public class PlayerGate : Gate
{
	[SerializeField] private BallData _ballData;
	[SerializeField] private TextScore _textScore;

	protected override void OnBeforeRestartLevel(IBall ball)
	{
		_ballData.ResetSpeed();
		//_playerScore.IncreaseScore();
			
		ball.SetSpeed(_ballData.Speed);
		//_textScore.SetScore();
	}
}