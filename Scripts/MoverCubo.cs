using UnityEngine;

// Clase que permite mover un cubo con las flechas del teclado, en espacio local o global
public class MoverCubo : MonoBehaviour
{
    public float speed = 5f;
    public bool usarMundo = true;

    void Update()
    {
        float horizontal = 0f;
        float vertical = 0f;

        if (Input.GetKey(KeyCode.LeftArrow)) horizontal -= 1f;
        if (Input.GetKey(KeyCode.RightArrow)) horizontal += 1f;
        if (Input.GetKey(KeyCode.UpArrow)) vertical += 1f;
        if (Input.GetKey(KeyCode.DownArrow)) vertical -= 1f;

        Vector3 movimiento = new Vector3(horizontal, 0f, vertical) * speed * Time.deltaTime;

        if (!usarMundo) {
            transform.Translate(movimiento, Space.Self);
        } else {
            transform.Translate(movimiento, Space.World);
        }
    }
}
