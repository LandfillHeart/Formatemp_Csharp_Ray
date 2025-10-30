using UnityEngine;

public class GenerateCube : MonoBehaviour
{
	[SerializeField] private GameObject cubePrefab;

	private void Start()
	{
		GameObject newObjCache;
		newObjCache = Instantiate(cubePrefab, Vector3.zero, Quaternion.identity);
		for(int i = 0; i < 4;  i++)
		{
			newObjCache = Instantiate(cubePrefab, newObjCache.transform);
		}
	}
}
