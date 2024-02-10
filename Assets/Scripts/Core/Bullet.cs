using System;
using System.Collections;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D rigidbody;

    private float speed = 3f;

    private float lifeTime = 3f;
    
    private void OnEnable()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        
        StartCoroutine(BulletLiveTimer());

        rigidbody.velocity = transform.right * speed;
    }
    
    private IEnumerator BulletLiveTimer()
    {
        yield return new WaitForSeconds(lifeTime);
        if (this.gameObject != null)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
