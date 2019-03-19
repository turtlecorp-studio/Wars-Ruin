﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[CreateAssetMenu(fileName = "New Dialogue", menuName = "Dialogues")]
public class DialogueBase : ScriptableObject
{
    [System.Serializable]
    public class Info
    {
        public string myName;
        public Sprite portrait;
        [TextArea(4, 8)]
        public string myText;
    }

    [Header("Insert Dialogue Info Below")]
    public Info[] dialogueInfo;
}
