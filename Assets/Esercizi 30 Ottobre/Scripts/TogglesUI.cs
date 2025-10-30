using TMPro;
using UnityEngine;

public class TogglesUI : MonoBehaviour
{
	[SerializeField] private RectTransform panel;
	[SerializeField] private TextMeshProUGUI panelToggleLabel;

	[Header("Three Option Toggles")] 
	[SerializeField] private TextMeshProUGUI[] itemStatus;
	[SerializeField] private RectTransform[] itemsToToggle;

	public void TogglePanel(bool state)
	{
		panel.gameObject.SetActive(state);
		string msg = state ? "attivo" : "inattivo";
		panelToggleLabel.text = $"Pannello: {msg}";
	}

	public void ToggleItem(bool state, int index)
	{
		itemStatus[index].gameObject.SetActive(state);
		itemsToToggle[index].gameObject.SetActive(state);
	}

}
