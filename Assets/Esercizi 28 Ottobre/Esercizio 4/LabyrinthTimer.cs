using TMPro;
using UnityEngine;

public class LabyrinthTimer : MonoBehaviour
{
	private TextMeshProUGUI tmt;
	private bool shouldRun;
	private float time;

	private void Awake()
	{
		tmt = GetComponent<TextMeshProUGUI>();
	}

	private void Start()
	{
		LabyrinthManager.Instance.OnLabyrinthCompleted += () => LabyrinthManager.Instance.RunTime(time);
	}

	private void Update()
	{
		if (!shouldRun) return;
		time += Time.deltaTime;
		tmt.text = time.ToString("n2");
	}

	public void StartTimer()
	{
		shouldRun = true;
		time = 0f;
	}

	public void StopTimer()
	{
		shouldRun = false;
	}
}