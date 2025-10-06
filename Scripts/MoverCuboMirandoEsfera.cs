using UnityEngine;

// Clase que mueve un cubo hacia una esfera, girando para mirarla y avanzando hacia ella
public class MoverCuboMirandoEsfera : MonoBehaviour
{
    public float speed = 5f;
    public string tagEsfera = "Esfera";
    private Transform esfera;

    void Start()
    {
        // Buscar la esfera por tag
        GameObject obj = GameObject.FindWithTag(tagEsfera);
        if (obj != null)
            esfera = obj.transform;
        else
            Debug.LogWarning("No se encontró ningún objeto con el tag: " + tagEsfera);
    }

    void Update()
    {
        if (esfera == null) return;

        // Dirección hacia la esfera
        Vector3 direccion = esfera.position - transform.position;
        direccion.y = 0f;

        if (direccion.magnitude > 0.01f)
        {
            // --- Girar para mirar a la esfera ---
            transform.LookAt(new Vector3(esfera.position.x, transform.position.y, esfera.position.z));
            Vector3 movimiento = direccion.normalized * speed * Time.deltaTime;
            transform.Translate(movimiento, Space.World);
        }
    }
}

