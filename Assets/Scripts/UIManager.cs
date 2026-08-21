using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text livesText;
    public Text levelText;

    void Update()
    {
        if (GameManager.Instance == null) return;
        if (livesText != null) livesText.text = "Vite: " + GameManager.Instance.playerLives;
        if (levelText != null) levelText.text = "Livello: " + GameManager.Instance.currentLevel;
    }
}