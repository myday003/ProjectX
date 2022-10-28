
using UnityEngine;

public class PlayerAttach : MonoBehaviour
{
    public float Damage = 50f;
    public int Bullet = 8;
    private void OnTriggerStay2D(Collider2D col)
    {
        if (Input.GetKeyDown(KeyCode.A)) 
        {
            if (Bullet > 0)
            {
                col.gameObject.GetComponent<enemy>().TakeDamage(Damage);
            }
            Bullet--;
        }
    }
    public void AddBullet(int CountOfBullet)
    {
        Bullet += CountOfBullet;
    }
}
