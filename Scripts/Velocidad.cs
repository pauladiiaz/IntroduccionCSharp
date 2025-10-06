using UnityEngine;

// Clase que muestra en consola la velocidad de desplazamiento según las flechas del teclado
public class Velocidad : MonoBehaviour
{
    public float velocidad = 5f; // configurable desde el Inspector

    void Update()
    {
        float ejeHorizontal = Input.GetAxis("Horizontal"); // izquierda-derecha
        float ejeVertical = Input.GetAxis("Vertical");     // arriba-abajo

        // Revisamos cada flecha
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log($"Flecha Derecha: {velocidad * ejeHorizontal * Time.deltaTime}");
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log($"Flecha Izquierda: {velocidad * ejeHorizontal * Time.deltaTime}");
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log($"Flecha Arriba: {velocidad * ejeVertical * Time.deltaTime}");
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log($"Flecha Abajo: {velocidad * ejeVertical * Time.deltaTime}");
        }
    }
}

