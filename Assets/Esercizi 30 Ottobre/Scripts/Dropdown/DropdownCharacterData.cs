using UnityEngine;

[CreateAssetMenu(fileName = "Dropdown Character Data", menuName = "Data/Dropdown Character")]
public class DropdownCharacterData : ScriptableObject
{
	public DropdownCharacter character;
	public string Name;
	public Sprite Icon;

	public enum DropdownCharacter
	{
		Champion,
		Mage,
		Paladin
	}
}
