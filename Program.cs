namespace ICEtask1
{
    class Marking
    {
        static void Main(string[] args)
        {
            int totScripts,subTotQuestion,numLecturer,  numQuestionInput ;
            do
            {

                Console.WriteLine("Enter the total number of scripts that need marking:");
                 totScripts = Convert.ToInt32(Console.ReadLine());
                if (totScripts<= 0)
                {
                    Console.WriteLine("Value must be greater than 0");
                }
    
            }
            while (totScripts <= 0);
            
            
    

            do
            {
                Console.WriteLine("Enter the number of questions in the test:");
                 numQuestionInput = Convert.ToInt32(Console.ReadLine());

                if (numQuestionInput <1 || numQuestionInput >10)
                {
                    Console.WriteLine("Value must be between 1 and 10");
                }

            }
            while (totScripts <= 0);


            int x=0;
            int y = 1;
            for( int i = 0; i < numQuestionInput; i++ ) 
            {
                Console.WriteLine("Enter subtotal of each question:");

                   subTotQuestion = Convert.ToInt32(Console.ReadLine());
                x += subTotQuestion;
                y++;
            }
            Console.WriteLine("Total marks of script:" + y);

            
            do
            {
                Console.WriteLine("Enter the number of lecturers who are going to mark the scripts");
                numLecturer = Convert.ToInt32(Console.ReadLine());
                if(numLecturer <= 0)
                {
                    Console.WriteLine("Value must be graeter than 0");
                }

            }

           

            while (numLecturer <= 0);
            int total1 =   totScripts/ numLecturer;
            int total2 = total1 * x * 2;
            Console.WriteLine("Number of scripts each lecturer is going to mark =" + total1);
            TimeSpan time = TimeSpan.FromSeconds(total2);
            Console.WriteLine("total time : " + time);
        }

       
    }
}

