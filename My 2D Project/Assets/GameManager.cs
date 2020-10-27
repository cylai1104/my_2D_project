using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("虛擬搖桿")]
    public Joystick joystick;
    public Transform target;
    
    private void Update()
    {
        ControlTarget();
    }


    private void ControlTarget()
    {

        target.Translate(joystick.Horizontal *5* Time.deltaTime, 0, 0);
        if (target.localScale.x < 0)
        { 
            if (joystick.Horizontal < 0)
           
            {//target.localPosition += joystick.Horizontal * Time.deltaTime*Vector3.one;
                //target.Translate(joystick.Horizontal * Time.deltaTime, 0, 0);
                Vector3 targetScale = target.localScale;
                targetScale.x *= -1;
                target.localScale = targetScale;
            }
        }

        if (target.localScale.x > 0)
        {
            if (joystick.Horizontal > 0)

            {//target.localPosition += joystick.Horizontal * Time.deltaTime*Vector3.one;
                //target.Translate(joystick.Horizontal * Time.deltaTime, 0, 0);
                Vector3 targetScale = target.localScale;
                targetScale.x *= -1;
                target.localScale = targetScale;
            }
        }



    }

}
