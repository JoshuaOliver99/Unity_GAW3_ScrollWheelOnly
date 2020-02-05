using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Goal Goal;

    public Animator Transition;

    public float TransitionTime = 1f;
    void Update()
    {
        
        if (Goal.LevelEnded)
        {
            LoadNextLevel();
        }
    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));    
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        Transition.SetTrigger("start");

        yield return new WaitForSeconds(TransitionTime);

        SceneManager.LoadScene(levelIndex);
    }
}
