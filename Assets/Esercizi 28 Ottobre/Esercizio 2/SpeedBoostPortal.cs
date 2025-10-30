using UnityEngine;

[RequireComponent(typeof(Collider))]
public class SpeedBoostPortal : MonoBehaviour
{
	private PlayerMovement componentCache;
	private void OnTriggerEnter(Collider other)
	{
		if(other.TryGetComponent(out componentCache))
		{
			componentCache.DoubleSpeed();
		}
	}
}
