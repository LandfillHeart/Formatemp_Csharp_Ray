using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ConsolePrinterButton : MonoBehaviour
{
	[SerializeField] private string message;

	private void Awake()
	{
		GetComponent<Button>().onClick.AddListener(PrintToConsole);
	}

	private void PrintToConsole()
	{
		print(message);
	}
}
