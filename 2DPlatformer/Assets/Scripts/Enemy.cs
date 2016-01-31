using UnityEngine;
using System.Collections;

public class Enemy : LivingEntity {

	public enum State
	{
		Idle,
		Wander,
		Chasing,
		Attacking
	}

	public State currentState;
	public float enemySpeed = 5;
	float direction = -1;
	Transform target;
	float gravity = 2f;
	Vector3 velocity;

	SpriteRenderer spriteRenderer;

	Controller2D controller;

	void Start()
	{
		base.Start();
		controller = GetComponent<Controller2D>();
		spriteRenderer = GetComponent<SpriteRenderer>();
		enemySpeed = -enemySpeed;
	}

	void Update()
	{
		if (currentState == State.Wander)
		{
			if (controller.collisions.left)
			{
				enemySpeed = Mathf.Abs(enemySpeed);
			}
			else if (controller.collisions.right)
			{
				enemySpeed = -enemySpeed;
			}

			velocity.x = enemySpeed;
		}

		velocity.y -= gravity * Time.deltaTime;
		controller.Move(velocity * Time.deltaTime);
	}
}
