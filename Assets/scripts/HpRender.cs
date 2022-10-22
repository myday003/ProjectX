
using UnityEngine;
using UnityEngine.UI;

public class HpRender : MonoBehaviour
{
    private Text HPcount;
    private void Start()
    {
        HPcount = GetComponent<Text>();
    }

    void Update()
    {
        HPcount.text = "HP : " + (PlayerHP.HP).ToString();
    }
}
