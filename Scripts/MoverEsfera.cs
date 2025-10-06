using UnityEngine;

// Clase que permite mover una esfera con las teclas W, A, S, D, en espacio local o global
public class MoverEsfera : MonoBehaviour
{
    public float speed = 5f;
    public bool usarMundo = true; 

    void Update()
    {
        float horizontal = 0f;
        float vertical = 0f;

        if (Input.GetKey(KeyCode.W)) vertical += 1f;
        if (Input.GetKey(KeyCode.S)) vertical -= 1f;
        if (Input.GetKey(KeyCode.D)) horizontal += 1f;
        if (Input.GetKey(KeyCode.A)) horizontal -= 1f;

        Vector3 movimiento = new Vector3(horizontal, 0f, vertical) * speed * Time.deltaTime;

        if (!usarMundo) {
            transform.Translate(movimiento, Space.Self);
        } else {
            transform.Translate(movimiento, Space.World);
        }
    }
}

