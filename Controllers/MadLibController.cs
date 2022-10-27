//Name: Ulises Ortega
//Date:10.25.22
//Project: MadLib
//Description: This Endpoint request the user to enter a series of answer to output a cool story that interpolate and the user answers.
//Peer Review Isaiah Ferguson Code works as intened great use of \n to put the story into a paragraph! great job.

/*Instructions: This Endpoint will request the user to enter 10 answers in order to run, once all the answers have been entered
Please link example below for structure
https://localhost:7024/MadLib/Answers/answer1/answer2/answer3/answer4/answer5/answer6/answer7/answer8/answer9/answer10
When you Run and Debug this Endpoint, please replace each answe field with your own answers, you should the following output

This is what you should see as an output in your screen:
In my days off I like to go answer1 
So I can do some answer2 
for lunch I like to have a answer3 
with answer4 
and drink  answer5 
then relax and watch the answer6 
and fall answer7 
for a couple of answer8 
before driving back answer9 
after a cool answer10
*/


using Microsoft.AspNetCore.Mvc;
namespace OrtegauMad_Lib___Endpoint.Controllers;

[ApiController]
[Route("[controller]")]

public class MadLibController : ControllerBase
{
    [HttpGet]
    [Route("Answers/{place}/{Sport}/{burguer}/{fries}/{coke}/{waves}/{sleep}/{hours}/{home}/{day}")]

    public string Words(string place, string sport, string burguer, string fries, string coke, string waves, string sleep, string hours, string home, string day)
    {
        return $"In my days off I like to go {place} \nSo I can do some {sport} \nfor lunch I like to have a {burguer} \nwith {fries} \nand drink  {coke} \nthen relax and watch the {waves} \nand fall {sleep} \nfor a couple of {hours} \nbefore driving back {home} \nafter a cool {day}";
    }
}