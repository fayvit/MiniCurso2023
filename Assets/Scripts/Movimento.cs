using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    public float velocidade = 10;
    public CharacterController controle;
    public BulletBehaviour B;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool w = Input.GetKey(KeyCode.W);
        bool s = Input.GetKey(KeyCode.S);
        bool a = Input.GetKey(KeyCode.A);
        bool d = Input.GetKey(KeyCode.D);
        bool f = Input.GetKeyDown(KeyCode.F);

        int x = 0;
        if (a)
            x = -1;
        else if (d)
            x = 1;
        int z = 0;
        if (w)
            z = 1;
        else if (s)
            z = -1;

        controle.Move( new Vector3(x, -9.8f, z)*Time.deltaTime*velocidade);
        if (f)
        {
            Instantiate(B, transform.position + transform.forward, Quaternion.LookRotation(Vector3.down));
        }

    }
}
