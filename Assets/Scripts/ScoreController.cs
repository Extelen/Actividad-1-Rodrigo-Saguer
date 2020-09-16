using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour {
	
    //Establecer variables.
		
        //Establecer estructuras.
		
        //Establecer enumeradores.
		

        //Establecer variables estaticas.
		
            //Publicas.
            public static int maxScore = 20;
            public static int score;
			
            //Privadas
			
        //Establecer variables.
		
            //Publicas.
            [Header("References")]
            [SerializeField] private TextMeshProUGUI m_text = null;

            //Privadas.
			
			
    //Funciones
		
        //Funciones de MonoBehaviour
        private void Start() {
			
            score = 0;
            }
        private void Update() {
            
            m_text.text = "Highscore = " + maxScore + "\nScore = " + score;
            if (score > maxScore) maxScore = score;
            }
		
        //Funciones privadas.
		
        //Funciones publicas.
		
        //Funciones heredadas.
		
        //Funciones ha heredar.
		
        //Corotinas.
		
        }
