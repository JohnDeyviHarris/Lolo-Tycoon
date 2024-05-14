using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] private GameObject LoloCoin;
    [SerializeField] private float CD;
    private Coroutine Coroutine;
    void Drop()
    {
        Instantiate(LoloCoin, transform.position, LoloCoin.transform.rotation);
    }
    private void OnEnable()
    {
         Coroutine = StartCoroutine(DropwWithCD(CD));
    }
    private void OnDisable()
    {
        StopCoroutine(Coroutine);
    }
    private IEnumerator DropwWithCD(float CD)
    {
        Drop();
        yield return new WaitForSeconds(CD);
        Coroutine = StartCoroutine(DropwWithCD(CD));
    }
}
