using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Enemigo : MonoBehaviour
{
    public float VelocidadRot;
    public float VelocidadBajada;
    public GameObject Enemy;

    public int Vida;
    public int RandomScale;

    // Start is called before the first frame update
    void Start()
    {

        Destroy(gameObject, 11f);

        if(Random.Range(0,2) == 0){
            RandomScale = 1;
        }
        else{
            RandomScale = -1;
        }
        transform.localScale = new Vector3(RandomScale,1,1);

    }

    // Update is called once per frame
    void Update()
    {
        Enemy.transform.Rotate(0,0,VelocidadRot * Time.deltaTime);
        transform.position += new Vector3(0,VelocidadBajada * Time.deltaTime, 0 );

        if(Vida <= 0){
            GameObject.Find("Player").GetComponent<Scr_Player>().Puntos += 1;
            Destroy(gameObject);
        }

    }
}
