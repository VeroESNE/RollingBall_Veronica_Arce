using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Player : MonoBehaviour
{
    float velocidad = 3f; //Velocidad de mi bola.
    Vector3 salto = new Vector3(0, 2, 0); //Salto de mi bola.

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Los valores de entrada de mi bola.
        float movimientoHorizontal = Input.GetAxisRaw("Horizontal"); //Se mueve con 
        float movimientoVertical = Input.GetAxisRaw("Vertical");
        //Código que calcula movimiento.
        Vector3 direccion = new Vector3(movimientoHorizontal, 0, movimientoVertical);
        //Código que mueve la bola.
        transform.Translate(direccion * velocidad * Time.deltaTime, Space.World);


        //Código que hace saltar mi bola.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(salto, ForceMode.Impulse);
        }
    }
}
