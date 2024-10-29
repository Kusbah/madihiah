using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int num = 1;
        while (num <= 20)
        {
            if (num == 5)
            {
                continue;
            }
            else if (num == 15)
            {
                break;
            }
            Debug.Log(num);
            num++;
        }

    }

}
