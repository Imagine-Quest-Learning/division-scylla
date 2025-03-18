using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DivisionAttack : MonoBehaviour
{
    [SerializeField] InputField answer;
    [SerializeField] Text question;
    public SnakeEnemy snake;
    public Player player;

    int x;//second term in question
    int y;//valid answer
    int z; //first term in question

    // Start is called before the first frame update
    void Start()
    {
       answer.Select();
       NextQuestion();
    }

    // Update is called once per frame
    void Update()
    {
        //answer.Select();
        if (Input.GetKeyDown(KeyCode.Return))
		{
			string playerAnswer = answer.text;

            if(playerAnswer == y.ToString()){

               //snake lose health and player is given next question
                snake.TakeDamage(20);
                //answer.Select();
                NextQuestion();
                
            }else{
                
                //player lose life for wrong answer
                player.TakeDamage(1);
                question.color = Color.red; 
                
                answer.text = "";
                answer.Select();
                answer.ActivateInputField();
                
            }
            
            
            
		}   
    }

    void NextQuestion(){

        Debug.Log("Static constructor running!");
        //new generated question
        x = Random.Range(1,15);
        y = Random.Range(0,15);
        z = x*y;

        //update text
        answer.text = "";
        answer.Select();
        answer.ActivateInputField();
        question.text = z.ToString() + "/" + x.ToString() + " = ?";
        question.color = Color.white;
        
    }
}
