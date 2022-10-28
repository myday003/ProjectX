using UnityEngine;

public class PlatAvto : MonoBehaviour
{
    public float Xspeed = 7f;
    private bool isInRight = false;
    private bool isMove = false;
    public float distanse = 7f;
    private float maxDist;
    private float minDist;


    private void Start()
    {
        maxDist = transform.position.x + distanse;
        minDist = transform.position.x - distanse;
    }
    private void Update()
    {
        if (isMove)
        {
            if (!isInRight)
            {
                RightMove();
            }
            else if (isInRight)
            {
                LeftMove();
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            isMove = true;
            RightMover.canMove = false;

        }
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            isMove = false;
            RightMover.canMove = true;
        }
    }
    void RightMove()
    {
        transform.position = new Vector2(transform.position.x + Xspeed * Time.deltaTime, transform.position.y);
        if (transform.position.x > maxDist)
        {
            isMove = false;
            isInRight = true;
        }
    }
    void LeftMove()
    {
        transform.position = new Vector2(transform.position.x - Xspeed * Time.deltaTime, transform.position.y);
        if (transform.position.x < minDist)
        {
            isMove = false;
            isInRight = false;

        }
    }
}