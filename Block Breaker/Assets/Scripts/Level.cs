using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour {
    //parameters
    [SerializeField] int breakableBlocks;       //Serialized for debugging purposes

    //cached reference
    SceneLoader SceneLoader;

    private void Start()
    {
        SceneLoader = FindObjectOfType<SceneLoader>();
    }

    public void CountBlocks()
    {
        breakableBlocks++;
    }

    public void BlockDestroyed()
    {
        breakableBlocks--;
        if (breakableBlocks <= 0)
        {
            SceneLoader.LoadNextScene();
        }
    }
}

