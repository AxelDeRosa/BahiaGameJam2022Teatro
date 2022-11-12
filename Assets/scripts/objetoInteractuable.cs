using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objetoInteractuable : MonoBehaviour
{
    public bool agarrado = false;
    public Sprite popout;
    private SpriteRenderer spriteRender;
    // Start is called before the first frame update
    void Start()
    {
        spriteRender = GetComponent<SpriteRenderer>();
    }
    private void OnMouseOver()
    {
        if (!agarrado)
        {
            spriteRender.color = new Color(1, 0.8160377f, 0.8160377f, 1);

        }
        //Debug.Log("Mouse over");
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
        agarrado = true;
        spriteRender.sprite = popout;
    }
    private void OnMouseEnter()
    {
        
    }
    // Update is called once per frame
    //comentario para ver si anda el github xd xd xd xd 
    void Update()
    {
        
    }
}
