using System;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class CounterUI : MonoBehaviour
{
	private TextMeshProUGUI tmt;
	private int counter = 0;

	public event Action OnCountChanged;

	public int Counter
	{
		get => counter;
		set
		{
			counter = value;
			OnCountChanged?.Invoke();
		}
	}

	private void Awake()
	{
		tmt = GetComponent<TextMeshProUGUI>();
		OnCountChanged += UpdateOnDirty;
		UpdateOnDirty();
	}

	public void Increase()
	{
		Counter++;
	}

	public void Decrease()
	{
		Counter--;
	}

	private void UpdateOnDirty()
	{
		tmt.text = $"{counter}";
	}
}
