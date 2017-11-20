using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Hungry : MonoBehaviour
{

    private float amount;
    private List<Material> materials;

    public float Amount
    {
        get { return amount; }
        set { amount = value; } 
    }

    void Start()
    {
        materials = new List<Material>();
        var childrenderes = this.GetComponentsInChildren<SkinnedMeshRenderer>();
        for (var i = 0; i < childrenderes.Length; i++)
        {
            var childMaterials = childrenderes[i].materials;
            for (var j = 0; j < childMaterials.Length; j++)
            {
                materials.Add(childMaterials[j]);
            }
        }
        amount = 0f;
    }

    void FixedUpdate()
    {
        for (int i = 0; i < materials.Count; i++)
        {
            materials[i].SetFloat("_Amount", amount);

        }
        amount -= 0.00005f;
    }
}
