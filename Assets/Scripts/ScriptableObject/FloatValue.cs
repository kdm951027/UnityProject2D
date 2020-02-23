using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FloatValue : ScriptableObject, ISerializationCallbackReceiver
{
    //Scriptable Obj doesn't receive start() or update()
    public float initialValue;
    [HideInInspector] //not show up in inspector
    public float RuntimeValue;

    //Reset heart when game is newly loaded
    public void OnAfterDeserialize()
    {
        RuntimeValue = initialValue;
    }

    public void OnBeforeSerialize()
    {

    }
}
