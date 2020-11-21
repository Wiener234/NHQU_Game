using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIFunctions : MonoBehaviour
{
    public void Save()
    {
        PlayerMove player = GameObject.Find("Player").GetComponent<PlayerMove>();
        SaveSystem.SavePlayer(player);
    }
}
