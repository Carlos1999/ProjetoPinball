using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



public class AtuadorPalheta : MonoBehaviour
{
public enum PalhetaLado
{
	ESQUERDA,
	DIREITA
};
	public GameObject palheta;
	public PalhetaLado lado;
	public KeyCode tecla;
    int subiuEsquerda = 0;
    int subiuDireita = 0;
    float velocidadeRotacao = 5.0f;
    int vezesRotacao = 5;

    void palhetaEsquerdaAtivar(){
        if (subiuEsquerda < vezesRotacao)
        {
            palheta.transform.Rotate(0.0f, velocidadeRotacao * -1, 0.0f, Space.Self);
            subiuEsquerda++;
            
        }
		

    }

    void palhetaEsquerdaDesativar()
    {
        if (subiuEsquerda > 0)
        {
            palheta.transform.Rotate(0.0f, velocidadeRotacao , 0.0f, Space.Self);
            subiuEsquerda--;
        }

    }

    void palhetaDireitaAtivar(){

        if (subiuDireita < vezesRotacao)
        {
            palheta.transform.Rotate(0.0f, velocidadeRotacao, 0.0f, Space.Self);
            subiuDireita++;
        }
    }

    void palhetaDireitaDesativar()
    {
        if (subiuDireita > 0)
        {
            palheta.transform.Rotate(0.0f, velocidadeRotacao *-1, 0.0f, Space.Self);
            subiuDireita--;
        }

    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(tecla)&&lado == PalhetaLado.ESQUERDA ){
            palhetaEsquerdaAtivar();
        }else
        {
            palhetaEsquerdaDesativar();
        }

        if(Input.GetKey(tecla)&&lado == PalhetaLado.DIREITA ){
        	palhetaDireitaAtivar();
        }else
        {
            palhetaDireitaDesativar();
        }
    }
}
