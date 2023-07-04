using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text CoinText;
    public TMP_Text WinText;
    public TMP_Text EndText;

    private int CoinAmount;

    private void Awake()
    {
        WinText.enabled = false;
        EndText.enabled = false;
    }

    private void CoinCount()
    {
        CoinAmount++;
        CoinText.text = "Monedas: " + CoinAmount;
    }

    private void OnEnable()
    {
        CoinScript.MonedaEvent += CoinCount;
        RedScript.redwallEvent += Win;
        BlueScript.bluewallEvent += EndGame;
    }

    private void OnDisable()
    {
        CoinScript.MonedaEvent -= CoinCount;
    }
    private void Win()
    {
        WinText.enabled = true;
    }

    private void EndGame()
    {
        EndText.enabled = true;
    }

}
