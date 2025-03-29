using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillXP 
{
    public int CurrentLevel;
    public int XpRequired;
    public int CurrentXP;

    public void Set(int Level)
    {
        CurrentLevel = Level;
        XpRequired = (Level + 2) * 3;
        CurrentXP = 0;
    }
    public void AddXP(int xp)
    {
        if ((CurrentXP += xp) >= XpRequired)
            Set(CurrentLevel++);

        CurrentXP += xp;
    }
}
public class PlayerSkills : MonoBehaviour
{
Dictionary<Skill, SkillXP> SkillTreeFlayer = new Dictionary<Skill, SkillXP>();
}
