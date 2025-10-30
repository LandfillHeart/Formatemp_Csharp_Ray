using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Trophy : MonoBehaviour
{
	[SerializeField] private LabyrinthData data;
	private int victories;

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag != "Player") return;
		victories++;
		print($"Congratulazioni hai finito il labirinto {victories} volte!");
		collision.transform.position = data.PlayerSpawnPoint;
		LabyrinthManager.Instance.PlayerWon();
	}
}
