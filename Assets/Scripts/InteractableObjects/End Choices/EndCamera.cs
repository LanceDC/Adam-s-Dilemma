using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCamera : MonoBehaviour, IItemAction
{
    public Transform lenseEnd;

    private PlayerEvidence playerEvidence;

    [SerializeField] private Light flashLight;
    [SerializeField] private AudioSource source;

    void Start()
    {
        playerEvidence = PlayerController.instance.GetComponent<PlayerEvidence>();
    }

    public void ItemAction()
    {
        StartCoroutine(LightFlicker());
        source.Play();
        RaycastHit[] hits = Physics.BoxCastAll(lenseEnd.position, lenseEnd.localScale, lenseEnd.forward * 100, lenseEnd.rotation, 100f);

        for(int i = 0; i < hits.Length; i++)
        {
            if (hits[i].collider.CompareTag("Evidence"))
            {
                playerEvidence.IncreasePhotoCount();
                playerEvidence.MarkOffEvidence(hits[i].collider.gameObject);
            }
        }
    }

    private IEnumerator LightFlicker()
    {
        flashLight.enabled = true;

        yield return new WaitForSecondsRealtime(0.15f);

        flashLight.enabled = false;
    }
}
