using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Depuracion : MonoBehaviour
{
    public float velocidad = 5f;

    void Update()
    {
        // Obtener la entrada del teclado
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        // Calcular el vector de movimiento
        UnityEngine.Vector3 movimiento = new UnityEngine.Vector3 (movimientoHorizontal, 0f, movimientoVertical);

        // Mover el objeto en la direcci�n calculada
        transform.Translate (movimiento* velocidad * Time.deltaTime, Space.World);
    }
}