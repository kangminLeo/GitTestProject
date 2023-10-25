using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteThis : MonoBehaviour
{
    // Start is called before the first frame update
    public Material targetMaterial;
    public Color newColor;

    private void Start()
    {
        targetMaterial.color = Color.gray;
    }
}
