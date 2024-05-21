using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent<LoloCoin>(out LoloCoin scr))
        {
            CoinManager.GetMoney(scr.cost);
            Destroy(collision.gameObject);
        }
    }
}
