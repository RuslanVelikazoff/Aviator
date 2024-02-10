using TMPro;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] 
    private TextMeshPro coinText;

    private Rigidbody2D rigidbody;

    [SerializeField]
    private float lifeTime = 6f;

    [SerializeField] 
    private float speed = 2f;
    
    public int amount;

    private void OnEnable()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        
        randomAmountCoin();
        
        rigidbody.velocity = transform.right * -speed;
        
        Destroy(this.gameObject, lifeTime);
    }

    private void randomAmountCoin()
    {
        amount = Random.Range(1, 100);

        coinText.text = amount + " C";
    }
}
