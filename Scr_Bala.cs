using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Bala : MonoBehaviour
{

    public float Velocidad;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0,Velocidad * Time.deltaTime,0 );
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.name == "Enemy"){
            collision.gameObject.GetComponentInParent<Scr_Enemigo>().Vida -=1;
            Destroy(gameObject);
        }
    }
}
