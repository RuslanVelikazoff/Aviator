using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int lifes;
    private int lifesAmount;
    
    [SerializeField]
    private float upForce = 4;
    public bool fly = false;

    [SerializeField] 
    private GameObject bulletPrefab;
    
    private Rigidbody2D rigidbody;

    private DeathmatchGamemanager gamemanager;

    private void Awake()
    {
        lifesAmount = lifes;
        rigidbody = GetComponent<Rigidbody2D>();
        gamemanager = FindObjectOfType<DeathmatchGamemanager>();
    }

    private void Update()
    {
        if (fly)
        {
            Fly();
        }

        if (Input.GetMouseButton(0))
        {
            Fly();
        }

        if (Input.GetMouseButton(1))
        {
            Fire();
        }
    }

    public void Fly()
    {
        rigidbody.velocity = transform.up * upForce;
    }

    public void Fire()
    {
        Instantiate(bulletPrefab, transform.position, Quaternion.identity);
    }

    public void RefilLifes()
    {
        lifes = lifesAmount;
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
