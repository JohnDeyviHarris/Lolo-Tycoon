using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiperSilka : MonoBehaviour
{
    [SerializeField] TypeSsilka Type;
    public void GotoSsilka()
    {
        if (Type == TypeSsilka.Mirohodec)
        {
            Application.OpenURL("https://mirohodec.ru/");
        }
        if (Type == TypeSsilka.Uni)
        {
            Application.OpenURL("https://my-uni.store/");
        }
    }
}

[SerializeField] enum TypeSsilka
{
    Mirohodec,
    Uni
}
