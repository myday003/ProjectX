
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float speed = 5;
    public float HitPoint = 100f;
    public float Damage = 10f;
    private Rigidbody2D rb;
    private void Start()
    {
        GetReferenses();
    }
    private void Update()
    {
        rb.velocity = new Vector2(rb.velocity.x - speed * Time.deltaTime, rb.velocity.y);
        if (HitPoint <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void GetReferenses()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void TakeDamage(float Damage)
    {
        HitPoint -= Damage;
    }
    private void OnTriggerEnter2D(Collider2D col)
    {

        col.gameObject.GetComponent<PlayerHP>().TakeDamage(Damage);


    }
}
