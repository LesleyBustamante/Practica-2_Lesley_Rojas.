using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoMoneda : MonoBehaviour
{
    public AudioClip monedaSound;
    private AudioSource audioSource;
    public AudioSource musicaFondo;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Monedas"))
        {
            PlaymonedaSound();
        }
    }
    private void PlaymonedaSound()
    {
        if (monedaSound != null)
        {
            audioSource.PlayOneShot(monedaSound);
        }
    }
 
      
  // Update is called once per frame
        void Update()
    {
        
    }
}
