using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PC_Colchecker : MonoBehaviour
{
    // Start is called before the first frame update

    public colcir L,R,B,B2;
    public bool l,r,b;

    public colcir Squish_L,Squish_R,Squish_T,Squish_B;
    
    public bool SL,SR,ST,SB;
    




    // Update is called once per frame
    void Update()
    {
        l=L.state;
        r=R.state;
        b=(B.state||B2.state);

        SL=Squish_L.state;
        SR=Squish_R.state;
        ST=Squish_T.state;
        SB=Squish_B.state;





    }

    
}
