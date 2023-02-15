using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleButton : MonoBehaviour
{
    public GameObject fighter1;
    public GameObject fighter2;
    public int battle_start = 0;

    public void Start()
    {
        Instantiate(fighter1, new Vector3 (21, 0, 17), Quaternion.Euler (0f, -90f, 0f));
        Instantiate(fighter2, new Vector3 (5, 0, 19), Quaternion.Euler(0f, 90f, 0f));
        battle_start++;
    }
}
