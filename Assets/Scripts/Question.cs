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
    public TimerController timer;
    public float timeMax = 25;
    float baseAttack = 20;
    int attack;

    int x;//second term in question
    int y;//valid answer
    int z; //first term in question
    bool canAnswer = true;

    // Start is called before the first frame update
    void Start()
    {
       answer.Select();
       timer.SetMaxTime(timeMax);
       NextQuestion();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer.timeRemaining <= 0)
        {
            // for when timer runs out
            canAnswer = false;
            player.TakeDamage(1);
            NextQuestion();
            return;
        }
        if (Input.GetKeyDown(KeyCode.Return) && canAnswer)
		{
		    CheckAnswer(); 
		}   
    }

    void CheckAnswer(){
        string playerAnswer = answer.text;

        if(playerAnswer == y.ToString()){
            //snake lose health and player is given next question
            attack = (int)Mathf.Floor(baseAttack * (timer.timeRemaining/timer.timeMax));
            snake.TakeDamage(attack);
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

    void NextQuestion(){

        //new generated question
        x = Random.Range(1,15);
        y = Random.Range(0,15);
        z = x*y;

        //update + reset text and question box
        answer.text = "";
        answer.Select();
        answer.ActivateInputField();
        question.text = z.ToString() + "/" + x.ToString() + " = ?";
        question.color = Color.white;

        //resetting timer
        timer.ResetTimer();
        canAnswer = true;
        
    }
}
