using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch : MonoBehaviour
{
    public Light torchLight; // Referens till ljusk�llan f�r facklan
    public ParticleSystem flameParticles; // Partikelsystem f�r l�gan
    public AudioSource torchSound; // Ljud f�r att t�nda/sl�cka facklan
    public bool isLit = true; // H�ller reda p� om facklan �r t�nd eller inte

    private void Start()
    {
        UpdateTorchState();
    }

    public void ToggleTorch()
    {
        isLit = !isLit; // V�xla status
        UpdateTorchState();

        // Spela ljud om det finns ett ljud tillg�ngligt
        if (torchSound != null)
        {
            torchSound.Play();
        }
    }

    private void UpdateTorchState()
    {
        // Uppdatera ljuset och partiklar baserat p� om facklan �r t�nd
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
