using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine.Animations;

public class TimedMeshRenderer : MonoBehaviour
{
    // Reference to the Mesh Renderer component
    public MeshRenderer meshRenderer;

    // Update is called once per frame
    void Update()
    {
        

        if (currentTime > 43.73f)
        {
            meshRenderer.enabled = true;
        }

        else
        {
            meshRenderer.enabled = false;
        }

    }
}
