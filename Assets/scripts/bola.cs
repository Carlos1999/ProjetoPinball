using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bola : MonoBehaviour
{
	public GameObject pino;
    public GameObject palhetaEsquerda;
    public GameObject palhetaDireita;
    float velocidadeInicio =0;
    public float velocidadePalhetas;
    Rigidbody r;
    bool bolaNoInicio = false;
    // Start is called before the first frame update

    void OnTriggerEnter(Collider collider)
    {
        Vector3 forca;
        if (collider.gameObject.tag == "pino")
        {
            bolaNoInicio = true;
        }
            if (collider.gameObject.tag == "palhetaEsquerda")
        {
            if (Input.GetKey(KeyCode.A))
            {
                forca = palhetaEsquerda.transform.forward;
                r.AddForce(forca * velocidadePalhetas);
            }
            
        }else if (collider.gameObject.tag == "palhetaDireita")
        {
            if (Input.GetKey(KeyCode.D))
            {
                forca = palhetaDireita.transform.forward;
                r.AddForce(forca * velocidadePalhetas);
            }
        }

    }

    void disparo(){
		Vector3 forca;
		forca = pino.transform.forward;
		r.AddForce(forca*velocidadeInicio);    	
    
   
    }

    void Start()
    {
    	r = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 forca;
        if (Input.GetKey(KeyCode.Space) && velocidadeInicio < 1000)
        {
            velocidadeInicio += 50f;
            print(velocidadeInicio);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            if (bolaNoInicio)
            {
                bolaNoInicio = false;
                forca = pino.transform.forward;
                r.AddForce(forca * velocidadeInicio);
                velocidadeInicio = 0;
            }
        }
    }
}
