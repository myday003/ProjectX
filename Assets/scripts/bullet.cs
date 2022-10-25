
using UnityEngine;

public class bullet : MonoBehaviour
{
    public int CountOfBullet = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<PlayerAttach>().AddBullet(CountOfBullet);
        Destroy(gameObject);
    }
}
