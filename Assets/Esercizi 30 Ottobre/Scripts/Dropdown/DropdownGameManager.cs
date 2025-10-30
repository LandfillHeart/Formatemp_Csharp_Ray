using System;
using System.Collections.Generic;
using UnityEngine;

public class DropdownGameManager : MonoBehaviour
{
	#region Singleton
	private static DropdownGameManager instance;
	public static DropdownGameManager Instance => instance;
	private void Awake()
	{
		if (instance == null)
		{
			instance = this;
			return;
		}
		Destroy(gameObject);
	}
	#endregion

	public DropdownCharacterData[] AvailableCharacters;

	private DropdownDifficulty currentDifficulty;
	private DropdownCharacterData selectedCharacter;

	public event Action<DropdownDifficulty> OnDifficultyChanged;
	public event Action<DropdownCharacterData> OnSelectedCharacterChanged;

	public enum DropdownDifficulty
	{
		Easy, 
		Medium, 
		Hard
	}

	public void ChangeDifficulty(int difficulty)
	{
		currentDifficulty = (DropdownDifficulty)difficulty;
		OnDifficultyChanged?.Invoke(currentDifficulty);
	}

	public void ChangeCharacter(int character)
	{
		selectedCharacter = AvailableCharacters[character];
		OnSelectedCharacterChanged?.Invoke(selectedCharacter);
	}
}
