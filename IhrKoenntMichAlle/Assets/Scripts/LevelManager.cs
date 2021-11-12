using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class LevelManager : MonoBehaviour
{
    public Transform respawnPoint;
    public GameObject playerPrefab; 

    public CinemachineVirtualCameraBase cam;

    public static LevelManager instance;


    private void Awake()
    {
        instance = this; 
    }
    public void RespawnCuck()
    {
        GameObject player = Instantiate(playerPrefab, respawnPoint.position, Quaternion.identity);
        cam.Follow = player.transform;
    }
}
