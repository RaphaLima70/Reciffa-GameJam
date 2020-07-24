using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_cameraMovement : MonoBehaviour
{
    public float margem = 50;
    public Transform limCima;
    public Transform limBaixo;
    public Transform limEsq;
    public Transform limDir;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = Input.mousePosition;
        if (pos.x > (Screen.width - margem) && transform.position.x < limDir.position.x)
        {
            //Debug.Log("Encostou Direita");
            transform.Translate(Vector3.right * 10 * Time.deltaTime);
        }
        else if (pos.x < margem && transform.position.x > limEsq.position.x)
        {
            //Debug.Log("Encostou Esquerda");
            transform.Translate(Vector3.left * 10 * Time.deltaTime);
        }

        if (pos.y > Screen.height - margem && transform.position.z < limCima.position.z)
        {
            //Debug.Log("Encostou Cima");
            transform.Translate(Vector3.forward * 10 * Time.deltaTime);
        }
        else if (pos.y < margem && transform.position.z > limBaixo.position.z)
        {
            //Debug.Log("Encostou Baixo");
            transform.Translate(Vector3.back * 10 * Time.deltaTime);
        }

        if (Input.mouseScrollDelta.y > 0 && transform.position.y > 3.6f)
        {
            //aproxima
            transform.Translate(Vector3.down * 10 * Time.deltaTime);
        }
        else if(Input.mouseScrollDelta.y < 0 && transform.position.y < 7.5f)
        {
            //afasta
            transform.Translate(Vector3.up * 10 * Time.deltaTime);
        }
    }
}
