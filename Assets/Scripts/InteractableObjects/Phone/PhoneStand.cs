using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneStand : MonoBehaviour
{
    public Transform phoneLocation;
    public bool pickedUpPhone;

    [SerializeField] private Renderer lightRender;
    [SerializeField] private Material red;
    [SerializeField] private Material normal;
    [SerializeField] private Light beepLight;

    [SerializeField] private AudioSource source;

    private void Start()
    {
        StartCoroutine(LightBeep());
    }

    private void Update()
    {
        if (pickedUpPhone)
            source.Stop();
    }

    public void PhoneRing()
    {
        source.Play();
    }

    public void StopLightBeep()
    {
        StopCoroutine(LightBeep());
    }

    private IEnumerator LightBeep()
    {
        while(!pickedUpPhone)
        {
            lightRender.material = red;
            beepLight.enabled = true;

            yield return new WaitForSeconds(1f);

            lightRender.material = normal;
            beepLight.enabled = false;

            yield return new WaitForSeconds(1f);

        }
    }
}
