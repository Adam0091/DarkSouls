using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _jumpForce;
    [SerializeField] private ContactFilter2D _platform;
    [SerializeField] private float moveSpeed;

    private Rigidbody2D rigidbody2D;

    public int level = 1;
    public float MaxHp = 100;
    public float MaxStamina = 100;

    public float Hp = 100;
    public float Stamina = 100;
    public int LoadСapacity = 1;
    public int Scholarship = 1;
    public int Strength = 1;
    public int Dexterity = 1;
    public int Intelligence = 1;
    public int Faith = 1;
    private bool _isOnPlatform => rigidbody2D.IsTouching(_platform);
    public void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
     
        if (Input.GetKey(KeyCode.A))
        {
            rigidbody2D.transform.position = new Vector2(rigidbody2D.transform.position.x - moveSpeed, rigidbody2D.transform.position.y);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rigidbody2D.transform.position = new Vector2(rigidbody2D.transform.position.x + moveSpeed, rigidbody2D.transform.position.y);
        }

        if(Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = 0.325f;
        } else
        {
            moveSpeed = 0.225f;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_isOnPlatform)
            {
                rigidbody2D.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
                Debug.Log("Прыжок");
            }
        }
    }
}
