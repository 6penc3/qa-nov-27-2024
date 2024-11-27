using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class DMGCalcu : ABSTRACT
{
    [SerializeField] Char1 character1;
    [SerializeField] Char2 character2;
    [SerializeField] Char3 character3;
    [SerializeField] AcceptBTN acceptbutton;
    [SerializeField] DemonKing demonking;
    public Vector2 Position;
    public Vector2 Size;

    private int Damage = 10;
    public string calcuHealth = "Health: ";
    public string defeat = "";

    private void OnGUI()
    {
        GUI.Box(new Rect(252, 340, 397, 110), "");
        

        if (GUI.Button(new Rect(286, 346, 338, 95), "Damage: " + Damage))
        {
            acceptbutton.pHealth -= Damage;
            acceptbutton.pyHealth = "Health: " + acceptbutton.pHealth;
            demonking.Health -= Damage;
            demonking.Demonic = ("Brain Drain \nHealth: " + demonking.Health + "\nDefense: " + demonking.Defense + "\nAttack: " + demonking.Attack);

            if (acceptbutton.pHealth < 0)
            {
                Debug.Log("meow meow meow meow meow meow meow meow meow meow meow meow");
                acceptbutton.pHealth = 0;
                acceptbutton.pyHealth = "Health: " + acceptbutton.pyHealth;

                defeat = "GAME OVER";
            }

            if (demonking.Health < 0)
            {
                demonking.Health = 0;
                demonking.Demonic = ("Brain Drain \nHealth: " + demonking.Health + "\nDefense: " + demonking.Defense + "\nAttack: " + demonking.Attack);
                defeat = "VICTORY";
            }

            GUI.Label(new Rect(252, 340, 397, 110), defeat);
            GUI.Label(new Rect(252, 340, 397, 110), acceptbutton.pyHealth);

        }    
    }

}
