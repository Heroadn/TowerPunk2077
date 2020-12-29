using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moviment : MonoBehaviour
{
    public int speed;
    public int maxSpeed;
    public int minSpeed;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {   
        anim = anim.GetComponent<Animator>();
        minSpeed = speed;
    }

    // Update is called once per frame
    void Update () {

        //vertical moviment :D
		if(Input.GetKey ("w")){
			transform.Translate(0, 0, (minSpeed * Time.deltaTime));
             anim.SetInteger("vertical", 1);
             anim.SetInteger("horizontal", 0);

		}else if(Input.GetKey ("s")){
			transform.Translate(0, 0, (-minSpeed * Time.deltaTime));
            anim.SetInteger("vertical", -1);
            anim.SetInteger("horizontal", 0);

		}else

        //horizontal moviment XD
		if(Input.GetKey ("a")){
			transform.Translate((-minSpeed * Time.deltaTime), 0, 0);
            anim.SetInteger("horizontal", -1);
            anim.SetInteger("vertical", 0);

		}else if(Input.GetKey ("d")){
			transform.Translate((minSpeed * Time.deltaTime), 0, 0);
            anim.SetInteger("horizontal", 1);
            anim.SetInteger("vertical", 0);

		}

        //sistema de sprint
        if ( Input.GetKey(KeyCode.LeftShift) && minSpeed <= maxSpeed ){
			minSpeed += 1;
            anim.SetBool("IsSprint", true);
		}
        if ( Input.GetKeyUp(KeyCode.LeftShift) ) {
            minSpeed = speed;
            anim.SetBool("IsSprint", false);
        }
    }
}
