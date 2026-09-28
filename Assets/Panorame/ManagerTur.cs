using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerTur : MonoBehaviour
{
    public Camera cameraMea;

    public void MergiLaScena1()
    {
        SceneManager.LoadScene("Scena1");
    }

    // Asta e functia noua pe care tocmai am adaugat-o!
    public void MergiLaScena2()
    {
        SceneManager.LoadScene("Scena2");
    }

    public void FaZoom()
    {
        cameraMea.fieldOfView = 30f;
    }
}