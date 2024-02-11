using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] 
    private float speed;

    [SerializeField] 
    private float lifeTime;
    
    [SerializeField] 
    private GameObject bulletPrefab;

    [SerializeField]
    private Rigidbody2D rigidbody;

    private void OnEnable()
    {
        rigidbody.velocity = transform.right * -speed;
        StartCoroutine(EnemyLifeTimer());
        StartCoroutine(Fire());
    }

    private IEnumerator Fire()
    {
        yield return new WaitForSeconds(2f);
        Instantiate(bulletPrefab, 
            new Vector3(transform.position.x - 1.5f, transform.position.y, transform.position.z)
            , Quaternion.identity);
        StartCoroutine(Fire());
    }

    private IEnumerator EnemyLifeTimer()
    {
        yield return new WaitForSeconds(lifeTime);
        if (this.gameObject != null)
        {
            Destroy(this.gameObject);
        }
    }
}
