using ConsoleApp1;


AnswersList<Answer> answers = new AnswersList<Answer>();
QuestionsList<Question> questions = new QuestionsList<Question>();
answers.Add(new Answer("Red", true));
answers.Add(new Answer("Orange", false));


ChooseOne q1 = new ChooseOne("What's the color of apples?", "Color", 10f, answers);
questions.AddQ(q1);
foreach(Answer answer in q1.Answers)
{
    if (answer.isCorrect)
    {
        Console.WriteLine($"Answer {answer.AnswerValue} is correct ");
    }
}

