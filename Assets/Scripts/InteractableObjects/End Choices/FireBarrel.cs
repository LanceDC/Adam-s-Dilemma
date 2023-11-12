using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBarrel : MonoBehaviour
{
    public new Light light;
    public MeshRenderer flameRenderer;

    private PlayerEvidence playerEvidence;

    [SerializeField] private SphereCollider sphere;
    
    void Start()
    {
        playerEvidence = PlayerController.instance.GetComponent<PlayerEvidence>();
    }

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.CompareTag("Evidence"))
        {
            BurnEvidence(collider.gameObject);
        }
    }

    private void BurnEvidence(GameObject obj)
    {
        playerEvidence.IncreaseBurnCount();
        playerEvidence.MarkOffEvidence(obj);
        obj.SetActive(false);
    }

    public void ActivateFireBarrel()
    {
        light.enabled = true;
        flameRenderer.enabled = true;
        sphere.enabled = true;
    }
}
