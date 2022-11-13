using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraScript : MonoBehaviour
{   
    //private Vector3 comienzoLerp;
    [SerializeField] private Vector3  finalLerp;
    [SerializeField] private float duracionLerp, posicionActual ;
    //[SerializeField] private Transform posicionEscenarioIzq, posicionEscenarioDer, posicionEscenarioMedio;
    // Start is called before the first frame update
    void Start()
    { 
      //  comienzoLerp = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Lerp(Vector3 comienzo,Vector3 final,  float duracion)
    {
        float timeElapsed = 0f;
        while (timeElapsed < duracion)
        {
            transform.position = Vector3.Lerp(comienzo, final, timeElapsed / duracion);
            timeElapsed += Time.deltaTime;
            yield return null;
        }
        transform.position = final;
        
    }
    public void FlechaDerecha()
    {
        if (posicionActual == -1)
        {
            Debug.Log("estoy en -1 yendo a 0 ");
            finalLerp = new Vector3(0,0,-10);
            StartCoroutine(Lerp(this.transform.position, finalLerp, duracionLerp));
            posicionActual = 0;
        }
        else if (posicionActual == 0)
        {
            Debug.Log("estoy en 0 yendo a 1 ");
            finalLerp = new Vector3 (25,0,-10);
            StartCoroutine(Lerp(this.transform.position, finalLerp, duracionLerp));
            posicionActual = 1;
        }
       
       else if (posicionActual == 1)
        {
            Debug.Log("No se puede ir mas a la derecha che");
        }
    }
    public void FlechaIzquierda()
    {
        if (posicionActual == 1)
        {
            Debug.Log("estoy en 1 yendo a 0 ");
            finalLerp = new Vector3(0, 0, -10);
            StartCoroutine(Lerp(this.transform.position, finalLerp, duracionLerp));
            posicionActual = 0;
        }
        else if (posicionActual == 0)
        {
            Debug.Log("estoy en 0 yendo a -1 ");
            finalLerp = new Vector3(-25, 0, -10);
            StartCoroutine(Lerp(this.transform.position, finalLerp, duracionLerp));
            posicionActual = -1;
        }

        else if (posicionActual == -1)
        {
            Debug.Log("No se puede ir mas a la izquierda che");
        }
    }
}
