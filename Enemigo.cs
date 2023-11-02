using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public float speed;
    Transform eliminar;
    float TiempoPartida = 0.0f;
    bool Jugando = true;
    [SerializeField]
    GameObject mensajecaida;
    // Start is called before the first frame update
    void Start()
    {
        eliminar = GameObject.FindGameObjectWithTag("Personaje").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, eliminar.position, speed * Time.deltaTime);
        if (Jugando )
        {
            TiempoPartida = Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider Eliminacion)
    {
        if (Eliminacion.tag == "Personaje")
        {
            Time.timeScale = 0;
            Jugando = false;
            mensajecaida.SetActive(true);
        }
    }
}
