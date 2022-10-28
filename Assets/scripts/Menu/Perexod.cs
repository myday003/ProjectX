
using UnityEngine;
using UnityEngine.SceneManagement;

public class Perexod : MonoBehaviour
{
    [SerializeField] private string WhichScene;
    public void PerexodNaScenu()
    {
        SceneManager.LoadScene(WhichScene);
    }
}
