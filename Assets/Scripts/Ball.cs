using Intefaces;
using UnityEngine;
using Random = UnityEngine.Random;

public class Ball : MonoBehaviour, IBall
{
	[SerializeField] private Rigidbody _rigidbody;
	[SerializeField] private Transform _startPosition;

	private float _speed;

	private void Start() =>
		Push();

	private void OnCollisionEnter(Collision collision)
	{
		Vector3 normal = collision.contacts[0].normal;
			Debug.DrawRay(collision.contacts[0].point, collision.contacts[0].normal, Color.red, 2f);

		Vector3 reflectInnacurracy = new Vector3(Random.Range(0.05f, 0.09f), 0, Random.Range(0.05f, 0.09f));
		
		Vector3 reflectedDirection = Vector3.Reflect(transform.forward + reflectInnacurracy, normal);
		reflectedDirection.y = 0;
		
		transform.forward = reflectedDirection.normalized;
		Push();
	}

	public void SetSpeed(float speed) =>
		_speed = speed;

	public void Push() =>
		_rigidbody.velocity = transform.forward * _speed;

	public void SetDefaultPosition() =>
		transform.position = _startPosition.position;
}