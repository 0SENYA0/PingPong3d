using UnityEngine;
using UnityEngine.UI;

namespace Buttons
{
	public class ButtonContinue : MonoBehaviour
	{
		[SerializeField] private Button _button;

		private void OnEnable() =>
			_button.onClick.AddListener(ContinueGame);

		private void OnDisable() =>
			_button.onClick.RemoveListener(ContinueGame);
		private void ContinueGame() =>
			Time.timeScale = 1;
	}
}