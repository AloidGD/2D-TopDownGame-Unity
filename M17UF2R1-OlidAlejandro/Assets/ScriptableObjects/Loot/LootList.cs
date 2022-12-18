using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Loot List", menuName = "ScriptableObject/Loot List")]
public class LootList : ScriptableObject
{
    [SerializeField]
    List<Loot> List;
}