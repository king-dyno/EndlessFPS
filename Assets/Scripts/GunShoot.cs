using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GunShoot : MonoBehaviour
{

    public float bulletDistance = 50f;
    public Camera mainCamera;
    public EnemySpawn enemySpawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ShootGun();
    }


    private void ShootGun() 
    {
        
        if (Input.GetMouseButtonDown(0)) 
        {
            Ray ray = mainCamera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));

            RaycastHit hit;
            
            if (Physics.Raycast(ray, out hit, bulletDistance)) 
            {
                if(hit.transform.gameObject.GetComponent<EnemyMovement>())
                {
                    //destroys enemy if they are shot
                    Destroy(hit.transform.transform.gameObject);
                    enemySpawn.enemyCount--;
                }
            
            }

            
        }
        
    }

}



