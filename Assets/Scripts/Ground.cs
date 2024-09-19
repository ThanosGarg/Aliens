using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public float y;

    public float speed;

    public MeshRenderer meshRenderer;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        y += 1 * Time.deltaTime * speed;

        meshRenderer.material.mainTextureOffset = new Vector2(0, -y);
    }
}