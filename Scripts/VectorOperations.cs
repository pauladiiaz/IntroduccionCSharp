using UnityEngine;

// Clase que realiza diversas operaciones con vectores y muestra los resultados en consola
public class VectorOperations : MonoBehaviour
{
    [Header("Vectores para operaciones")]
    public Vector3 vector1 = new Vector3(1.0f, 2.0f, 3.0f);
    public Vector3 vector2 = new Vector3(4.0f, 5.0f, 6.0f);
    
    [Header("Resultados (Solo lectura)")]
    [SerializeField] private float magnitudVector1;
    [SerializeField] private float magnitudVector2;
    [SerializeField] private float anguloEntreVectores;
    [SerializeField] private float distanciaEntreVectores;
    [SerializeField] private string vectorMayorAltura;

    void Start()
    {
        CalcularOperaciones();
        MostrarEnConsola();
    }

    void CalcularOperaciones()
    {
        // Calcular magnitudes
        magnitudVector1 = vector1.magnitude;
        magnitudVector2 = vector2.magnitude;
        
        // Calcular ángulo entre vectores (en grados)
        anguloEntreVectores = Vector3.Angle(vector1, vector2);
        
        // Calcular distancia entre vectores
        distanciaEntreVectores = Vector3.Distance(vector1, vector2);
        
        // Determinar qué vector está a mayor altura (componente Y)
        if (vector1.y > vector2.y)
        {
            vectorMayorAltura = "Vector1 está a mayor altura";
        }
        else if (vector2.y > vector1.y)
        {
            vectorMayorAltura = "Vector2 está a mayor altura";
        }
        else
        {
            vectorMayorAltura = "Ambos vectores están a la misma altura";
        }
    }

    void MostrarEnConsola()
    {
        Debug.Log("=== OPERACIONES CON VECTORES ===");
        Debug.Log($"Vector1: {vector1}");
        Debug.Log($"Vector2: {vector2}");
        Debug.Log($"Magnitud del Vector1: {magnitudVector1:F2}");
        Debug.Log($"Magnitud del Vector2: {magnitudVector2:F2}");
        Debug.Log($"Ángulo entre vectores: {anguloEntreVectores:F2} grados");
        Debug.Log($"Distancia entre vectores: {distanciaEntreVectores:F2}");
        Debug.Log($"Altura: {vectorMayorAltura}");
        Debug.Log("================================");
    }
}
