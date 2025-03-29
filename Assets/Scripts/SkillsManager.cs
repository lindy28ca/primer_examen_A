using UnityEngine;
using Sirenix.OdinInspector;
public class SkillsManager : MonoBehaviour
{
    [Button]
    public void SearchPrerequisites(Skill skill)
    {
        print("Nombre: " +  skill.SkillName);
        if(skill.PreRequisites.Count == 0)
        {
            return;
        }
        Debug.Log("Se necesita:");
        for (int i = 0; i < skill.PreRequisites.Count; i++)
        {
            SearchPrerequisites(skill.PreRequisites[i]);
        }
    } 
}
