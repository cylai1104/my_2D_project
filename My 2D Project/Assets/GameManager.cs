using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("虛擬搖桿")]
    public Joystick joystick;

    
   

   
    private void Update()
    {
        print("虛擬搖桿水平" + joystick.Horizontal);
    }
}
