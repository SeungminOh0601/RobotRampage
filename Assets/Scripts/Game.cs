using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    private static Game singleton;

    [SerializeField] RobotSpawn[] spawns;

    public int enemiesLeft;

    private void Start()
    {
        singleton = this;
        SpawnRobots();
    }

    private void SpawnRobots()
    {
        foreach (RobotSpawn spawn in spawns)
        {
            spawn.SpawnRobot();
            enemiesLeft++;
        }
    }
}
