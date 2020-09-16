using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KiteController : MonoBehaviour {
	
    //Establecer variables.
		
        //Establecer estructuras.
		
        //Establecer enumeradores.
		

        //Establecer variables estaticas.
		
            //Publicas.
			
            //Privadas
			
        //Establecer variables.
		
            //Publicas.
            [Header("References")]
            [SerializeField] private PlayerBrain m_playerBrain = null;
			
            //Privadas.
			
			
    //Funciones
		
        //Funciones de MonoBehaviour
		private void OnTriggerEnter2D(Collider2D collider) {

            if (collider.CompareTag("Enemy")) {

                m_playerBrain.Dead();
                }
            }
        //Funciones privadas.
		
        //Funciones publicas.
		
        //Funciones heredadas.
		
        //Funciones ha heredar.
		
        //Corotinas.
		
        }
