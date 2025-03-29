using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using static Sowtank.GameUtils;
public class GameManager : MonoBehaviour
{
    List<GameObject> enemigos = new List<GameObject>();

    #region Referencias
    public SkillResources skillResources;
    public SkillsManager skillManager;
    #endregion

    #region Settings
    [SerializeField] private string name = "asasdasf";
    #endregion

    #region Getters
    public string Name => name;
    #endregion

    void Start()
    {
        ApplyAll(enemigos, enemigos => enemigos.SetActive(false));  
    }
}
