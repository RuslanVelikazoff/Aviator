using System.Collections;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] 
    private float speed = 3;

    [SerializeField] 
    private float lifeTime = 3;

    [SerializeField] 
    private Rigidbody2D rigidbody;

    private void OnEnable()
    {
        rigidbody.velocity = transform.right * -speed;
        StartCoroutine(BulletLifeTimer());
    }
    
    private IEnumerator BulletLifeTimer()
    {
        yield return new WaitForSeconds(lifeTime);
        if (this.gameObject != null)
        {
            Destroy(this.gameObject);
        }
    }
}
