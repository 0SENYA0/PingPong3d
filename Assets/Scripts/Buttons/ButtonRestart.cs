using UnityEngine;
using UnityEngine.UI;

namespace Buttons
{
	public class ButtonRestart : MonoBehaviour
	{
		[SerializeField] private Button _button;

		private void OnEnable() =>
			_button.onClick.AddListener(RestartGame);

		private void OnDisable() =>
			_button.onClick.RemoveListener(RestartGame);
		private void RestartGame()
		{
			
		}
	}
}