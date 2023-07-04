using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RedScript : MonoBehaviour
{
    public delegate void redWallEvent();
    public static redWallEvent redwallEvent;
    public TMP_Text EndText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            redwallEvent?.Invoke();
            EndText.enabled = false;
        }
    }
}

