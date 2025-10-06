using UnityEngine;

// Clase que mueve un cubo hacia una esfera a velocidad constante
public class MoverCuboHaciaEsfera : MonoBehaviour
{
    public float speed = 5f;
    public string tagEsfera = "Esfera";
    private Transform esfera;

    void Start()
    {
        esfera = GameObject.FindWithTag(tagEsfera)?.transform;
    }

    void Update()
    {
        if (esfera == null) return; // seguridad

        // Dirección hacia la esfera
        Vector3 direccion = esfera.position - transform.position;
        direccion.y = 0f;
        direccion = direccion.normalized;
        Vector3 movimiento = direccion * speed * Time.deltaTime;

        transform.Translate(movimiento, Space.World);
    }
}