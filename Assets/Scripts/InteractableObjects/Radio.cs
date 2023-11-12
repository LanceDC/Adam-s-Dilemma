using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour, IInteractable
{
    [SerializeField] private int currentSetting = 0;

    [SerializeField] AudioSource[] sources;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Interact()
    {

        currentSetting++;

        if (currentSetting >= sources.Length)
        {
            for(int i = 0; i < sources.Length; i++)
            {
                sources[i].Stop();
            }
            if (currentSetting > sources.Length)
            {
                currentSetting = 0;
                sources[0].Play();
            }
            return;
        }
        sources[currentSetting -1 ].Stop();
        sources[currentSetting].Play();
    }
}
