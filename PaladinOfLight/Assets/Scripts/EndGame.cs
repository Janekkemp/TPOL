using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject UIObject;
    void Start()
    {
        UIObject.SetActive(false);

    }

    private void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            UIObject.SetActive(true);
            StartCoroutine("WaitForSec");

        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1 );
    }

    // Update is called once per frame
    void Update()
    {

    }
}
