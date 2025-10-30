using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Bullet : MonoBehaviour
{
	private void Start()
	{
		Destroy(gameObject, 5f);
	}

	private void OnCollisionEnter(Collision collision)
	{
		Destroy(gameObject);
	}
}