using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    float timer = 0f;
    Vector3 UpDirection = new Vector3(0, 1, 0);
    Vector3 DownDirection = new Vector3(0, -1, 0);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Código que hace rotar el coleccionable.
        transform.Rotate(Vector3.up * 90 * Time.deltaTime, Space.World);

        //Futuro código que sube y baja el coleccionable. 
        //La primera parte del código hace que el coleccionable suba.

        //transform.Translate(UpDirection * 2 * Time.deltaTime, Space.World);
        //timer += 1 * Time.deltaTime;
        //if (timer > 5)
        //{
        //    transform.Translate(DownDirection * 2 * Time.deltaTime, Space.World);
        //    timer = 0;
        //}


        //Código para que la moneda se destruya cuando la bola choca con ella.

    }

    private void OnCollisionEnter(Collision collision)
    {
        // Verificar si el objeto con el que colisionamos es el jugador
        if (collision.gameObject.CompareTag("Player"))
        {
            // Destruir este objeto (Collectable) al colisionar con el jugador
            Destroy(gameObject);
        }
    }
}
