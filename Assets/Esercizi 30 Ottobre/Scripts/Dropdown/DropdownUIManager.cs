using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static DropdownGameManager;

public class DropdownUIManager : MonoBehaviour
{
	#region Singleton
	private static DropdownUIManager instance;
	public static DropdownUIManager Instance => instance;
	private void Awake()
	{
		if(instance == null)
		{
			instance = this;
			return;
		}
		Destroy(gameObject);
	}
	#endregion

	[SerializeField] private TMP_Dropdown characterMenu;
	[SerializeField] private TMP_Dropdown colorMenu;
	[SerializeField] private Image background;

	[SerializeField] private TextMeshProUGUI difficultyDisplay;
	[SerializeField] private Image characterChoiceIcon;

	private void Start()
	{
		PopulateCharacterSelector();
		colorMenu.onValueChanged.AddListener((index) => ChangeBackground(colorMenu.options[index]));
		DropdownGameManager.Instance.OnDifficultyChanged += (newDifficulty) => difficultyDisplay.text = $"Difficulty: {newDifficulty.ToString()}";
		DropdownGameManager.Instance.OnSelectedCharacterChanged += (newCharacter) => characterChoiceIcon.sprite = newCharacter.Icon;

	}

	public void PopulateCharacterSelector()
	{
		characterMenu.options.Clear();
		List<string> toAdd = new();
		for (int i = 0; i < DropdownGameManager.Instance.AvailableCharacters.Length; i++)
		{
			toAdd.Add(DropdownGameManager.Instance.AvailableCharacters[i].Name);
		}
		characterMenu.AddOptions(toAdd);
	}

	public void ChangeBackground(TMP_Dropdown.OptionData data)
	{
		background.color = data.color;
	}

	public void ChangeDifficulty(int choice)
	{
		DropdownGameManager.Instance.ChangeDifficulty(choice);
	}

	public void ChangeCharacter(int choice)
	{
		DropdownGameManager.Instance.ChangeCharacter(choice);
	}
}
