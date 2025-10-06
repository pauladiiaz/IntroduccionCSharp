using UnityEngine;

// Clase que permite girar y avanzar continuamente un objeto en la dirección que mira
public class GirarYAvanzar : MonoBehaviour
{
    public float speed = 5f;
    public float turnSpeed = 100f;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        transform.Rotate(0f, h * turnSpeed * Time.deltaTime, 0f);

        transform.Translate(transform.forward * speed * Time.deltaTime, Space.World);

        Debug.DrawRay(transform.position, transform.forward * 2f, Color.red);
    }
}

