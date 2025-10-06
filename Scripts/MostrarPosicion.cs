using UnityEngine;

// Clase que muestra en el inspector la posición de la esfera
public class MostrarPosicion : MonoBehaviour
{
    [Header("Posición de la esfera")]
    [SerializeField] public Vector3 posicionOriginal;

    void Start()
    {
        MostrarPosicionEnConsola();
    }

    void Update()
    {
        // Actualizar la posición en el inspector en tiempo real
        posicionOriginal = transform.position;
    }

    void MostrarPosicionEnConsola()
    {
        // Obtener la posición usando transform.position
        posicionOriginal = transform.position;
    }
}
