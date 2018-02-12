using UnityEngine;

public class FlipperScript : MonoBehaviour {
    //
    public float restPosition = 0f;
    //Angulo presionado
    public float pressedPosition = 45f;
    //Fuerza del impacto
    public float hitStrength = 10000f;
    //Fuerza del flipper
    public float flipperDamper = 150f;
    //Nombre de la entrada
    public string inpuntName;

    HingeJoint hingeJoint;


	// Use this for initialization
	void Start () {
        hingeJoint = GetComponent<HingeJoint>();
        //Para que se mueva con un limete determinado de grados
        hingeJoint.useSpring = true;
		
	}
	
	// Update is called once per frame
	void Update () {
        JointSpring spring = new JointSpring();
        spring.spring = hitStrength;
        spring.damper = flipperDamper;

        if (Input.GetAxis(inpuntName) == 1)
        {
            spring.targetPosition = pressedPosition;

        }
        else
        {
            spring.targetPosition = restPosition;
        }

        hingeJoint.spring = spring;
        hingeJoint.useLimits = true;	
	}
}
