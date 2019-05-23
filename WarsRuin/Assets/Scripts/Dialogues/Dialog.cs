using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Dialog
{
   public Sprite leftName;
   public Sprite rightName;
   public Sprite playerPortrait;
   public Sprite npcPortrait;
   [TextArea(3, 15)]
   public string[] sentences;
   
}
