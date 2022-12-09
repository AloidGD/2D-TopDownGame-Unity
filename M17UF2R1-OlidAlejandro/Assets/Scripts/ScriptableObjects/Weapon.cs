using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "ScriptableObject/Weapon")]
public class Weapon : ScriptableObject
{
    InputMaster InputMaster;

    [Header("Weapon Settings")]

    [SerializeField]
    Sprite Sprite;

    [SerializeField]
    int Size = 1;

    [SerializeField]
    [Range(1.0f, 10.0f)]
    int AttackVelocity = 10;

    [SerializeField]
    [Range(0.1f, 1f)]
    float AttackCooldown = 0.01f;

    public virtual void Attack(Transform transform) { }

    public Sprite GetSprite() 
    {
        return Sprite;
    }

    public float GetAttackCoolDown()
    {
        return AttackCooldown;
    }
}
