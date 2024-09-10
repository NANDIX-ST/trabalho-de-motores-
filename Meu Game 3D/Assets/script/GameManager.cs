using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI hud, msgVitoria;
    public int resetes;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        resetes = FindObjectsOfType<Moeda>().Length;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
