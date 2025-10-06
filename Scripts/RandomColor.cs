using UnityEngine;
using System.Collections;

// Clase que cambia aleatoriamente el color de un objeto cada cierto número de frames
public class RandomColor : MonoBehaviour
{
    public int frameInterval = 120; // Cada cuántos frames se actualiza
    private Color objectColor;
    private Renderer objectRenderer;

    void Start()
    {
        // Inicializar el vector de color con valores aleatorios entre 0.0 y 1.0
        objectColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
        objectRenderer = GetComponent<Renderer>();
        if (objectRenderer != null)
        {
            objectRenderer.material.color = objectColor;
        }
    }

    void Update()
    {
        // Solo actualizar el color cada 'frameInterval' frames
        if (Time.frameCount % frameInterval == 0)
        {
            // Seleccionar una posición aleatoria
            int randomPosition = Random.Range(0, 3);

            switch (randomPosition)
            {
                case 0:
                    objectColor.r = Random.Range(0.0f, 1.0f);
                    break;
                case 1:
                    objectColor.g = Random.Range(0.0f, 1.0f);
                    break;
                case 2:
                    objectColor.b = Random.Range(0.0f, 1.0f);
                    break;
            }
            
            // Aplicar el nuevo color al objeto
            if (objectRenderer != null)
            {
                objectRenderer.material.color = objectColor;
            }
        }
    }
}
