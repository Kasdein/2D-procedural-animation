using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Player movement script

    private float MoveSpeed { get; } = 3.8f;
    private float RotSpeed { get; } = 80.0f;

    void Update()
    {
        // Handle keyboard control
        // This loop competes with AdjustBodyTransform() in LegController script to properly postion the body transform

        float ad = Input.GetAxis("Horizontal") * MoveSpeed * Time.deltaTime;
        transform.Translate(ad, 0, 0);
    }
}
