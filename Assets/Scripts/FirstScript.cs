using UnityEngine;

public class FirstScript : MonoBehaviour
{

	[SerializeField] private float yAxisRotSpeed;
	[SerializeField] private float rotSpeed;
	[SerializeField] private float rotRadius;

    void Start()
    {
		Debug.Log($"Position: {transform.position}");
    }

	private void FixedUpdate()
	{
		transform.localPosition = new Vector3(Mathf.Sin(Time.time * rotSpeed), 0, Mathf.Cos(Time.time * rotSpeed)) * rotRadius;
		transform.Rotate(new Vector3(0, yAxisRotSpeed, 0));
	}
}
