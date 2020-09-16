using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour {
	
    //Establecer variables.
		
        //Establecer estructuras.
		
        //Establecer enumeradores.
		

        //Establecer variables estaticas.
		
            //Publicas.
            public static bool bypass = false;
			
            //Privadas
			
        //Establecer variables.
		
            //Publicas.
            [Header("References")]
            [SerializeField] private GameObject m_enemy = null;
            [SerializeField] private float m_generationTime = 2;
            [SerializeField] private GameObject m_menu = null;
			
            //Privadas.
            private float m_actualTime;
            private bool m_hasStarted = false;
			
			
    //Funciones
		
        //Funciones de MonoBehaviour
        private void Start() {
			
            }
        private void Update() {
            
            if (!m_hasStarted) {
                
                if (Input.GetKeyDown(KeyCode.Space)) bypass = true;

                if (bypass) {

                    m_hasStarted = true;
                    m_menu.SetActive(false);
                    }
                }

            else {

                m_actualTime -= Time.deltaTime;

                if (m_actualTime <= 0) {

                    m_actualTime = m_generationTime + Random.Range(-0.5f, 0.5f);
                    Instantiate(m_enemy, new Vector3(10, Random.Range(0, 4)), Quaternion.identity);
                    }
                }
            }
		
        //Funciones privadas.
		
        //Funciones publicas.
		
        //Funciones heredadas.
		
        //Funciones ha heredar.
		
        //Corotinas.
		
        }
