using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public delegate void monedaEvent();
    public static monedaEvent MonedaEvent;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            MonedaEvent?.Invoke();
            Destroy(this.gameObject);
        }
    }

}
