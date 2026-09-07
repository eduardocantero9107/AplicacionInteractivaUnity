using UnityEngine;

public class WebLinks : MonoBehaviour
{
    public void AbrirUnity()
    {
        Application.OpenURL("https://unity.com/");
    }

    public void AbrirDocumentacion()
    {
        Application.OpenURL("https://docs.unity3d.com/");
    }

    public void AbrirGitHub()
    {
        Application.OpenURL("https://github.com/");
    }
}
