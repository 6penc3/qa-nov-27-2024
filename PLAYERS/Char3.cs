using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char3 : ABSTRACT
{
    [SerializeField] private UI ui;
    public Vector2 Position;
    public Vector2 Size;

    private void OnGUI()
    {
        if (GUI.Button(new Rect(614, 85, 257, 74), "Mage"))
        {
            ui.Information = ("Health: " + Health + "\nAttack" + "\nDefense: " + Defense);
        }
    }
}
