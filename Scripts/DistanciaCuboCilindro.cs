using UnityEngine;

// Clase que calcula y muestra en consola la distancia desde la esfera a un cubo y un cilindro
public class DistanciaCuboCilindro : MonoBehaviour
{
    private GameObject cubo;
    private GameObject cilindro;
    private float distanciaAlCubo;
    private float distanciaAlCilindro;

    void Start()
    {
        // Buscar los objetos por etiqueta
        cubo = GameObject.FindWithTag("Cubo");
        cilindro = GameObject.FindWithTag("Cilindro");
        CalcularDistancias();
    }

    void Update()
    {
        CalcularDistancias();
    }
    
    void CalcularDistancias()
    {
        distanciaAlCubo = Vector3.Distance(transform.position, cubo.transform.position);
        distanciaAlCilindro = Vector3.Distance(transform.position, cilindro.transform.position);
        MostrarDistanciasEnConsola();
    }
    
    void MostrarDistanciasEnConsola()
    {
        Debug.Log("=== DISTANCIAS DESDE LA ESFERA ===");
        Debug.Log($"Distancia al Cubo: {distanciaAlCubo:F2} unidades");
        Debug.Log($"Distancia al Cilindro: {distanciaAlCilindro:F2} unidades");  
        Debug.Log("==================================");
    }
}