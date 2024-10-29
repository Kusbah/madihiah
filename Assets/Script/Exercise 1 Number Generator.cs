using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        int counter = 0;
        while (counter < 20)
        {
            int randomnumber = Random.Range(1, 21);
            if (randomnumber == 5)
            {
                continue;
            }
            else if (randomnumber == 15)
            {
                break;
            }
            Debug.Log(randomnumber);
            counter++;
        }

    }

}
