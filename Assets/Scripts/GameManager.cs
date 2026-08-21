using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int playerLives = 4;
    public int currentLevel = 1;
    public int maxLevels = 10;

    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    public void PlayerHit()
    {
        playerLives--;
        Debug.Log("Vite rimaste: " + playerLives);
        if (playerLives <= 0) GameOver();
    }

    public void LevelCompleted()
    {
        currentLevel++;
        if (currentLevel > maxLevels) WinGame();
        else Debug.Log("Livello " + currentLevel);
    }

    void GameOver() { Debug.Log("GAME OVER"); }
    void WinGame() { Debug.Log("HAI VINTO!"); }
}