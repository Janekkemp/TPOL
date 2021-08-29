using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{

    Animator mAnimator;
    float walk = 2.5f;
    float run = 5f;
    // Start is called before the first frame update
    void Start()
    {
        mAnimator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        mAnimator.SetFloat("PosX", 0);
        mAnimator.SetFloat("PosY", 0);
        mAnimator.SetBool("Jump", false);

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

       

        if(Input.GetKey(KeyCode.UpArrow))
        {
            mAnimator.SetFloat("PosY", 0.5f);
            transform.Translate(Vector3.forward * walk * Time.deltaTime);
        }
        
        if(Input.GetKey(KeyCode.RightArrow))
        {
            mAnimator.SetFloat("PosX", 1);
            transform.Rotate(new Vector3(0f, 0f, 1f) * Time.deltaTime);


        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            mAnimator.SetFloat("PosX", -1);

        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            mAnimator.SetFloat("PosY", 1);
            transform.Translate(Vector3.forward * run * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.Space))
        {
            mAnimator.SetBool("Jump", true);
        }
    }
}
