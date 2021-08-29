using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUP : MonoBehaviour
{

    public Animator m_animator;
    public GameObject coin;
    public GameObject gate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            StartCoroutine("WaitForSec");
            


        }
    }

    IEnumerator WaitForSec()
    {
        
        m_animator.SetTrigger("PickUP");
        yield return new WaitForSeconds(2);
        Destroy(coin);
        Destroy(gate);
        
    }

}
