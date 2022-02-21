using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_LimiteJugador : MonoBehaviour
{

    
    public Vector2 Hrange = Vector2.zero;
    public Vector2 Vrange = Vector2.zero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


       transform.position = new Vector3 (

           //Mathf.Clamp nos permite que el primer parametro se mueva entre los dos siguientes.
           Mathf.Clamp (transform.position.x, Vrange.x,Vrange.y),
           Mathf.Clamp (transform.position.y, Hrange.x,Hrange.y),
           transform.position.z


       ); 
    }
}
