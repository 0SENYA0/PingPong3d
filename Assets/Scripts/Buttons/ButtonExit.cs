using UnityEngine;
using UnityEngine.UI;

namespace Buttons
{
	public class ButtonExit : MonoBehaviour
	{
		[SerializeField] private Button _button;

		private void OnEnable() =>
			_button.onClick.AddListener(ExitGame);

		private void OnDisable() =>
			_button.onClick.RemoveListener(ExitGame);
		private void ExitGame() =>
			Application.Quit();
	}
}