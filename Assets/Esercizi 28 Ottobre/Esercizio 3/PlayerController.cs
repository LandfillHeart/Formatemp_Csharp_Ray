using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
	[SerializeField] private float movementSpeed;
	[SerializeField] private float rotSpeed;

	[SerializeField] private GameObject bulletPrefab;
	[SerializeField] private float bulletSpeed;
	[SerializeField] private Transform muzzle;

	private Rigidbody rb;

	private float movementDir;
	private float rotDir;

	private void Awake()
	{
		rb = GetComponent<Rigidbody>();
	}

	private void Update()
	{
		movementDir = Input.GetAxis("Vertical");
		rotDir = Input.GetAxis("Horizontal");

		if (Input.GetMouseButtonDown(0)) Shoot();
	}

	private void FixedUpdate()
	{
		rb.MovePosition(transform.position + transform.forward * movementDir * movementSpeed * Time.fixedDeltaTime);
		rb.MoveRotation(Quaternion.Euler(transform.rotation.eulerAngles + transform.up * rotDir * rotSpeed * Time.fixedDeltaTime));
	}

	private void Shoot()
	{
		Rigidbody bulletRb = Instantiate(bulletPrefab, muzzle.position, Quaternion.identity).GetComponent<Rigidbody>();
		bulletRb.AddForce(transform.forward * bulletSpeed, ForceMode.Impulse);
	}
}