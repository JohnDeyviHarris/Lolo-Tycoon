using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleManager : MonoBehaviour
{
    public void ToggleOn(GameObject Obj)
    {
        Obj.SetActive(true);
    }
    public void ToggleOff(GameObject Obj) {  Obj.SetActive(false); }
}
