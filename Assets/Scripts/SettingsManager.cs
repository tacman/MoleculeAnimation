using UnityEngine;

/// <summary>Manages data for persistence between play sessions.</summary>
public class SettingsManager : MonoBehaviour 
{
    /// <summary>The player's name.</summary>
    public string playerName = "";
    /// <summary>The player's score.</summary>
    public int playerScore = 0;
    /// <summary>The player's health value.</summary>
    public float playerHealth = 0f;

    /// <summary>Static record of the key for saving and loading playerName.</summary>
    private static string playerNameKey = "PLAYER_NAME";
    /// <summary>Static record of the key for saving and loading playerScore.</summary>
    private static string playerScoreKey = "PLAYER_SCORE";
    /// <summary>Static record of the key for saving and loading playerHealth.</summary>
    private static string playerHealthKey = "PLAYER_HEALTH";

    /// <summary>Saves playerName, playerScore and 
    /// playerHealth to the PlayerPrefs file.</summary>
    public void Save()
    {
        // Set the values to the PlayerPrefs file using their corresponding keys.
        PlayerPrefs.SetString(playerNameKey, playerName);
        PlayerPrefs.SetInt(playerScoreKey, playerScore);
        PlayerPrefs.SetFloat(playerHealthKey, playerHealth);

        // Manually save the PlayerPrefs file to disk, in case we experience a crash
        PlayerPrefs.Save();
    }

    /// <summary>Saves playerName, playerScore and playerHealth 
    // from the PlayerPrefs file.</summary>
    public void Load()
    {
        // If the PlayerPrefs file currently has a value registered to the playerNameKey, 
        if (PlayerPrefs.HasKey(playerNameKey))
        {
            // load playerName from the PlayerPrefs file.
            playerName = PlayerPrefs.GetString(playerNameKey);
        }

        // If the PlayerPrefs file currently has a value registered to the playerScoreKey, 
        if (PlayerPrefs.HasKey(playerScoreKey))
        {
            // load playerScore from the PlayerPrefs file.
            playerScore = PlayerPrefs.GetInt(playerScoreKey);
        }

        // If the PlayerPrefs file currently has a value registered to the playerHealthKey,
        if (PlayerPrefs.HasKey(playerHealthKey))
        {
            // load playerHealth from the PlayerPrefs file.
            playerHealth = PlayerPrefs.GetFloat(playerHealthKey);
        }
    }

    /// <summary>Deletes all values from the PlayerPrefs file.</summary>
    public void Delete()
    {
        // Delete all values from the PlayerPrefs file.
        PlayerPrefs.DeleteAll();
    }
}