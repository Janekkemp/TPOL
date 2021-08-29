using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaDamage : MonoBehaviour
{
    // Start is called before the first frame update

    public float damageAmount = 0.1f;

    public float continuousTimeBetweenHits = 10;
    

    private float savedTime = 5;
    
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    

    void OnCollisionStay(Collision collision) // this is used for damage over time things
    {


              
            if (collision.gameObject.tag == "Player" && collision.gameObject.GetComponent<Health>() != null)
            {   // is only triggered if whatever it hits is the player
                if(collision.gameObject.GetComponent<Health>().healthPoints > 0)
            {
               
                    collision.gameObject.GetComponent<Health>().ApplyDamage(damageAmount);

                
            }
               
            }
        }
            
        }
    

