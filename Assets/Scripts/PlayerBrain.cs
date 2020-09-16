using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBrain : MonoBehaviour {
	
    //Establecer variables.
		
        //Establecer estructuras.
		
        //Establecer enumeradores.
		

        //Establecer variables estaticas.
		
            //Publicas.
			
            //Privadas
			
        //Establecer variables.
		
            //Publicas.
            [Header("References")]
            [SerializeField] private Transform m_selfTransform = null;
            [SerializeField] private Rigidbody2D m_kiteRigidbody = null;
            [SerializeField] private LineRenderer m_lineRenderer = null;
            [Space]
            [SerializeField] private TMPro.TextMeshProUGUI m_deadText = null;

            [Header("Values")]
            [SerializeField] private float m_kiteAngle = 135f;
            [SerializeField] private float m_defDistance = 5;
            [Space]
            [SerializeField] private float m_minDistance = 2;
            [SerializeField] private float m_maxDistance = 6;
            [Space]
            [SerializeField] private float m_kiteSpeed = 1;
            [SerializeField] private float m_distanceSmoothness = 0.1f;
			
            //Privadas.
            private float m_smoothedKiteDistance;
            private float m_kiteActualDistance;
			private float m_kiteVelocity;

            private float m_sinEffect;

            private bool m_isDead;
			
    //Funciones
		
        //Funciones de MonoBehaviour
        private void Start() {
			
            m_kiteActualDistance = m_defDistance;
            m_smoothedKiteDistance = m_kiteActualDistance;
            }
        private void Update() {
            
            m_lineRenderer.SetPosition(0, m_selfTransform.position + new Vector3(0, 0.5f, 0));
            m_lineRenderer.SetPosition(1, m_kiteRigidbody.position);

            m_kiteActualDistance = Mathf.Clamp((m_kiteActualDistance + m_kiteSpeed * Input.GetAxis("Vertical") * Time.deltaTime), m_minDistance, m_maxDistance);
                
            m_smoothedKiteDistance = Mathf.SmoothDamp(m_smoothedKiteDistance, m_kiteActualDistance, ref m_kiteVelocity, m_distanceSmoothness, Mathf.Infinity);

            m_sinEffect += (90 * Time.deltaTime);

            m_kiteRigidbody.position = (transform.position + (Vector3.up/2) + (new Vector3(0, Mathf.Sin(m_sinEffect * Mathf.Deg2Rad) * 0.25f, 0))) + new Vector3(Mathf.Cos(m_kiteAngle * Mathf.Deg2Rad), Mathf.Sin(m_kiteAngle * Mathf.Deg2Rad)) * m_smoothedKiteDistance;
            
            m_kiteRigidbody.transform.localEulerAngles += new Vector3(0, 0, 180 * Time.deltaTime);

            if (m_isDead) {

                if (Input.GetKeyDown(KeyCode.R)) {

                    Time.timeScale = 1;
                    SceneManager.LoadScene(0);
                    }
                }
            }

        //Funciones privadas.
        public void Dead() {

            m_isDead = true;
            m_deadText.text = "¡Has obtenido " + ScoreController.score + " puntos! \n\nPresiona R para reintentar.";
            
            Time.timeScale = 0;
            }   

        //Funciones publicas.
		
        //Funciones heredadas.
		
        //Funciones ha heredar.
		
        //Corotinas.
		
        }
