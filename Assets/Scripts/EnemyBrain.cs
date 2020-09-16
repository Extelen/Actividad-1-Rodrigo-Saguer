using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBrain : MonoBehaviour {
	
    //Establecer variables.
		
        //Establecer estructuras.
		
        //Establecer enumeradores.
		

        //Establecer variables estaticas.
		
            //Publicas.
			
            //Privadas
			
        //Establecer variables.
		
            //Publicas.
			
            //Privadas.
			private float m_speed;
			
    //Funciones
		
        //Funciones de MonoBehaviour
        private void Start() {
			
            m_speed = Random.Range(2, 5);
            }
        private void Update() {
            
            transform.position += new Vector3(-m_speed, 0, 0) * Time.deltaTime;
            if (transform.position.x < -10) {
                
                ScoreController.score ++;
                Destroy(gameObject);
                }
            }
		
        //Funciones privadas.
		
        //Funciones publicas.
		
        //Funciones heredadas.
		
        //Funciones ha heredar.
		
        //Corotinas.
		
        }
