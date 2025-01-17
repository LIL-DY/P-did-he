using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch : MonoBehaviour
{
    public Light torchLight; // Referens till ljuskällan för facklan
    public ParticleSystem flameParticles; // Partikelsystem för lågan
    public AudioSource torchSound; // Ljud för att tända/släcka facklan
    public bool isLit = true; // Håller reda på om facklan är tänd eller inte

    private void Start()
    {
        UpdateTorchState();
    }

    public void ToggleTorch()
    {
        isLit = !isLit; // Växla status
        UpdateTorchState();

        // Spela ljud om det finns ett ljud tillgängligt
        if (torchSound != null)
        {
            torchSound.Play();
        }
    }

    private void UpdateTorchState()
    {
        // Uppdatera ljuset och partiklar baserat på om facklan är tänd
        if (torchLight != null)
        {
            torchLight.enabled = isLit;
        }

        if (flameParticles != null)
        {
            if (isLit)
            {
                flameParticles.Play();
            }
            else
            {
                flameParticles.Stop();
            }
        }
    }
}
