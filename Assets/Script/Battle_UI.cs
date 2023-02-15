using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle_UI : MonoBehaviour
{
    public int battle_start;
    private BattleButton battlebutton;

    void Start()
    {
        battlebutton = battlebutton.GetComponent<BattleButton>();
        battle_start = battlebutton.battle_start;
    }

    void Update()
    {
        if (battle_start == 1)
        {
            Destroy(gameObject);
            return;
        }
    }
}
