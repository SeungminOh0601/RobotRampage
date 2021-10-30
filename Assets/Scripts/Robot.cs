using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Robot : MonoBehaviour
{
    [SerializeField] private string robotType;

    public int health;
    public int range;
    public float fireRate;

    public Transform missileFireSpot;
    NavMeshAgent agent;

    private Transform player;
    private float timeLastFired;

    private bool isDead;

    void Start()
    {
        isDead = false;
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (isDead) return;

        transform.LookAt(player);

        agent.SetDestination(player.position);

        if (Vector3.Distance(transform.position, player.position) < range && Time.time - timeLastFired > fireRate)
        {
            timeLastFired = Time.time;
            Fire();
        }
    }

    void Fire()
    {
        Debug.Log("FIRE");
    }
}
