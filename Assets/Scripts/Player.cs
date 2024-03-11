using System;
using UnityEngine;

public class Player : MonoBehaviour
{
	[SerializeField] private float _speed;
	[SerializeField] private Transform _leftEndPoint;
	[SerializeField] private Transform _rightEndPoint;
	[SerializeField] private Transform _startPosition;

	private void Update()
	{
		if (Input.GetKey(KeyCode.A))
			ChangeTransformPosition(() => transform.position.x + Vector3.right.x <= _leftEndPoint.position.x, Vector3.left);

		if (Input.GetKey(KeyCode.D))
			ChangeTransformPosition(() => transform.position.x + Vector3.right.x >= _rightEndPoint.position.x, Vector3.right);
	}

	private void ChangeTransformPosition(Func<bool> canChangedPosition, Vector3 target)
	{
		if (canChangedPosition() == false)
			transform.position += target * (_speed * Time.deltaTime);
	}

	public void SetDefaultPosition() =>
		transform.position = _startPosition.position;
}