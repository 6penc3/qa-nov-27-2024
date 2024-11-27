using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public GUIStyle style;
    public Vector2 Position;
    public Vector2 Size;
    public string Information = "Health:  \nAttack: \nDefense: ";

    private void OnGUI()
    {
        GUI.Box(new Rect(18, 14, 885, 476), "");
        GUI.Box(new Rect(223, 23, 440, 46), "");
        GUI.Box(new Rect(301, 173, 313, 118), "");


        GUI.Label(new Rect(400, 40, 440, 46), "Select 1 of 3 characters...", style);
        GUI.Label(new Rect(305, 173, 313, 118), Information, style);

    }
}
