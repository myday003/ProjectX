
using UnityEngine;
public class PlayerHP : MonoBehaviour
{
    public static float maxHP = 100;
    public static float HP = 100;
    private void Update()
    {
        if (HP > maxHP) 
        {
            HP = maxHP; 
        }
    }
}
     