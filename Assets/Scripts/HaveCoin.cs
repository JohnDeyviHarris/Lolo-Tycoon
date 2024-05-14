using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HaveCoin : MonoBehaviour
{
    public int lolocoin;
    [SerializeField] private TextMeshProUGUI coinInd;
    public void GetMoney(int skoko)
    {
        lolocoin += skoko;
        coinInd.text = lolocoin.ToString();
    }
}
