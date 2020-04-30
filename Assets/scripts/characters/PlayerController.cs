using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace NavGame.Core 
{

    public class PlayerController : MonoBehaviour 
    {
        NavMeshAgent agent;
        Camera cam;
        public LayerMask walkableLayer;
        public GameObject prefab;

        DamageableGameObject finalTarget;

        void Awake () 
        {
            agent = GetComponent<NavMeshAgent> ();
            cam = Camera.main;

            GameObject obj = GameObject.FindWithTag ("Finish");
            
            DamageableGameObject dgo = obj.GetComponent<DamageableGameObject> ();
            GameObject Projectile = Instantiate (prefab, transform.position, Quaternion.identity) as GameObject;
            ProjectileController controller = Projectile.GetComponent<ProjectileController> ();
            controller.Init (dgo);
        }

        void Update () {
            if (Input.GetMouseButtonDown (1)) 
            {
                Ray ray = cam.ScreenPointToRay (Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast (ray, out hit, Mathf.Infinity, walkableLayer)) 
                {
                    agent.SetDestination (hit.point);
                }
            }
        }
    }
}