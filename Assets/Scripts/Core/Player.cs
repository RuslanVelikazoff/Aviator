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

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
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
            lifes -= 1;

            if (lifes <= 0)
            {
                Debug.Log("GameOver");
            }
        };

        if (other.gameObject.CompareTag("Coin"))
        {
            //TODO: добавить монетки
            Destroy(other.gameObject);
        }
    }
}
