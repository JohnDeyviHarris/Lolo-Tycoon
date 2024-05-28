using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] private List<CinemachineVirtualCamera> cameri;
    public void Switchcamera(int turtle)
    {
        for (int i = 0; i < cameri.Count; i++)
        {
            cameri[i].gameObject.SetActive(i == turtle);
        }
    }
}
