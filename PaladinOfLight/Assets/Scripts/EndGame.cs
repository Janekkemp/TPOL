using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;

public class EndGame : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject UiObject;
    public GameObject cutscenecamera;
    public PlayableDirector director;
    void Start()
    {
       
        cutscenecamera.SetActive(false);
        UiObject.SetActive(false);

    }

    private void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            cutscenecamera.SetActive(true);
            director.Play();
            StartCoroutine("WaitForSec");
            

        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(3);
        UiObject.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1 );
    }

    // Update is called once per frame
    void Update()
    {

    }
}
