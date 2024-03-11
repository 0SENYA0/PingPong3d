using Intefaces;
using UnityEngine;

public abstract class Gate : MonoBehaviour
{
	[SerializeField] private Player _player;
	[SerializeField] private Bot _bot;
	[SerializeField] private Ball _ball;
	private void OnTriggerEnter(Collider other)
	{
		if (other.TryGetComponent(out Ball ball) == false)
			return;

		OnBeforeRestartLevel(ball);
		RestartLevel();
	}

	protected abstract void OnBeforeRestartLevel(IBall ball);
	
	private void RestartLevel()
	{
		_player.SetDefaultPosition();
		_bot.SetDefaultPosition();
		_ball.SetDefaultPosition();
		_ball.Push();
	}
}