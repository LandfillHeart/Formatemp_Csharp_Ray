using UnityEngine;

public class TopLeftPanel : MonoBehaviour
{
	[SerializeField] private RectTransform panel;
	public void OpenPanel()
	{
		panel.gameObject.SetActive(true);
	}

	public void ClosePanel()
	{
		panel.gameObject.SetActive(false);
	}
}