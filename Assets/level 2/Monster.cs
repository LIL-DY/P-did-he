using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MonsterAI : MonoBehaviour
{
    public Transform player; //Referens till spelarens transform
    public float speed = 2f; //Hastigheten p� monstret
    public float stopDistance = 1f; //Avst�nd vid vilket monstret stannar
    public float detectionRadius = 5f; //Radius inom vilket monstret uppt�cker spelaren
    public int hunt = 0;

    private void Update()
    {

        {
            if (player == null)
            {

                Debug.LogWarning("Player is not assigned to the MonsterAI script");
                return;
            }

            // Ber�kna avst�ndet mellan mosntret och spelaren
            float distanceToPlayer = Vector2.Distance(transform.position, player.position);

            //Om avst�endet �r st�rre �n stopDistance, r�r monstret mot spelaren

            if (distanceToPlayer > detectionRadius)
            {

            }

                if (distanceToPlayer <= detectionRadius)


            {
                hunt = 1;
                if (hunt >= 1)
                {
                    if (distanceToPlayer > stopDistance)
                    {

                        Vector2 direction = (player.position - transform.position).normalized;
                        transform.position += (Vector3)direction * speed * Time.deltaTime;
                    }
                }
               
            }
        }   
            
            
                
            

        }

    }




