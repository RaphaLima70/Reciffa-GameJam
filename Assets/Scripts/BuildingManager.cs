using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class BuildingManager : MonoBehaviour
{
    //Referência aos dados das construções
    public scr_buildingData data;
    //Imagens dos construções do painel
    public Image[] itens;
    //tipo de spawn que esse spawn têm, podendo ser terrestre ou maritmo
    public SlotType slot;

    //Objeto do painel de construções
    public GameObject painel;
    //posição onde as construções serão criadas
    Transform posicao;

    public GameObject loadObj;

    public scr_gerenciadorMain linkMain;

    public AudioSource somBuilding;

    //lista de objetos a serem spawnados escolhidos baseado no tipo de spawn
    [SerializeField]
    List<Building> selecionadas = new List<Building>();

    public SpawnPoint activeSpawnPoint;

    void Start()
    {
        posicao = GetComponent<Transform>();
        linkMain = GameObject.FindObjectOfType<scr_gerenciadorMain>();
        //Desativa Painel de Construções
        painel.SetActive(false);

        //Desativa os itens do painel
        for (int i = 0; i < itens.Length; i++)
        {
            itens[i].gameObject.SetActive(false);
        }



        //instancia uma construção de teste
        //Instantiate(selecionadas[0].prefab, new Vector3(posicao.position.x, posicao.position.y + 0.01f, posicao.position.z), transform.rotation);

    }

    //serve para fechar o painel de construções
    public void Limpar()
    {
        for (int i = 0; i < itens.Length; i++)
        {
            itens[i].gameObject.SetActive(false);
        }
        painel.SetActive(false);
        selecionadas.RemoveRange(0, selecionadas.Count);
    }

    //Faz aparecer os itens de construções no painel
    public void MostrarConstrucoesParaSlot()
    {
        AlinhaSlot(activeSpawnPoint.slot);
        for (int i = 0; i < itens.Length; i++)
        {
            if (i < selecionadas.Count)
            {
                itens[i].gameObject.SetActive(true);
                itens[i].sprite = selecionadas[i].img;
            }
            else
            {
                itens[i].gameObject.SetActive(false);
            }
        }
    }

    //Cria a construção definida através da imagem clicada
    public void Criar(int i)
    {
        StartCoroutine(Spawnando(selecionadas[i].tempoDeConstrucao,i));
    }

    internal void OnSpawnPointSelected(SpawnPoint spawnPoint)
    {
        Limpar();
        painel.SetActive(true);
        activeSpawnPoint = spawnPoint;
        MostrarConstrucoesParaSlot();
    }

    public void AlinhaSlot(SlotType slot)
    {
        //passa somente as construções do tipo dá spawn para o array selecionadas
        foreach (Building b in data.buildings)
        {
            if (b.slot == slot)
            {
                selecionadas.Add(b);
            }
        }
    }

    public IEnumerator Spawnando(float tempo, int i)
    {
        if (selecionadas[i].custo <= linkMain.florinNassau)
        {
            SpawnPoint spawnLocal = activeSpawnPoint;
            linkMain.florinNassau -= selecionadas[i].custo;
            spawnLocal.gameObject.GetComponent<MeshRenderer>().enabled = false;

            GameObject load = Instantiate(loadObj);
            load.GetComponent<scr_load>().tempoLoad = tempo;
            load.transform.position = spawnLocal.transform.position + Vector3.up * 0.05f;
            yield return new WaitForSeconds(tempo);

            Destroy(load);
            GameObject spawnedObj = Instantiate(selecionadas[i].prefab);
            spawnedObj.transform.position = spawnLocal.transform.position + Vector3.up * 0.05f;
            somBuilding.Play();
        }
        else
        {
            Debug.Log("liso pega no pau de aluisio");
        }


    }

}
