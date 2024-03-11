using System.Collections;
using UnityEngine;

public class Bot : MonoBehaviour
{
	[SerializeField] private Ball _ball;
	[SerializeField] private Transform _leftEndPoint;
	[SerializeField] private Transform _rightEndPoint;
	[SerializeField] private Transform _startPosition;
	[SerializeField] private float _speed;
		
	private WaitForFixedUpdate _waitFixedUpdate;

	private void Awake() =>
		_waitFixedUpdate = new WaitForFixedUpdate();

	private void Start() =>
		StartCoroutine(BotMoveCoroutine());

	private IEnumerator BotMoveCoroutine()
	{
		while (true)
		{
			transform.position = Vector3.MoveTowards(transform.position, GetTargetPosition(), Time.fixedDeltaTime * _speed);
			yield return _waitFixedUpdate;
		}
	}

	private Vector3 GetTargetPosition()
	{
		float ballPositionX = _ball.transform.position.x;
		float xPosition = 0;

		if (ballPositionX >= _rightEndPoint.position.x)
			xPosition = _rightEndPoint.position.x;
		else if (ballPositionX <= _leftEndPoint.position.x)
			xPosition = _leftEndPoint.position.x;
		else
			xPosition = ballPositionX;

		return new Vector3(xPosition, transform.position.y, transform.position.z);
	}

	public void SetDefaultPosition() =>
		transform.position = _startPosition.position;
}