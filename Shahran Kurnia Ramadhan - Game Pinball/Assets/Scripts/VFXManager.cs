using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{

    public GameObject vfxSourceBumper;
    public GameObject vfxSourceSwitch;

    public void PlayVFXBumper(Vector3 spawnPosition)
    {
        GameObject.Instantiate(vfxSourceBumper, spawnPosition, Quaternion.identity);
    }

    public void PlayVFXSwitch(Vector3 spawnPosition)
    {
        GameObject.Instantiate(vfxSourceSwitch, spawnPosition, Quaternion.identity);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
