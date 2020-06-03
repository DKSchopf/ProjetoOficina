using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJogador : MonoBehaviour
{
    private ControladorMovimentacao controladorMovimentacao;

    public float velocidadeMovimento = 1000f;

    public float alturaPulo = 5000f;

    // Start is called before the first frame update
    void Start()
    {
        controladorMovimentacao = GetComponent<ControladorMovimentacao>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float direcao = 0f;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direcao -= 1f;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            direcao += 1f;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            controladorMovimentacao.Pular(alturaPulo * Time.deltaTime);
        }

        controladorMovimentacao.Mover(direcao * velocidadeMovimento * Time.deltaTime);
    }
}

   