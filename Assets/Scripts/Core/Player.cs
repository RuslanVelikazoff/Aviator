using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int lifes;
    
    [SerializeField]
    private float upForce = 4;

    [SerializeField] 
    private GameObject bulletPrefab;
    
    private Rigidbody2D rigidbody;

    private DeathmatchGamemanager gamemanager;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        gamemanager = FindObjectOfType<DeathmatchGamemanager>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Jump();
        }

        if (Input.GetMouseButtonUp(1))
        {
            Fire();
        }
    }

    public void Jump()
    {
        rigidbody.velocity = transform.up * upForce;
    }

    public void Fire()
    {
        Instantiate(bulletPrefab, transform.position, Quaternion.identity);
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            gamemanager.DamagePlayer();
        };

        if (other.gameObject.CompareTag("Enemy"))
        {
            gamemanager.DamagePlayer();
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("EnemyBullet"))
        {
            gamemanager.DamagePlayer();
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Coin"))
        {
            gamemanager.CollectedCoin(other.gameObject.GetComponent<Coin>().amount);
            Destroy(other.gameObject);
        }
    }
}
