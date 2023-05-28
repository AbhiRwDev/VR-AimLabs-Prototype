using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRShoot : MonoBehaviour
{
    public VRShootingScript simpleShoot;
    public OVRInput.Button shootButton;
    public float fireRate = 0.5f;  // Adjust the fire rate as desired
    private OVRGrabbable grabbable;
    private AudioSource audioS;
    private bool isShooting = false;
    private float nextShotTime = 0f;
    public bool isAutomatic = false;
    // Start is called before the first frame update
    void Start()
    {
        grabbable = GetComponent<OVRGrabbable>();
        audioS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isAutomatic)
        {
            if (grabbable.isGrabbed)
            {
                if (OVRInput.GetDown(shootButton, grabbable.grabbedBy.GetController()))
                {
                    isShooting = true;
                }
                else if (OVRInput.GetUp(shootButton, grabbable.grabbedBy.GetController()))
                {
                    isShooting = false;
                }
            }

            if (isShooting && Time.time >= nextShotTime)
            {
                simpleShoot.Shoot();
                audioS.Play();
                nextShotTime = Time.time + 1f / fireRate;  // Calculate the next shot time based on fire rate
            }
        }
        else
        {
            if (grabbable.isGrabbed && OVRInput.GetDown(shootButton, grabbable.grabbedBy.GetController()))
            {
                simpleShoot.Shoot();
                audioS.Play();
            }
        }
       
    }
}
