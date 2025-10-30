using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
	[SerializeField] private float speed;
	[SerializeField] private bool canFly;
	private Rigidbody rb;
	private bool flying;

	public event Action<float> OnSpeedChange;

	private Vector3 movement = Vector3.zero;
	
	#region Unity Methods
	private void Awake()
	{
		rb = GetComponent<Rigidbody>();
	}

	private void Update()
	{
		movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		if (!canFly) return;
		if (Input.GetKeyDown(KeyCode.Space)) flying = true;
		if (Input.GetKeyUp(KeyCode.Space)) flying = false;
	}

	private void FixedUpdate()
	{
		if(flying) movement += new Vector3(0, speed, 0);
		rb.MovePosition(transform.position + movement * Time.fixedDeltaTime * speed);
		/*
		if (flying) {
			rb.MovePosition(transform.position + new Vector3(0, speed * Time.fixedDeltaTime, 0));
			return;
		}*/
		//rb.MovePosition(transform.position - new Vector3(0, speed * Time.fixedDeltaTime, 0));
	}
	#endregion

	public void DoubleSpeed()
	{
		speed *= 2;
		OnSpeedChange?.Invoke(speed);
	}

}
