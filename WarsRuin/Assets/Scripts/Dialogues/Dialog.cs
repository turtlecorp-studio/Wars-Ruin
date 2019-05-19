using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Dialog
{
   public string name;
   public Sprite playerPortrait;
   public Sprite npcPortrait;
   [TextArea(3, 10)]
   public string[] sentences;
   
}
