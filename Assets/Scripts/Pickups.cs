using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;

public class Pickups : MonoBehaviour
{

    public bool ammo = false;
    public bool health = false;
    public bool extraDmg = false;
    public bool other = false;
    private float speed = .3f;
    private Vector3 moveDir;


    
    private void Start()
    {
        moveDir = Vector3.up;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<FPSController>())
        {
            if (ammo)
            {
                other.gameObject.GetComponent<FPSController>().ammoCount += 10;
            }
            if (health)
            {
                other.gameObject.GetComponent<FPSController>().health += 25;
            }
            gameObject.SetActive(false);
        }
    }
    private void Update()
    {
        transform.Rotate(0, .1f, 0);
        Floating();
    }
    /// <summary>
    /// having the pickup float up and down
    /// </summary>
    private void Floating()
    {
        transform.position += moveDir * speed * Time.deltaTime;
        if (transform.position.y >= 1.25 || transform.position.y <= .75)
            moveDir *= -1;

    }

}
