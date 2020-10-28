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
    public float speed = 0.5f;

    public Vector2 limit = new Vector2(-3.2f, 3.2f);
    [Header("音效區域")]
    public AudioClip facatch;
    public AudioClip socatch;
    public AudioClip racatch;
    public AudioClip sicatch;
    public AudioClip c4catch;
    public AudioClip c5catch;
    public AudioClip recatch;
    public AudioClip micatch;
   
    public AudioSource aud;

    private bool playso;
    private bool playsi;
    private bool playc4;
    private bool playc5;
    private bool playmi;
    private bool playre;
    private bool playra;
    private bool playfa;

    [Header("結束畫面")]
    public GameObject final;
    [Header("關卡")]
    public GameObject challenge;

    #endregion

    #region 方法

    private void Move()
    {

       


        transform.position = new Vector3(Mathf.Clamp(transform.position.x, limit.x, limit.y), transform.position.y, transform.position.z);

        //transform.position = new Vector3(Mathf.Clamp(transform.position.x, -3.2f, 3.2f), transform.position.y, transform.position.z);

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

    private GameObject note;

   
    public void Catch()
    {
        Destroy(note);
        if (playso) Catchso();
        if (playra) Catchra();
        if (playsi) Catchsi();
        if (playmi) Catchmi();
        if (playre) Catchre();
        if (playc5) Catchc5();
        if (playfa) Catchfa();
        if (playc4) Catchc4();
    }

    
    public void Catchso()
    {
        aud.PlayOneShot(socatch, 0.2f);
        Clear();
    }
    public void Catchra()
    {
        aud.PlayOneShot(racatch, 0.2f);
        
    }
    public void Catchsi()
    {
        aud.PlayOneShot(sicatch, 0.2f);
        
    }
    public void Catchmi()
    {
        aud.PlayOneShot(micatch, 0.2f);
            }
    public void Catchre()
    {
        
        aud.PlayOneShot(recatch, 0.2f);
    }
    public void Catchc5()
    {
        aud.PlayOneShot(c5catch, 0.2f);
    }
    public void Catchc4()
    {
        aud.PlayOneShot(c4catch, 0.2f);
    }
    public void Catchfa()
    {
        aud.PlayOneShot(facatch, 0.2f);
      
    }

    private void Clear()
    {
        final.SetActive(true);
        challenge.SetActive(false);
    }
   
    #endregion

    #region 事件
    private void Update()
    {
        Move();

        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "音符") note = collision.gameObject;
        if (collision.name == "so(Clone)") playso = true;
        if (collision.name == "fa(Clone)") playfa = true;
        if (collision.name == "mi(Clone)") playmi = true;
        if (collision.name == "re(Clone)") playre = true;
        if (collision.name == "c4(Clone)") playc4 = true;
        if (collision.name == "ra(Clone)") playra = true;
        if (collision.name == "si(Clone)") playsi = true;
        if (collision.name == "c5(Clone)") playc5 = true;

    }
   
    #endregion

}
