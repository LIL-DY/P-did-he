using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;

public class facklaInter : MonoBehaviour
{
    public float interactionRange = 2f;
    public LayerMask torchLayer;
    public GameObject Torch;

    bool isInArea;

    private void Start()
    {
        Torch = GameObject.FindGameObjectWithTag("Torch");
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.E) && isInArea == true)
        {

            InteractWithTorch();
        }
    }

    private void InteractWithTorch()
    {
        Collider2D[] hits = Physics2D.OverlapCircleAll(transform.position, interactionRange, torchLayer);

        foreach (var hit in hits)
        {
            Torch torch = hit.GetComponent<Torch>();
            if (torch != null)
            {
                torch.ToggleTorch(); // Växla facklans status
                break; // Endast en fackla interageras med per tryck
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        isInArea = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        isInArea = false;
    }
}
    

        
        

  

   


