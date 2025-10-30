using TMPro;
using UnityEngine;

public class SpeedDisplay : MonoBehaviour
{
	[SerializeField] private PlayerMovement player;
	[SerializeField] private TextMeshProUGUI panel;
	
	private void Start()
	{
		player.OnSpeedChange += (newSpeed) => panel.text = $"Speed: {newSpeed}";
	}
}
