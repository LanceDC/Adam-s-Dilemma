using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revel : MonoBehaviour
{
    public Transform effector;
    public Color requiredColor;

    private Renderer rend;

    [SerializeField] private Light light;

    private void Start()
    {
        rend = GetComponent<Renderer>();
    }

    private void Update()
    {
        if (light.color == requiredColor)
        {
            rend.sharedMaterial.SetVector("_EffectPosition", effector.position);
        }

        if (!effector.gameObject.activeSelf)
        {
            rend.sharedMaterial.SetVector("_Effector", new Vector3(100f, 100f, 100f));
        }
        else
        {
            rend.sharedMaterial.SetVector("_Effector", new Vector3(1, 0, 1));
        }
    }
}
