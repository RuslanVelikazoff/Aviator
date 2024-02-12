using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private Rigidbody2D rigidbody;

    private XPLevelSpawner spawner;

    private void Start()
    {
        spawner = FindAnyObjectByType<XPLevelSpawner>();
        rigidbody.velocity = transform.right * -speed;
    }

    private void Update()
    {
        if (this.gameObject.transform.position.x <= -7.14f)
        {
            Destroy(this.gameObject);
            spawner.SpawnObstacle(new Vector3(7.14f, 0, 0));
        }
    }

}
