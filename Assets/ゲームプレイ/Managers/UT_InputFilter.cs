using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
/// <summary>
/// インプット管理
/// </summary>
public class UT_InputFilter : MonoBehaviour
{

    #region  Var

    private static bool Square;
    private static bool Triangle;
    private static bool Circle;
    private static bool Cross;
    private static Vector2 Axis;
    private static float Rtrig;
    #endregion
    void Awake()
    {


    }
    void Update()
    {
    }
    void OnEnable()
    {
 

    }
    public static void tst()
    {
        Debug.Log("test");
    }

    public static float GetHor()
    {

        return Axis.x;
    }
    public static float GetVer()
    {
        return Axis.y;
    }

    public static bool GetR()
    {

        return Axis.x > 0;
        /*
                if (Input.GetAxis("Horizontal") > 0)
                {
                    return true;
                }
                else
                if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
                {
                    return true;
                }


                return false;
        */
    }
    public static bool GetL()
    {
        return Axis.x < 0;
        /*
        if (Input.GetAxis("Horizontal") < 0)
        {
            return true;
        }
        else
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            return true;
        }
        return false;*/
    }
    public static bool GetU()
    {
        return Axis.y > 0;
        /*
                if (Input.GetAxis("Vertical") > 0)
                {
                    return true;
                }

                return false;*/
    }
    public static bool GetD()
    {
        return Axis.y < 0;
        /*
                if (Input.GetAxis("Vertical") < 0)
                {
                    return true;
                }

                return false;*/
    }





    public static bool GetCir()
    {
        return Circle;

    }
    public static bool GetTriangle()
    {
        return Triangle;

    }
    public static bool GetSquare()
    {
        return Square;
    }
    public static bool GetX()
    {
        return false;//Buttons.y < 0;// im.Player.X.ReadValue<bool>();
    }

    public static float GetTrig()
    {
        return Rtrig;
    }

    public static void SetAxis(InputAction.CallbackContext v)
    {
        Axis = v.ReadValue<Vector2>();
    }
    public static void SetTrig(InputAction.CallbackContext v)
    {
        Rtrig = v.ReadValue<float>();
    }

    public static void SetCross(InputAction.CallbackContext v)
    {
        Cross=v.ReadValueAsButton();
    }
    public static void SetSquare(InputAction.CallbackContext v)
    {
        Square=v.ReadValue<bool>();
    }  

}
