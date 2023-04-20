using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Vector3 startPos;
    public Vector3 endPos;
    public float duration = 3.0f;

    private float timer = 0.0f;
    private bool shouldMove = false;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 40.0f)
        {
            shouldMove = true;
        }

        if (shouldMove)
        {
            float timeSinceStart = timer - 40.0f;
            transform.position = Vector3.Lerp(startPos, endPos, Mathf.PingPong(timeSinceStart, duration) / duration);
        }
    }
}
