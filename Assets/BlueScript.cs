using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BlueScript : MonoBehaviour
{
    public delegate void blueWallEvent();
    public static blueWallEvent bluewallEvent;
    public TMP_Text WinText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            bluewallEvent?.Invoke();
            WinText.enabled = false;
        }
    }
}

