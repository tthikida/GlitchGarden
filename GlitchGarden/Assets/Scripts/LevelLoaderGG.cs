using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


























public class LevelLoaderGG : MonoBehaviour
{

    [SerializeField] AudioClip quitGameButtonSound;
    [SerializeField] AudioClip startButtonSound;
    [SerializeField] [Range(0,1)] float startButtonVolume = 1.0f;
    [SerializeField] [Range(0, 1)] float quitButtonVolume = 1.0f;
    [SerializeField] int scenePosition;
    [SerializeField] int timeToWait = 3;

    void Start ()
    {
        scenePosition = SceneManager.GetActiveScene().buildIndex;
        if (scenePosition == 0)
        {
            StartCoroutine(LoadNextScene());
        }
    }

    IEnumerator LoadNextScene()
    {
        yield return new WaitForSeconds(timeToWait);
        SceneManager.LoadScene(scenePosition + 1);
    }

    public void StartButtonPushed()
    {
        Debug.Log("Great jooooorb!");
        AudioSource.PlayClipAtPoint(startButtonSound, Camera.main.transform.position, startButtonVolume);
    }

    public void QuitButtonPressed()
    {
        Debug.Log("Where you goin' boi!? Mama raised no quitter!");
        AudioSource.PlayClipAtPoint(quitGameButtonSound, Camera.main.transform.position, quitButtonVolume);
    }

}