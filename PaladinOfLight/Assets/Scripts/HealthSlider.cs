using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSlider : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject player;
    public Slider slider;
    private Health HealthAmount;
    void Start()
    {
        HealthAmount = player.GetComponent<Health>();
    }

    // Update is called once per frame
    public void setHealth(float health)
    {
        slider.value = HealthAmount.healthPoints;
    }
}
