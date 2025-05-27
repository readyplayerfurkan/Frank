using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelSO", menuName = "Scriptable Objects/LevelSO")]
public class LevelSO : ScriptableObject
{
    public float currentExp;
    public float nextExp;
    public int currentLevel;
    public int nextLevel;
    public List<int> levels;
}
