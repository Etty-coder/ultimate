using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public int currentLevel = 1;
    public int finalLevel = 10;

    public void CompleteLevel()
    {
        Debug.Log("Livello " + currentLevel + " completato!");
        if (currentLevel >= finalLevel)
        {
            Debug.Log("Hai completato tutto il gioco!");
            return;
        }
        currentLevel++;
        SceneManager.LoadScene("Level" + currentLevel);
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}