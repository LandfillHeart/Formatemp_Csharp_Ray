using System;
using UnityEngine;

public class LabyrinthManager : MonoBehaviour
{
	#region Singleton
	private static LabyrinthManager instance;
	public static LabyrinthManager Instance => instance;
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

	public event Action OnLabyrinthStarted;
	public event Action OnPlayerDied;
	public event Action OnLabyrinthCompleted;
	public event Action<float> OnHighScore;

	private float highscore = Mathf.Infinity;

	public void StartLabyrinth()
	{
		OnLabyrinthStarted?.Invoke();
	}

	public void PlayerDied()
	{
		OnPlayerDied?.Invoke();
	}

	public void PlayerWon()
	{
		OnLabyrinthCompleted?.Invoke();
	}

	public void RunTime(float newTime) 
	{
		if(newTime < highscore)
		{
			highscore = newTime;
			OnHighScore?.Invoke(highscore);
		}
	}

}
