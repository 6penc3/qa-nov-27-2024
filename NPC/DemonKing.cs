using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonKing : ABSTRACT
{
    [SerializeField] private UI ui;
    public Vector2 Position;
    public Vector2 Size;
    public string Demonic = "Health:  \nDefense: \nAttack: ";

    private void Start()
    {
      Demonic = ("Demon King \nHealth: " + Health + "\nAttack" + Attack + "\nDefense: " + Defense);
    }

    private void OnGUI()
    {
        GUI.Box(new Rect(82, 306, 763, 163), "Demon King");
    }
}
