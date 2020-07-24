using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_corpHolambra : MonoBehaviour
{

    scr_gerenciadorSatisfacao corpSatisLink;
    scr_gerenciadorMain mainLink;
    int indice = 1;

    void Start()
    {
        corpSatisLink = GameObject.FindGameObjectWithTag("GerenComp").GetComponent<scr_gerenciadorSatisfacao>();
        mainLink = GameObject.FindObjectOfType<scr_gerenciadorMain>().GetComponent<scr_gerenciadorMain>();
    }

  
    void Update()
    {
        if (corpSatisLink.recurso <= 0)
        {
            indice = 0;
        }
        if (corpSatisLink.recurso >0 && corpSatisLink.recurso < 299)
        {
            indice = 1;
        }
        else if (corpSatisLink.recurso > 299 && corpSatisLink.recurso < 599)
        {
            indice = 2;
        }
        else if (corpSatisLink.recurso > 599 && corpSatisLink.recurso < 799)
        {
            indice = 3;
        }
        else if (corpSatisLink.recurso > 799 && corpSatisLink.recurso <= 1000)
        {
            indice = 4;
        }
        else
        {
            indice = 4;
            corpSatisLink.recurso = 1000;
        }

        switch (indice)
        {
            case 1:
                mainLink.florinPassivoAdicional = 2000;
                break;
            case 2:
                mainLink.florinPassivoAdicional = 3000;
                break;
            case 3:
                mainLink.florinPassivoAdicional = 4000;
                break;
            case 4:
                mainLink.florinPassivoAdicional = 5000;
                break;
            case 0:
                mainLink.GameOver();
                break;

        }
    }
}
