using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
	public Rigidbody rg;
	public float healthPoints = 1f;
	public Animator m_animator;
	public CapsuleCollider m_collider;
	public HealthSlider m_slider;            

	public bool IsDead
    {
        get
        {
			return healthPoints <= 0;
        }
    }



	
	void Start()
	{
	
		m_collider = GetComponent<CapsuleCollider>();

	}

	// Update is called once per frame
	void Update()
	{
		
		m_slider.setHealth(healthPoints);
		
	}

	

	IEnumerator WaitForDeath()
    {
		yield return new WaitForSeconds(1);
		m_collider.direction = 2;
		yield return new WaitForSeconds(2);
		Destroy(this.gameObject);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
	public void ApplyDamage(float amount)
	{
		healthPoints = healthPoints - amount;

		
		if (IsDead)
		{   
			FindObjectOfType<AudioManager>().Play("Die");
			m_animator.SetTrigger("Death");
			
			StartCoroutine(WaitForDeath());


		}
	}



	


}
