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

    private DeathmatchGamemanager DMgamemanager;
    private XPLevelGamemanager XPgamemanager;

    private void Awake()
    {
        lifesAmount = lifes;
        rigidbody = GetComponent<Rigidbody2D>();

        if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_GAMEMODE) == 0)
        {
            DMgamemanager = FindObjectOfType<DeathmatchGamemanager>();
        }
        if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_GAMEMODE) == 1)
        {
            XPgamemanager = FindObjectOfType<XPLevelGamemanager>();
        }
    }

    private void Update()
    {
        if (fly)
        {
            Fly();
        }
    }

    public void Fly()
    {
        rigidbody.velocity = transform.up * upForce;
    }

    public void Fire()
    {
        Instantiate(bulletPrefab, new Vector3(transform.position.x + .7f, transform.position.y, transform.position.z), Quaternion.identity);
    }

    public void RefilLifes()
    {
        lifes = lifesAmount;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_GAMEMODE) == 0)
            {
                DMgamemanager.DamagePlayer();
            }
            if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_GAMEMODE) == 1)
            {
                XPgamemanager.DamagePlayer();
            }
        };

        if (other.gameObject.CompareTag("Enemy"))
        {
            if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_GAMEMODE) == 0)
            {
                DMgamemanager.DamagePlayer();
                Destroy(other.gameObject);
            }
            if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_GAMEMODE) == 1)
            {
                XPgamemanager.DamagePlayer();
                Destroy(other.gameObject);
            }
        }

        if (other.gameObject.CompareTag("EnemyBullet"))
        {
            if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_GAMEMODE) == 0)
            {
                DMgamemanager.DamagePlayer();
                Destroy(other.gameObject);
            }
            if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_GAMEMODE) == 1)
            {
                XPgamemanager.DamagePlayer();
                Destroy(other.gameObject);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_GAMEMODE) == 0)
            {
                DMgamemanager.CollectedCoin(other.gameObject.GetComponent<Coin>().amount);
                Destroy(other.gameObject);
            }
            if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_GAMEMODE) == 1)
            {
                XPgamemanager.CollectedCoin(other.gameObject.GetComponent<Coin>().amount);
                Destroy(other.gameObject);
            }
        }
    }
}
