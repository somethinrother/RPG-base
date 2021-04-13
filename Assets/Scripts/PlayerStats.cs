using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int currentLevel;
    public int currentExperience;
    public int[] experienceThreshholds;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(currentExperience >= experienceThreshholds[currentLevel - 1])
        {
            currentLevel ++;
        }
    }

    public void AddExperience(int xpGained)
    {
        currentExperience += xpGained;
    }
}
