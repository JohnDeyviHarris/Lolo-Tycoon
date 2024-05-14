using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] private HaveCoin Manager;
    public void Finisher(int cost)
    {
        Manager.GetMoney(cost);
    }
}
