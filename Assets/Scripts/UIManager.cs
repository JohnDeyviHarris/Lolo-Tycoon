using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public void CloseUI(GameObject UI)
    {
        UI.SetActive(false);
    }
    public void OpenUI(GameObject UI)
    {
        UI.SetActive(true);
    }
}
