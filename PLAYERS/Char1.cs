using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char1 : ABSTRACT
{
    [SerializeField] private UI ui;
    public Vector2 Position;
    public Vector2 Size;

    private void OnGUI()
    {
        if (GUI.Button(new Rect(51, 85, 257, 74), "Swordsman"))
        {
            ui.Information = ("Health: " + Health + "\nAttack" + "\nDefense: " + Defense);
        }
    }
}
