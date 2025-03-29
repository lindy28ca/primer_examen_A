using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/skills", order = 999)]
public class Skill : ScriptableObject
{
    [SerializeField] private string skillname;
    [SerializeField] private int cost;
    [SerializeField] private string description;
    [SerializeField]List<Skill> preRequisites;

    public string SkillName => skillname;
    public string Description => description;
    public int Cost => cost;
    public List<Skill> PreRequisites => preRequisites;
}

