using UnityEngine;

// Clase que gestiona el desplazamiento de varios objetos al pulsar la barra espaciadora mediante un marcador
public class Desplazar : MonoBehaviour
{
    // Referencias a los objetos de la escena (que ya tienen su desplazamiento configurado)
    public ObjetoConDesplazamiento cubo;
    public ObjetoConDesplazamiento cilindro;
    public ObjetoConDesplazamiento esfera;

    void Start()
    {
        // Encontramos los objetos con tags
        cubo = GameObject.FindGameObjectWithTag("Cubo").GetComponent<ObjetoConDesplazamiento>();
        cilindro = GameObject.FindGameObjectWithTag("Cilindro").GetComponent<ObjetoConDesplazamiento>();
        esfera = GameObject.FindGameObjectWithTag("Esfera").GetComponent<ObjetoConDesplazamiento>();
    }
    void Update()
    {
        // Detectamos si se pulsa la barra espaciadora usando Input.GetAxis
        float jump = Input.GetAxis("Jump");

        if (jump > 0.5f)
        {
            // Recolocamos cada objeto usando su propia posición inicial y su desplazamiento
            if (cubo != null) cubo.transform.position = cubo.posicionInicial + cubo.desplazamiento;
            if (cilindro != null) cilindro.transform.position = cilindro.posicionInicial + cilindro.desplazamiento;
            if (esfera != null) esfera.transform.position = esfera.posicionInicial + esfera.desplazamiento;
            Debug.Log("Barra espaciadora pulsada");
        }
    }
}
