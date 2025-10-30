using UnityEngine;

[RequireComponent(typeof(Collider))]
public class StartLine : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		if (other.tag != "Player") return;
		LabyrinthManager.Instance.StartLabyrinth();
	}
}