using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_construcao : MonoBehaviour
{
    public scr_gerenciadorMain linkMain;
    public scr_gerenciadorSatisfacao linkSatisColonos;
    public scr_gerenciadorSatisfacao linkSatisComp;

    public int modificaHolambra;
    public int modificaColonos;
    public int custoMoradia;

    // Start is called before the first frame update
    void Start()
    {
        linkMain = GameObject.FindObjectOfType<scr_gerenciadorMain>();
        linkSatisColonos = GameObject.FindGameObjectWithTag("GerenColonos").GetComponent<scr_gerenciadorSatisfacao>();
        linkSatisComp = GameObject.FindGameObjectWithTag("GerenComp").GetComponent<scr_gerenciadorSatisfacao>();
        Atualizacao();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Atualizacao()
    {
        linkMain.moradiaAtual += custoMoradia;
        linkSatisComp.ModificaAtivo(modificaHolambra);
        linkSatisColonos.ModificaAtivo(modificaColonos);
    }

    public void Comportamento()
    {

    }

}
