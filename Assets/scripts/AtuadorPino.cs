using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtuadorPino : MonoBehaviour
{
    public GameObject pino;
	public KeyCode tecla;

    int puxouPino = 0;

    int limitePino = 4;

    float velocidadePuxar = 0.2f;
    // Start is called before the first frame update

    void pinoPuxar(){
        if (puxouPino < limitePino)
        {
            pino.transform.Translate(0,0,velocidadePuxar * -1,Space.Self);
            puxouPino++;
            
        }
		

    }

    void pinoSoltar(){
        if (puxouPino > 0)
        {
            pino.transform.Translate(0,0,velocidadePuxar ,Space.Self);
            puxouPino--;
            
        }
		

    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        if(Input.GetKey(tecla) ){
            pinoPuxar();
        }else if(!(Input.GetKey(tecla)) && puxouPino > 0 ){
            pinoSoltar();
        }
    }
}
