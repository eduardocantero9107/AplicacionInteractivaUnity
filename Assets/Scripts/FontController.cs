using UnityEngine;
using TMPro;

public class FontController : MonoBehaviour
{
    public TMP_Text texto;

    public TMP_FontAsset fuente1;
    public TMP_FontAsset fuente2;

    public void UsarFuente1()
    {
        texto.font = fuente1;
    }

    public void UsarFuente2()
    {
        texto.font = fuente2;
    }
}