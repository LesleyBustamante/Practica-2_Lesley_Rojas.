using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    float movementspeed;
    Rigidbody Rigidbody;
    public Vector3 rotacionfija = new Vector3(0, 90, 0);
    float fuerzasalto;
    float fuerzagravedad;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
        movementspeed = 10f;
        fuerzasalto = 22f;
        fuerzagravedad = 30f;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalinput = Input.GetAxis("Horizontal") * Time.deltaTime * movementspeed;
        float verticalinput = Input.GetAxis("Vertical") * Time.deltaTime * movementspeed;
        transform.Translate(horizontalinput, 0, verticalinput);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * fuerzasalto, ForceMode.Impulse);
        }
        Rigidbody.useGravity = true;
        Rigidbody.mass = 1.0f;
        Rigidbody.AddForce(Vector3.down * Rigidbody.mass * fuerzagravedad, ForceMode.Force);
    }

}
