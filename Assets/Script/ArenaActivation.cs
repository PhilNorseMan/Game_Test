using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArenaActivation : MonoBehaviour
{
    public GameObject arenaMenu;

    private void OnMouseDown()   
    {
        Instantiate(arenaMenu, new Vector3 (0, 14, -9), Quaternion.Euler (0f, 0f, 0f));
    }
}
