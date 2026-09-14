using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigation : MonoBehaviour
{
    public void IrASegundaEscena()
    {
        SceneManager.LoadScene("SegundaEscena");
    }

    public void Regresar()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
}