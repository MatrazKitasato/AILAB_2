using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UnitGame
{
    zombie,
    police,
    civilian
}
public class Health : MonoBehaviour
{
    public int hunger;
    public int sleep;
    public int wc;
    
    public Transform AimOffset;

    public UnitGame _UnitGame;
}
