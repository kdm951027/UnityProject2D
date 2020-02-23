using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FloatValue : ScriptableObject
{
    //Scriptable Obj doesn't receive start() or update()
    public float initialValue;
}
