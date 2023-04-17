using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundScript : MonoBehaviour{

    public float scroll_speed = 0.1f ;
    private MeshRenderer m_r ;
    private float y_s ; 


    // Start is called before the first frame update
    void Awake()
    {
        m_r = GetComponent<MeshRenderer>();

        
    }

    // Update is called once per frame
    void Update()
    {
        scroll();
        
    }
    void scroll(){
        y_s = Time.time * scroll_speed;
        Vector2 offset = new Vector2(y_s,0f);
        m_r.sharedMaterial.SetTextureOffset("_MainTex" , offset);
    }
}
