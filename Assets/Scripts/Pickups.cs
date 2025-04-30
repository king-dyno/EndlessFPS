using System.Collections;
using System.Collections.Generic;
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
            gameObject.SetActive(false);
        }
    }
    private void Update()
    {
        transform.Rotate(0, .1f, 0);
        Floating();
    }

    private void Floating()
    {
        transform.position += moveDir * speed * Time.deltaTime;
        if (transform.position.y >= 1.25)
        {
            moveDir *= -1;

        }
        if (transform.position.y <= .75)
        {
            moveDir *= -1;

        }
    }


}
