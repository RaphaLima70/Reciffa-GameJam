using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scr_gerenciadorMain : MonoBehaviour
{
    [Tooltip("contador de dinheiro atual")]
    public int florinNassau;

    [Tooltip("contador de tempo de jogo")]
    public float tempoDePartida;

    [Tooltip("Quantidade de tempo para se passar um ano")]
    public float tempoDeAno;

    [Tooltip("variável que armazena o tempo de jogo em anos")]
    public int anoAtual;

    [Tooltip("Quantidade de estruturas total")]
    public int qtdEstruturasTotal;

    [Tooltip("Quantidade de estruturas atual")]
    public int qtdEstruturasAtual;

    [Tooltip("Porcentagem de estruturas total")]
    public float dominioAtual;

    [Tooltip("Objeto de texto que mostra o tempo de jogo através dos anos")]
    public Text anoTxt;

    [Tooltip("Objeto de texto que mostra a porcentagem de domínio do player")]
    public Text dominioAtualTxt;

    [Tooltip("Objeto de texto que mostra a quantidade de dinheiro do player")]
    public Text florinsTxt;

    [Tooltip("comida atual")]
    public int comidaAtual;

    [Tooltip("comida máxima")]
    public int comidaMax;

    [Tooltip("moradia atual")]
    public int moradiaAtual;

    [Tooltip("moradia máxima")]
    public int moradiaMax;

    [Tooltip("deposito atual")]
    public int depositoAtual;

    [Tooltip("deposito máximo")]
    public int depositoMax;

    [Tooltip("florins passivos base")]
    public int florinPassivoBase;

    [Tooltip("florins passivos adicionais")]
    public int florinPassivoAdicional;

    [Tooltip("intervalo de tempo que o florin é aumentado")]
    public float tempoMaxFlorin;

    [Tooltip("contador de tempo atual do contador de tempo dos florins")]
    public float tempoAtualFlorin;

    [Tooltip ("Painel de gameOver")]
    public GameObject gameOverPanel;

    //gerenciadores de satisfação
    public scr_gerenciadorSatisfacao gerenColonos;
    public scr_gerenciadorSatisfacao gerenHolambra;

    private void Awake()
    {
        //gerenColonos = GameObject.FindGameObjectWithTag("gerenColonos").GetComponent<scr_gerenciadorSatisfacao>();
        //gerenHolambra = GameObject.FindGameObjectWithTag("gerenHolambra").GetComponent<scr_gerenciadorSatisfacao>();

    }
    void Start()
    {
        florinNassau = 10000;
        moradiaAtual = 0;
        moradiaMax = 10;
        comidaAtual = 0;
        comidaMax = 10;
    }

    void Update()
    {
        MostraTempo();
        MostraInfos();
        AumetaFlorins();
    }

    void MostraInfos()
    {
        florinsTxt.text = "" + florinNassau;
        dominioAtual = ((float)qtdEstruturasAtual / (float)qtdEstruturasTotal) * 100;
        //dominioAtualTxt.text = "" + dominioAtual +"%";
        //moradiaTxt.text = "" + moradiaAtual;
    }

    void MostraTempo()
    {
        tempoDePartida += Time.deltaTime;

        if (tempoDePartida > tempoDeAno)
        {
            tempoDePartida = 0;
            anoAtual++;
        }

        anoTxt.text = "" + anoAtual;
    }

    public void AumetaFlorins()
    {
        tempoAtualFlorin += Time.deltaTime;

        if (tempoAtualFlorin > tempoMaxFlorin)
        {
            tempoAtualFlorin = 0;
            florinNassau += florinPassivoBase + florinPassivoAdicional;
        }
    }

    public void GameOver()
    {

    }
}
