using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GunShoot : MonoBehaviour
{

    public float bulletDistance = 50f;
    public Camera mainCamera;
    public FPSController fpsCtrl;
    public EnemySpawn enemySpawn;
    public GameObject AmmoPickup;
    public GameObject HealthPickup;
    public GameObject muzzleFlash;

    // Update is called once per frame
    void Update()
    {
        ShootGun();
    }
    private void Start()
    {
        muzzleFlash = GameObject.Find("muzzleflash");
        if (muzzleFlash != null)
            muzzleFlash.SetActive(false);
    }

    private void ShootGun() 
    {
        
        if (Input.GetMouseButtonDown(0) && gameObject.GetComponent<FPSController>().ammoCount > 0) 
        {
            
           

            Ray ray = mainCamera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));

            RaycastHit hit;
            fpsCtrl.ammoCount--;
           
            if (Physics.Raycast(ray, out hit, bulletDistance)) 
            {
                if(hit.transform.gameObject.GetComponent<EnemyMovement>())
                {
                    //destroys enemy if they are shot
                    Destroy(hit.transform.transform.gameObject);
                    enemySpawn.enemyCount--;

                    //chance to drop a pickup
                    int dropChance = Random.Range(1, 4);
                    //if it hits then spawn a random pickup
                    if (dropChance == 3)
                    {
                        int dropChoice = Random.Range(1, 3);

                        if (dropChoice == 1)
                        {
                            Instantiate(HealthPickup, new(hit.transform.position.x, 1, hit.transform.position.z), Quaternion.identity);
                        }
                        if (dropChoice == 2)
                        {
                            Instantiate(AmmoPickup, new(hit.transform.position.x, 1, hit.transform.position.z), Quaternion.identity);
                        }
                    }
                }

                


            }

            
        }
        
    }
    void MuzzleFlash() 
    {
        muzzleFlash.SetActive(true);
    }

}



