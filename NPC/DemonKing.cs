using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonKing : ABSTRACT
{
    [SerializeField] private UI ui;
    public Vector2 Position;
    public Vector2 Size;

    private void OnGUI()
    {
      ui.Information = ("Health: " + Health + "\nAttack" + "\nDefense: " + Defense);
    }
}
