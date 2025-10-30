using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
	[SerializeField] private float speed;
	[SerializeField] private float range;
	private Vector3 startPos;

	private void Awake()
	{
		startPos = transform.position;
	}

	private void FixedUpdate()
	{
		transform.position = new Vector3(startPos.x + Mathf.Sin(Time.time * speed) * range, transform.position.y, transform.position.z);
	}
}
