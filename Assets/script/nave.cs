using UnityEngine;

public class nave : MonoBehaviour
{
    void Update()
    {
        //Captura os valores de input quando as teclas 
        // A, D, <- , ->  forem pressionadas
        //converte esse valor para um float
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        //se o valor obtido for diferente de 0, realiza a movimentação
        if (horizontal != 0.0f)
        {
            //adiciona ao valor atual de posição um novo vector3
            // ex: Vector3(1,0,0) + Vector3(5,0,0) = Vector3(6,0,0)
            transform.position += new Vector3(horizontal, vertical, 0) * 5.0f * Time.deltaTime;
        }
        //Zera a rotação do personagem (ficar sempre de pé)
        if (transform.rotation != new Quaternion(0, 0, 0, 0))
        {
            transform.rotation = new Quaternion(0, 0, 0, 0);
        }

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       

        



    }
}
