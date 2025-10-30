using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Obstacle : MonoBehaviour
{
	[SerializeField] private LabyrinthData data;
	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag != "Player") return;
		collision.transform.position = data.PlayerSpawnPoint;
		LabyrinthManager.Instance.PlayerDied();
	}
}
