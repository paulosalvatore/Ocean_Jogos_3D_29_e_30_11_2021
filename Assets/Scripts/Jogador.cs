using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jogador : MonoBehaviour
{
    public Rigidbody rb;

    public float velocidade = 3;

    int placar = 0;

    public Text placarText;

    // Start is called before the first frame update
    void Start()
    {
        placarText.text = "Placar: " + placar;
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

    private void OnCollisionEnter(Collision other)
    {
        // print("Colisão entre Jogador e " + other.gameObject.name);

        if (other.gameObject.CompareTag("BalaCanhão"))
        {
            // print("Colidimos com a bala de canhão");

            placar = placar + 1;
            // Podemos encurtar essa declaração: placar += 1; ou placar++;

            placarText.text = "Placar: " + placar;
        }

        /*
        // Exemplos de códigos para ajudar na depuração
        // Método C# tradicional
        Console.WriteLine("Texto 0");

        // Unity
        Debug.Log("Texto 1");
        Debug.LogError("Texto 2");
        Debug.LogWarning("Texto 3");

        // Unity para facilitar para quem tá começando (equivalente a Debug.Log)
        print("Texto 4");
        */
    }
}
