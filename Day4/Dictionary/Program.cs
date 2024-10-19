namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //define dictionary
            Dictionary<Question , List<Answer>> exams = new Dictionary<Question , List<Answer>>();

            //define question 1
            Question question1 = new Question(" Which function best describe the concept of polymorphism in programming languages?" , 1);
            
            //define list of answers of question 1
            List<Answer> answerList1 = new List<Answer>(4)
            {
                new Answer(1 , "Class member function"),
                new Answer(2 , "Virtual function"),
                new Answer(3 , "Inline function"),
                new Answer(4 , "Undefined function")
            };
            exams.Add(question1, answerList1);


            //define question 2
            Question question2 = new Question(" Which among the following is not a member of the class?", 3);

            //define list of answers of question 1
            List<Answer> answerList2 = new List<Answer>(4);
            answerList2.Add(new Answer(1, "Virtual function"));
            answerList2.Add(new Answer(2, "const function"));
            answerList2.Add(new Answer(3, "Static function"));
            answerList2.Add(new Answer(4, "Friend function"));

            exams.Add(question2, answerList2);


            foreach (KeyValuePair<Question , List<Answer>> item in exams)
            {
                Console.WriteLine(item.Key);
                foreach(Answer answer in item.Value)
                {
                    Console.WriteLine(answer.ToString());
                }
            }
        }
    }
}
