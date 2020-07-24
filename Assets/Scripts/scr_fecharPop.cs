using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_fecharPop : MonoBehaviour
{
    public GameObject painel;

    public void Fechar()
    {
        painel.SetActive(false);
    }
}
