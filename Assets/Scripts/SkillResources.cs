using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/skills", order = 999)]
public class SkillResources : MonoBehaviour
{
    [SerializeField] List<Skill> skills = new List<Skill>();
}

