using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char2 : ABSTRACT
{
    [SerializeField] private UI ui;
    public Vector2 Position;
    public Vector2 Size;

    private void OnGUI()
    {
        if (GUI.Button(new Rect (334, 85, 257, 74), "Archer"))
        {
            ui.Stats = ("Health: " + Health + "\nAttack" + Attack + "\nDefense: " + Defense);
        }
    }
}
