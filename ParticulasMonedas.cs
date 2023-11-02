using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticulasMonedas : MonoBehaviour
{
    public ParticleSystem particulas;
    private bool collecting = false;
    // Start is called before the first frame update
    void Start()
    {
        particulas.Stop();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Monedas") && !collecting)
        {
            ActivateParticles();
            collecting = true; 
        }
    }
    void ActivateParticles()
    {
        particulas.Play();
        Invoke("StopParticles", 1.5f);
    }
    void StopParticles()
    {
        particulas.Stop();
        collecting = false;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
