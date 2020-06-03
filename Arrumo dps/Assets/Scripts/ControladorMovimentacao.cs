using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorMovimentacao : MonoBehaviour
{
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
      rb = GetComponent<Rigidbody2D>(); 
    }

    public void Mover(float velocidade)
    {
        rb.AddForce(new Vector2(velocidade, 0));
    }

    public void Pular(float velocidade)
    {
        rb.AddForce(new Vector2(0, velocidade));
    }
}
