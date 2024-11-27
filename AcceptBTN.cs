using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AcceptBTN : MonoBehaviour
{
    public Vector2 Position;
    public Vector2 Size;
    [SerializeField] private Char1 Swordsman;
    [SerializeField] private Char2 Archer;
    [SerializeField] private Char3 Mage;

    public int pHealth;

    public string pyHealth = "Health: ";
    private void OnGUI()
    {
        if (GUI.Button(new Rect(Position, Size), ""))
        {
            pyHealth = "Health: " + pHealth;
        }
    }

}
