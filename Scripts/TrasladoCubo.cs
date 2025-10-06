using UnityEngine;

// Clase que traslada un cubo en una dirección y velocidad configurables, en sistema local o mundial
public class TrasladoCubo : MonoBehaviour
{
    [Header("Dirección y velocidad del movimiento")]
    public Vector3 moveDirection = new Vector3(1, 0, 0);
    public float speed = 2f;

    [Header("Sistema de referencia")]
    public bool usarMundo = true; // true = sistema mundial, false = sistema local

    void Start()
    {
        Vector3 pos = transform.position;
        pos.y = 0f;
        transform.position = pos;
    }

    void Update()
    {
        Vector3 desplazamiento = moveDirection * speed * Time.deltaTime;

        if (usarMundo)
            transform.Translate(desplazamiento, Space.World);
        else
            transform.Translate(desplazamiento, Space.Self);

        Debug.Log($"Cubo posición: {transform.position}, desplazamiento: {desplazamiento}");
    }
}

