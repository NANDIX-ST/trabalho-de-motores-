using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI hud, msgVitoria;
    public int restantes;
    public AudioClip clipMoeda, clipVitoria;



    private AudioSource Soucer;
    
    
    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent(out Soucer);
        restantes = FindObjectsOfType<Moeda>().Length;
        
        hud.text = $"Moedas restantes: {restantes}";
    }


    public void SubtrairMoedas(int valor)
    {
        restantes -= valor;
        hud.text = $"Moedas restantes: {restantes}";
        Soucer.PlayOneShot(clipMoeda);
        
        if (restantes <=0 )
        {

            //ganhou o jogo
            msgVitoria.text = "parabens!";
            Soucer.Stop();
            Soucer.PlayOneShot(clipVitoria);
        }
        
        
        hud.text = $"Moedas restantes: {restantes}";
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
