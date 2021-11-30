using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canhao : MonoBehaviour
{
    public GameObject balaCanhao;

    public float delayInicial = 1f;

    public float delayEntreObjetos = 2f;

    [Range(100f, 2000f)]
    public float forcaCanhao = 500f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GerarObjeto", delayInicial, delayEntreObjetos);
    }

    void GerarObjeto()
    {
        var objetoGerado = Instantiate(balaCanhao, transform.position, transform.rotation);

        var rb = objetoGerado.GetComponent<Rigidbody>();

        rb.AddRelativeForce(Vector3.up * forcaCanhao);
    }
}
