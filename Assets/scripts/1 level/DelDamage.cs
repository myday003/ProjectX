
using UnityEngine;

public class DelDamage : MonoBehaviour
{
    public float Damage = 10;
    private void OnTriggerEnter2D(Collider2D col)
    {
        
        if (col.gameObject.tag == "Player")
        {
            PlayerHP.HP -= Damage;
        }
    }
}
