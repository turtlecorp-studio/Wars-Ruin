using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadVillage : MonoBehaviour
{
    public LevelLoader other;

    private void OnTriggerEnter(Collider col)
    {
        col.gameObject.tag = "Player";
        other.LoadLevel(3);
    }
}
