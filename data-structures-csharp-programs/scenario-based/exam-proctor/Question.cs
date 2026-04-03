class Question
{
    private static int _idCounter = 0;
    private int _questionNumber;
    private string _questionStatement;
    private string _questionSoltion;

    public Question(string questionStatement, string questionSolution)
    {
        _questionNumber = _idCounter++;
        _questionStatement = questionStatement;
        _questionSoltion = questionSolution;
    }

    public string GetQuestionStatement()
    {
        return _questionStatement;
    }

    public string GetQuestionSolution()
    {
        return _questionSoltion;
    }

    public override string ToString()
    {
        return $"\nQuestion Number: {_questionNumber+1}\nQuestion Statement: {_questionStatement}\nQuestion Solution: {_questionSoltion}\n\n";
    }
}