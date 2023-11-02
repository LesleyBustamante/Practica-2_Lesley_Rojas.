using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public float speed;
    private Transform personaje;
    // Start is called before the first frame update
    void Start()
    {
        personaje = GameObject.FindGameObjectWithTag("Personaje").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, personaje.position + new Vector3(3.65f, 1.48f, -10.42f), speed * Time.deltaTime);
    }
}
