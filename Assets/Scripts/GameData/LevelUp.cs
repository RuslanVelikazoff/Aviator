using UnityEngine;

public class LevelUp : MonoBehaviour
{
    public int[] expNeeded;
    
    public int maxLevel;

    private void Awake()
    {
        if (!PlayerPrefs.HasKey(Constants.DATA.LEVEL))
        {  
            PlayerPrefs.SetInt(Constants.DATA.LEVEL, 1);
        }
        
        SetExpNeeded();
        UpLevel();
    }

    private void SetExpNeeded()
    {
        for (int i = 0; i < expNeeded.Length; i++)
        {
            expNeeded[i] = (i + 1) * 1000;
        }
    }

    private void UpLevel()
    {
        if (PlayerPrefs.GetInt(Constants.DATA.LEVEL) < maxLevel)
        {
            if (PlayerPrefs.GetInt(Constants.DATA.EXP)
                >= expNeeded[PlayerPrefs.GetInt(Constants.DATA.LEVEL) - 1])
            {
                PlayerPrefs.SetInt(Constants.DATA.EXP, 
                    PlayerPrefs.GetInt(Constants.DATA.EXP) - expNeeded[PlayerPrefs.GetInt(Constants.DATA.LEVEL) - 1]);
                
                PlayerPrefs.SetInt(Constants.DATA.LEVEL, PlayerPrefs.GetInt(Constants.DATA.LEVEL) + 1);
                
                UpLevel();
            }
        }
    }
}
