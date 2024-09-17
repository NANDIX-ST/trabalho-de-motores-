using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vector3 = UnityEngine.Vector3;

public class Player : MonoBehaviour
{
    public int velocidade = 10;
    public int forcapulo = 10;
    public bool noChao;
    Rigidbody rb;
    public AudioSource source;


    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent(out rb);
        TryGetComponent(out source);
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (!noChao && collision.gameObject.tag == "chao")
        {
            noChao = true;
        }
    }

    // Update is called once per frame
    void Update()
    {

        float h = Input.GetAxis("Horizontal"); // -1 esquerda, 0 nada, 1 direito
        float v = Input.GetAxis("Vertical"); // -1 pra tras, 0 nada, 1 pra frente 
        Vector3 direcao = new Vector3(h, 0, v);
        rb.AddForce(direcao * velocidade * Time.deltaTime, ForceMode.Impulse);

        if (Input.GetKeyDown(KeyCode.Space) && noChao)
        {
            rb.AddForce(Vector3.up * forcapulo, ForceMode.Impulse);
            noChao = false;
            source.Play();
        }

        if (transform.position.y <= -10)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

}
    
    
    
