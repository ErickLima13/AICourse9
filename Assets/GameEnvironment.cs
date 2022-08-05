using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public sealed class GameEnvironment
{
    private static GameEnvironment instance;
    private List<GameObject> checkpoints = new();
    public List<GameObject> Checkpoints { get { return checkpoints; } }

    public static GameEnvironment Singleton
    {
        get
        {
            if(instance == null)
            {
                instance = new();
                instance.Checkpoints.AddRange(GameObject.FindGameObjectsWithTag("Checkpoint"));
                instance.checkpoints = instance.checkpoints.OrderBy(waypoint => waypoint.name).ToList();
            }
            return instance;
        }
    }
}
