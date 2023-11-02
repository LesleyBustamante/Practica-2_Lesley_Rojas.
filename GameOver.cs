using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{
    float TiempoPartida = 0.0f;
    bool Jugando = true;
    [SerializeField]
    GameObject mensajecaida;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Jugando)
        {
            TiempoPartida = Time.deltaTime;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("caida"))
        {
            Time.timeScale = 0;
            Jugando = false;
            mensajecaida.SetActive(true);
        }
    }
}
