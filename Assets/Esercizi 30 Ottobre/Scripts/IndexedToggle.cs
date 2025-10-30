using UnityEngine;
using UnityEngine.UI;

public class IndexedToggle : MonoBehaviour
{
	[SerializeField] private TogglesUI ui;
	[SerializeField] private int index;

	private void Awake()
	{
		GetComponent<Toggle>().onValueChanged.AddListener((state) => ui.ToggleItem(state, index));
	}
}
