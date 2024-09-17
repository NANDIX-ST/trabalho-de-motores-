using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moeda : MonoBehaviour
{
    public int velocidadeGiro = 50;
    
    void start()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    
    {
        if (other.gameObject.tag == "Player")
        {
            FindObjectOfType<GameManager>().SubtrairMoedas(valor:1);
            Destroy(gameObject);
        }
    }
    
    
    void Update()
    {
        transform.Rotate(Vector3.forward * velocidadeGiro * Time.deltaTime);
    }
}
