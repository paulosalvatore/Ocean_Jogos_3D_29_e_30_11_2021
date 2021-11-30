using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canhao : MonoBehaviour
{
    public GameObject balaCanhao;

    public float delayInicial = 1f;

    public float delayEntreObjetos = 2f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GerarObjeto", delayInicial, delayEntreObjetos);
    }

    void GerarObjeto()
    {
        Instantiate(balaCanhao, transform.position, transform.rotation);
    }
}
