using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moviment : MonoBehaviour
{
    public int minSpeed;
    public int maxSpeed;
    public int speed;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {   
        anim = anim.GetComponent<Animator>();
        speed = minSpeed;
    }

    // Update is called once per frame
    void Update () {

        //vertical moviment :D
		if(Input.GetKey ("w")){
			transform.Translate(0, 0, (speed * Time.deltaTime));
             anim.SetInteger("vertical", 1);
             anim.SetInteger("horizontal", 0);

		}else if(Input.GetKey ("s")){
			transform.Translate(0, 0, (-speed * Time.deltaTime));
            anim.SetInteger("vertical", -1);
            anim.SetInteger("horizontal", 0);

		}else

        //horizontal moviment XD
		if(Input.GetKey ("a")){
			transform.Translate((-speed * Time.deltaTime), 0, 0);
            anim.SetInteger("horizontal", -1);
            anim.SetInteger("vertical", 0);

		}else if(Input.GetKey ("d")){
			transform.Translate((speed * Time.deltaTime), 0, 0);
            anim.SetInteger("horizontal", 1);
            anim.SetInteger("vertical", 0);

		}else{
            anim.SetInteger("vertical", 0);
            anim.SetInteger("horizontal", 0);
        }

        //sistema de sprint
        if ( Input.GetKey(KeyCode.LeftShift) && speed <= maxSpeed ){
			speed += 1;
            anim.SetBool("IsSprint", true);
		}
        if ( Input.GetKeyUp(KeyCode.LeftShift) ) {
            speed = minSpeed;
            anim.SetBool("IsSprint", false);
        }
    }
    
}
