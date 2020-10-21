using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager mainAudio;

    public string gunshot;

    FMOD.Studio.EventInstance gunshotEvent;

    void Awake()
    {
        if (mainAudio != null)
        {
            DestroyImmediate(this);
            return;
        }

        mainAudio = this;
        DontDestroyOnLoad(gameObject);
    }

        // Start is called before the first frame update
        void Start()
    {
        gunshotEvent = FMODUnity.RuntimeManager.CreateInstance(gunshot);

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            gunshotEvent.start();
        }
    }
}
