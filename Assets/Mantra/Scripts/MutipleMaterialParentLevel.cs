using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MutipleMaterialParentLevel : MonoBehaviour
{

    public Material lastMat;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (lastMat != null)
            {

                // First get all the Renderer component of the child objects
                // Second get all the materials in the current renderer component
                // Last set the materials of current renderer component 
                Renderer[] renderers = GetComponentsInChildren<Renderer>();

                for (int i = 0; i < renderers.Length; ++i)
                {
                    Material[] originalMtas = renderers[i].materials;
                    for (int j = 0; j < originalMtas.Length; ++j)
                    {
                        originalMtas[j] = lastMat;
                    }
                    renderers[i].materials = originalMtas;
                }
                
            }
        }
    }
}
