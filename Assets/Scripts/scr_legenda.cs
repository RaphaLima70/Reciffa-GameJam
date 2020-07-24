using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_legenda : MonoBehaviour
{
    public GameObject legenda;

    private void Start()
    {
        Solto();
    }

    public void Tocando()
    {
        legenda.SetActive(true);
    }

    public void Solto()
    {
        legenda.SetActive(false);
    }
}
