using UnityEngine;

public static class GameConfig
{
    private static int complexity;
    
    private static int kills, deaths, assists, points;

    public static int Complexity
    {
        get { return PlayerPrefs.GetInt("Complexity", 3);  }
        set { PlayerPrefs.SetInt("Complexity", value);  }
    }
    
    public static int Kills 
    {
        get 
        {
            return kills;
        }
        set 
        {
            kills = value;
        }
    }

    public static int Deaths 
    {
        get 
        {
            return deaths;
        }
        set 
        {
            deaths = value;
        }
    }

    public static int Assists 
    {
        get 
        {
            return assists;
        }
        set 
        {
            assists = value;
        }
    }

    public static int Points 
    {
        get 
        {
            return points;
        }
        set 
        {
            points = value;
        }
    }
}