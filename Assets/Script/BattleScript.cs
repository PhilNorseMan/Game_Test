using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleScript : MonoBehaviour
{
    private float battle_time = 0;
    GameObject[] skills = new GameObject[6];
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        battle_time += Time.deltaTime;

        if (battle_time > 10)
        {
            Destroy(gameObject);
        }
    }
}
