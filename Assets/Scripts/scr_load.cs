using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scr_load : MonoBehaviour
{
    public Image barraLoad;
    public float timer;
    public float tempoLoad;

    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        barraLoad.fillAmount = (timer / tempoLoad) *1;
    }
}
