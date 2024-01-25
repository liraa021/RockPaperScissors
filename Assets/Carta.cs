using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Carta : MonoBehaviour
{

    float counter = 0;
    public SpriteRenderer carta;
    public List<Sprite> listaSprite = new List<Sprite>();
    string inputPlayer, inputCPU;
    int randomInt;
    bool playAgain = true;
    UIManager uimanager = new UIManager();
    Randomico randomic = new Randomico();
    public TMP_InputField valor;

    public void ProcessarEntrada()
    {
        if (playAgain)
        {
            int scorePlayer = 0;
            int scoreCPU = 0;

            while (scorePlayer < 3 && scoreCPU < 3)
            {
                UIManager.uimanager("Choose between Rock, PAPER and SCISSORS:             ");
                inputPlayer = valor.text;
                inputPlayer = inputPlayer.ToUpper();

                randomInt = randomic.GeraRandomic(1, 4);

                switch (randomInt)
                {
                    case 1:
                        inputCPU = "ROCK";
                        UIManager.uimanager("Computer chose ROCK");
                        if (inputPlayer == "ROCK")
                        {
                            UIManager.uimanager("DRAW!!\n\n");
                        }
                        else if (inputPlayer == "PAPER")
                        {
                            UIManager.uimanager("PLAYER WINS!!\n\n");
                            scorePlayer++;
                        }
                        else if (inputPlayer == "SCISSORS")
                        {
                            UIManager.uimanager("CPU WINS!!\n\n");
                            scoreCPU++;
                        }
                        break;
                    case 2:
                        inputCPU = "PAPER";
                        UIManager.uimanager("Computer chose PAPER");
                        if (inputPlayer == "PAPER")
                        {
                            UIManager.uimanager("DRAW!!\n\n");
                        }
                        else if (inputPlayer == "ROCK")
                        {
                            UIManager.uimanager("CPU WINS!!\n\n");
                            scoreCPU++;
                        }
                        else if (inputPlayer == "SCISSORS")
                        {
                            UIManager.uimanager("PLAYER WINS!!\n\n");
                            scorePlayer++;
                        }
                        break;
                    case 3:
                        inputCPU = "SCISSORS";
                        UIManager.uimanager("Computer chose SCISSORS");
                        if (inputPlayer == "SCISSORS")
                        {
                            UIManager.uimanager("DRAW!!\n\n");
                        }
                        else if (inputPlayer == "ROCK")
                        {
                            UIManager.uimanager("PLAYER WINS!!\n\n");
                            scorePlayer++;
                        }
                        else if (inputPlayer == "PAPER")
                        {
                            UIManager.uimanager("CPU WINS!!\n\n");
                            scoreCPU++;
                        }
                        break;
                    default:
                        UIManager.uimanager("Invalid entry!");
                        break;
                }
            }

            if (scorePlayer == 3)
            {
                UIManager.uimanager("Player WON!");
            }
            else if (scoreCPU == 3)
            {
                UIManager.uimanager("CPU WON!");
            }

            UIManager.uimanager("Do you want to play again ?(y/n)");
            /*string loop = Console.ReadLine();
            if (loop == "y")
            {
                playAgain = true;
            }
            else if (loop == "n")
            {
                playAgain = false;
            } */
        }
    }


    void Start()
    {

        Debug.Log("Bem-vindo ao jogo");

        carta.sprite = listaSprite[2];
       
        
    }    

    void Update()
    {

        
}
}
