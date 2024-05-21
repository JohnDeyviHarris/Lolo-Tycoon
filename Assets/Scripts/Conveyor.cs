using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conveyor : MonoBehaviour
{
    [Range(-993, 993)]
    [SerializeField] private float ConveyorSpeed;
    private void OnTriggerStay(Collider other)
    {
        other.attachedRigidbody.velocity = transform.forward * ConveyorSpeed;
    }
}
