using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int x = 6;
        x += 3;//9
        x -= 2;//7
        x *= 5;//12
        x /= 3;//4

        x++;//3

        int Time = 4;
        bool BadNastr = true;
        bool MotoSlom = true;
        
        bool GoHome = (Time >= x || BadNastr) && MotoSlom;

        Debug.Log(GoHome);
        
    }

}
