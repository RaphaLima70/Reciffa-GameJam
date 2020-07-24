using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scr_gerenciadorSatisfacao : MonoBehaviour
{
    //nome do recurso
    public string nomeRecurso;

    //valor atual do recurso
    public int recurso;

    //valor inicial do recurso
    public int recursoStart;

    //imagem do recurso
    public Text recursoTxt;

    //tempo para diminuir o recurso
    public float timerDmin;

    //tempo atual para diminuição
    public float tempoAtual;

    //valores para alterar passivamente o valor do recurso
    public int valorAumentarPass;
    public int valorDecrescerPass;

    void Start()
    {
        recurso = recursoStart;
        tempoAtual = 0;
    }

    void Update()
    {
        DiminuidorPassivo();

        AtualizarTxt();
    }

    public void AtualizarTxt()
    {
        recursoTxt.text = ""+ recurso;
    }

    public void DiminuidorPassivo()
    {
        if (tempoAtual < timerDmin)
        {
            tempoAtual += Time.deltaTime;
        }
        else
        {
            recurso -= valorDecrescerPass;
            tempoAtual = 0;
        }
    }

    public void ModificaAtivo(int valorASerModificado)
    {
        recurso += valorASerModificado;
    }
}
