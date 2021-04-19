using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Link : MonoBehaviour
{
    public string url = "https://zrzutka.pl/5mj884";

 public void Open()
    {
        Application.OpenURL(url);
    }
}
