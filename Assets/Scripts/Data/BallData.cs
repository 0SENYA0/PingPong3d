using UnityEngine;

namespace Data
{
	[CreateAssetMenu(fileName = "BallData", menuName = "ScriptableObject/BallData", order = 1)]
	public class BallData : ScriptableObject
	{
		private const float StartSpeed = 10f;
		
		private float _stepIncrease = 5f;

		public float Speed { get; private set; } = StartSpeed;

		public void IncreaseSpeed() =>
			Speed += _stepIncrease;

		public void ResetSpeed() =>
			Speed = StartSpeed;
	}
}