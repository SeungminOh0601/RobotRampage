using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float fireRate;
    protected float lastFireTime;

    private void Start()
    {
        lastFireTime = Time.time - 10;
    }

    protected virtual void Update()
    {

    }

    protected void Fire()
    {
        GetComponentInChildren<Animator>().Play("Fire");
    }
}
