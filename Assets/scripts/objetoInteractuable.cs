using System.Collections;
using System.Collections.Generic;
using MyEvents;
using NewsSystem;
using UnityEngine;

public class objetoInteractuable : MonoBehaviour
{
    public GameObject FantasmaConTexto;
    [SerializeField] private ContadorObjetos contadorObjetos;
    [SerializeField] private bool agarrado = false;
    [SerializeField] private Sprite popout;
    private SpriteRenderer spriteRender;
    // Start is called before the first frame update
    void Start()
    {
        spriteRender = GetComponent<SpriteRenderer>();
        NewsStore.Publish(new ObjectLoaded
        {
            obj = FantasmaConTexto
        });
    }
    private void OnMouseOver()
    {
        if (!agarrado)
        {
            spriteRender.color = new Color(1, 0.8160377f, 0.8160377f, 1);
            
        }
    }
    private void OnMouseExit()
    {
        if (!agarrado)
        {
            spriteRender.color = new Color(1, 1, 1, 1);
        }
    }
    private void OnMouseDown()
    {
        var dataEvent = new PickObject
        {
            obj = FantasmaConTexto.name
        };
        NewsStore.Publish(dataEvent);
        agarrado = true;
        spriteRender.sprite = popout;
        contadorObjetos.cantAgarrado += 1;
        FantasmaConTexto.SetActive(true);
        gameObject.transform.position = new Vector3(0, 0, 0);
    }
    public void cerrarTexto()
    {
        gameObject.SetActive(false);
        FantasmaConTexto.SetActive(false);
    }
    
}
