using UnityEngine;

// Clase que define un objeto con un desplazamiento configurable en el Inspector
public class ObjetoConDesplazamiento : MonoBehaviour
{
    // Cada objeto tiene su desplazamiento público configurable en el Inspector
    public Vector3 desplazamiento;

    // Guardamos la posición inicial
    [HideInInspector]
    public Vector3 posicionInicial;

    void Start()
    {
        posicionInicial = transform.position;
    }
}