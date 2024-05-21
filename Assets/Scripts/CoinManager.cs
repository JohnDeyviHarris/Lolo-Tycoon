using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public int lolocoin;
    [SerializeField] private TextMeshProUGUI coinInd;
    private static CoinManager instance;
    private void Awake()
    {
        instance = this;
    }
    public static void GetMoney(int skoko)
    {
        instance.lolocoin += skoko;
        instance.coinInd.text = instance.lolocoin.ToString();
    }
}
