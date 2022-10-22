
using UnityEngine;

public class SlowPlatform : MonoBehaviour
{
    public float debuff = 0.75f;
    private float konstspeed = RightMover.speed;
    private float konstJumpForse = RightMover.JumpForce;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            RightMover.speed = RightMover.speed * debuff;
            RightMover.JumpForce = RightMover.JumpForce * debuff;

        }
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            RightMover.speed = konstspeed;
            RightMover.JumpForce = konstJumpForse;
        }
    }

}
