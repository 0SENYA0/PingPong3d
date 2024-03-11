using UnityEngine;
using UnityEngine.UI;

namespace Buttons
{
	public class ButtonStop : MonoBehaviour
	{
		[SerializeField] private Button _button;

		private void OnEnable() =>
			_button.onClick.AddListener(StopGame);

		private void OnDisable() =>
			_button.onClick.RemoveListener(StopGame);
		private void StopGame() =>
			Time.timeScale = 0;
	}
}