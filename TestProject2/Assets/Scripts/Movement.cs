using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	private float horizontal;
	private float speed = 9f;
	private float jumpingPower = 60f;
	private int extraJump = 1;
	public bool canMove = true;
	public SpriteRenderer spriteRenderer;
	public Sprite slime;
	public Sprite slimeLeft;
	public Sprite slimeRight;
	
	[SerializeField] private Rigidbody2D _rb;
	[SerializeField] private Transform groundCheck;
	[SerializeField] private LayerMask groundLayer;

	void Update()
	{
		if (canMove == true)
		{
			horizontal = Input.GetAxisRaw("Horizontal");

			if (Input.GetButtonDown("Jump")  && IsGrounded())
			{
				_rb.velocity = new Vector2(_rb.velocity.x, jumpingPower);
			}
			else if (Input.GetButtonDown("Jump"))
			{
				if (extraJump > 0)
				{
					_rb.velocity = new Vector2(_rb.velocity.x, jumpingPower);
					extraJump--;
				}
			}
			if (IsGrounded())
			{
				extraJump = 1;
			}

			if (Input.GetButtonDown("Jump") && _rb.velocity.y > 0f)
			{
				_rb.velocity = new Vector2(_rb.velocity.x, _rb.velocity.y * 0.5f);
			}
			if (horizontal > 0)
			{
				spriteRenderer.sprite = slimeRight; 
			}
			else if (horizontal < 0)
			{
				spriteRenderer.sprite = slimeLeft; 
			}
			else if (horizontal == 0)
			{
				spriteRenderer.sprite = slime; 
			}

		}
		else if (canMove == false)
		{
			_rb.constraints = RigidbodyConstraints2D.FreezePosition;
		}
	}

	private void FixedUpdate()
	{
		_rb.velocity = new Vector2(horizontal * speed, _rb.velocity.y);
	}

	private bool IsGrounded()
	{
		return Physics2D.OverlapCircle(groundCheck.position, 0.5f, groundLayer);
	}

	public Sprite newSprite;
	void ChangeSprite()
    {
        spriteRenderer.sprite = newSprite; 
    }
}
