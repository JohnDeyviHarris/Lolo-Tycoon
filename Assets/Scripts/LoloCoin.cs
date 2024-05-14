using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoloCoin : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private int cost;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Conveyor")
        {
            rb.velocity = new Vector3(5, rb.velocity.y, rb.velocity.z);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<Finish>(out Finish scr))
        {
            scr.Finisher(cost);
            Destroy(gameObject);
        }
    }
}
