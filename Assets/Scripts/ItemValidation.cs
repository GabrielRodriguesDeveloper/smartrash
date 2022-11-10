using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ItemValidation : MonoBehaviour
{
    public int pontos = 0;
    public bool Collected = false;
    public string deposit;

    public void Validator(string tagName, Collider other)
    {
        string tagNameDeposit = tagName + "Dep";

        if (other.gameObject.tag == tagName)
        {
            tagNameDeposit = tagName + "Dep";

            if (deposit == "")
            {
                print("Pegue outro item!");

            }

            if (deposit == tagNameDeposit)
            {

                Collected = false;
                deposit = "";
                print("GANHOU PONTO! Parabéns! Você tornou o mundo um lugar melhor!");
                pontos += 1;

            }
            if (deposit != tagNameDeposit && deposit != "")
            {
                pontos -= 1;
                print("PERDEU PONTO! Você contribuiu com 10% na poluição do Mundo!");
            }

        }
    }


    public void OnTriggerEnter(Collider other)
    {
        Validator("Mouse", other);
        if (other.gameObject.tag == "Mouse")
        {   
            if (deposit == "")
            {
                print("Pegue outro item!");

            }
            if (deposit == "MouseDep")
            {
                deposit = "";
                pontos += 1;
                Collected = false;
                print("GANHOU PONTO! Parabéns! Você tornou o mundo um lugar melhor!");


            }
            if (deposit != "MouseDep" && deposit != "")
            {
                pontos -= 1;
                print("PERDEU PONTO! Você contribuiu com 10% na poluição do Mundo!");
            }

        }
        if (other.gameObject.tag == "Key")
        {
            if (deposit == "")
            {
                print("Pegue outro item!");

            }
            if (deposit == "KeyDep")
            {
                deposit = "";
                pontos += 1;
                Collected = false;
                print("GANHOU PONTO! Parabéns! Você tornou o mundo um lugar melhor!");


            }
            if (deposit != "KeyDep" && deposit != "")
            {
                pontos -= 1;
                print("PERDEU PONTO! Você contribuiu com 10% na poluição do Mundo!");
            }

        }
        if (other.gameObject.tag == "Cam")
        {
            if (deposit == "")
            {
                print("Pegue outro item!");

            }
            if (deposit == "CamDep")
            {
                deposit = "";
                pontos += 1;
                Collected = false;
                print("GANHOU PONTO! Parabéns! Você tornou o mundo um lugar melhor!");


            }
            if (deposit != "CamDep" && deposit != "")
            {
                pontos -= 1;
                print("PERDEU PONTO! Você contribuiu com 10% na poluição do Mundo!");
            }

        }
        if (other.gameObject.tag == "Screen")
        {
            if (deposit == "")
            {
                print("Pegue outro item!");

            }
            if (deposit == "ScreenDep")
            {
                deposit = "";
                pontos += 1;
                Collected = false;
                print("GANHOU PONTO! Parabéns! Você tornou o mundo um lugar melhor!");


            }
            if (deposit != "ScreedDep" && deposit != "")
            {
                pontos -= 1;
                print(" PERDEU PONTO! Você contribuiu com 10% na poluição do Mundo!");
            }

        }
        if (other.gameObject.tag == "Laptop")
        {
            if (deposit == "")
            {
                print("Pegue outro item!");

            }
            if (deposit == "LapDep")
            {
                deposit = "";
                pontos += 1;
                Collected = false;
                print("GANHOU PONTO! Parabéns! Você tornou o mundo um lugar melhor!");


            }
            if (deposit != "LapDep" && deposit != "")
            {
                pontos -= 1;
                print("PERDEU PONTO! Você contribuiu com 10% na poluição do Mundo!");
            }

        }

        if (Collected == false)
        {
            if (other.gameObject.tag == "NoEletronic")
            {
                other.gameObject.SetActive(false);
                print("objeto coletado!");
                deposit = "NoEletronic";                 // alterar tag do deposito de lixos não eletronicos
                Collected = true;


            }

            if (other.gameObject.tag == "ScreenDep")
            {
                other.gameObject.SetActive(false);
                print("Objeto Coletado!");
                Collected = true;
                deposit = "ScreenDep";

            }

            if (other.gameObject.tag == "MouseDep")
            {
                other.gameObject.SetActive(false);
                print("Objeto Coletado!");
                Collected = true;
                deposit = "MouseDep";

            }

            if (other.gameObject.tag == "LapDep")
            {
                other.gameObject.SetActive(false);
                print("Objeto Coletado!");
                Collected = true;
                deposit = "LapDep";

            }

            if (other.gameObject.tag == "CamDep")
            {
                other.gameObject.SetActive(false);
                print("Objeto Coletado!");
                Collected = true;
                deposit = "CamDep";

            }
            if (other.gameObject.tag == "KeyDep")
            {
                other.gameObject.SetActive(false);
                print("Objeto Coletado!");
                Collected = true;
                deposit = "KeyDep";

            }
            if (other.gameObject.tag == "TabletDep")
            {
                other.gameObject.SetActive(false);
                print("Objeto Coletado!");
                Collected = true;
                deposit = "TabletDep";

            }

        }
    }
    
}
