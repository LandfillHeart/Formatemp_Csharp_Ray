using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
	#region Singleton
	private static UIManager instance;
	public static UIManager Instance => instance;
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

	[SerializeField] private LabyrinthTimer timer;
	[SerializeField] private TextMeshProUGUI victoryStatus;
	[SerializeField] private TextMeshProUGUI highscore;

	private bool displayMessage;
	private float messageTimer = 3f;
	private float elapsedTime = 0f;

	private void Start()
	{
		LabyrinthManager.Instance.OnPlayerDied += PlayerLost;
		LabyrinthManager.Instance.OnLabyrinthCompleted += PlayerWon;
		LabyrinthManager.Instance.OnLabyrinthStarted += LabyrinthStart;
		LabyrinthManager.Instance.OnHighScore += (newHS) => highscore.text = $"Highscore: {newHS.ToString("n2")}";
	}

	private void Update()
	{
		if (!displayMessage) return;
		
		elapsedTime += Time.deltaTime;

		if (elapsedTime < messageTimer) return;

		victoryStatus.text = " ";
	}

	private void LabyrinthStart()
	{
		timer.StartTimer();
	}

	private void PlayerLost()
	{
		timer.StopTimer();
		elapsedTime = 0f; 
		displayMessage = true; 
		victoryStatus.text = "Hai Perso";
	}

	private void PlayerWon()
	{
		timer.StopTimer();
		elapsedTime = 0f;
		displayMessage = true;
		victoryStatus.text = "Hai Vinto";
	}
}
