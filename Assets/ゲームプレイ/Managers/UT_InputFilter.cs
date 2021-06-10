using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
/// <summary>
/// インプット管理
/// </summary>
public class UT_InputFilter : MonoBehaviour
{

    #region  Var
    static UT_Inputmanager im;

    private static bool Square;
    private static bool Triangle;
    private static bool Circle;
    private static bool Cross;
    private static Vector2 Buttons;
    private static Vector2 Axis;
    private static float Rtrig;
    #endregion
    void Awake()
    {
        im = new UT_Inputmanager();
        im.Player.Move.performed += ctx => Axis = ctx.ReadValue<Vector2>();
        im.Player.Move.canceled += ctx => Axis = Vector2.zero;

        im.Player.Rtrigger.performed += ctx => Rtrig = ctx.ReadValue<float>();

        im.Player.Rtrigger.canceled += ctx => Rtrig = 0;
        /*
                im.Player.Square.performed += ctx => Square = true;
                im.Player.Square.canceled += ctx => Square = false;

                im.Player.Tri.performed += ctx => Triangle = true;
                im.Player.Tri.canceled += ctx => Triangle = false;

                im.Player.Circle.performed += ctx => Circle = true;
                im.Player.Circle.canceled += ctx => Circle = false;

                im.Player.X.performed += ctx => Cross = true;
                im.Player.X.canceled += ctx => Cross = false;*/
        im.Player.Cross.performed += ctx => tst();
     //   im.Player.Cross.canceled += ctx => Cross = false;

    }
    void Update()
    {
    }
    void OnEnable()
    {
        im.Player.Enable();

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
        return Buttons.y < 0;// im.Player.X.ReadValue<bool>();
    }

    public static float GetTrig()
    {
        return Rtrig;
    }


}
