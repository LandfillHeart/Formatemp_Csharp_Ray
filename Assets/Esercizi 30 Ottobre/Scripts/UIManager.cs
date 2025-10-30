using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace SliderPractice
{
	public class UIManager : MonoBehaviour
	{
		[Header("UI Components")]
		[SerializeField] private TextMeshProUGUI volumeDisplay;
		[SerializeField] private TextMeshProUGUI lightDisplay;
		[SerializeField] private TextMeshProUGUI objSizeDisplay;
		[SerializeField] private Slider objSizeSlider;
		[SerializeField] private TextMeshProUGUI lockButton;

		[Header("Scene Objects")]
		[SerializeField] private Light sceneLight;
		[SerializeField] private Transform toScale;
		private Vector3 defaultScale;

		private void Awake()
		{
			defaultScale = toScale.localScale;
		}

		public void ChangeVolume(float newVolume)
		{
			volumeDisplay.text = $"Volume: {newVolume}";
		}

		public void ChangeLightIntensity(float newLightIntensity)
		{
			sceneLight.intensity = newLightIntensity;
			lightDisplay.text = $"Luce: {newLightIntensity}";
		}

		public void ChangeObjectScale(float newScale)
		{
			toScale.localScale = defaultScale * newScale;
			objSizeDisplay.text = $"Size: {newScale.ToString("0.00")}";
		}

		public void ToggleLockScaleSlider()
		{
			if(objSizeSlider.interactable)
			{
				objSizeSlider.interactable = false;
				lockButton.text = "Unlock";
				return;
			}

			objSizeSlider.interactable = true;
			lockButton.text = "Lock";
		}

		public void ResetObjScale()
		{
			objSizeDisplay.text = $"Size: {1}";
			toScale.localScale = defaultScale;
			objSizeSlider.value = 1f;
		}
	}
}

