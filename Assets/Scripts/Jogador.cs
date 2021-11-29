using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    public Rigidbody rb;

    public float velocidade = 3;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*
        - Pegar os valores das setinhas
        - Setinhas para cima e para baixo (eixo vertical) modificarão o eixo Z
        - Setinhas para direita e para esquerda (eixo horizontal) modificarão o eixo X
        - Eixo Y permanecerá o valor que estiver atualmente
        - Com os valores estabelecidos, movimentaremos o Rigidbody
        - Para isso, iremos alterar a velocidade do Rigidbody
        */

        var v = Input.GetAxis("Vertical") * velocidade;
        var h = Input.GetAxis("Horizontal") * velocidade;

        rb.velocity = new Vector3(h, rb.velocity.y, v);
    }
}
