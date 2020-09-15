using UnityEngine;

public class Player : MonoBehaviour
{
    //909-916進度
    //角色面向
    //角色移動方向
    //規範角色移動範圍

    //搖桿在這裡控制嗎?

    #region 欄位
    [Header("移動速度"), Range(0, 1000)]
    public float speed = 5;

    //public Vector2 limit = new Vector2(-3.2f, 3.2f);



    #endregion

    #region 方法

    private void Move()
    {

        //以下兩種寫法差在哪
        //用槓掉的寫法沒有顯示錯誤但是不會動

       
        //transform.position = new Vector3(Mathf.Clamp(transform.position.x, limit.x, limit.y), transform.position.y, transform.position.z);

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -3.2f, 3.2f), transform.position.y, transform.position.z);

        if (transform.localScale.x < 0)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                

                Vector3 theScale = transform.localScale;
                theScale.x *= -1;
                transform.localScale = theScale;
            }
        }
   
       
        bool A = Input.GetKey(KeyCode.A);
        if (A)
        {
            {
                transform.Translate(-speed * Time.deltaTime, 0, 0); //變形.位移(X, Y, Z)
            }
        }

        if (transform.localScale.x > 0)
        {
            if (Input.GetKeyDown(KeyCode.D))
            {

                Vector3 theScale = transform.localScale;
                theScale.x *= -1;
                transform.localScale = theScale;
            }
        }
        bool D = Input.GetKey(KeyCode.D);
        if (D)
        {
            transform.Translate(speed * Time.deltaTime, 0, 0); //變形.位移(X, Y, Z)
        }

        


    }


   
    #endregion

    #region 事件
    private void Update()
    {
        Move();
        
    }
    
    #endregion

}
