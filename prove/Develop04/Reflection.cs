using System;

class ReflectionActivity: Activity
{

    private List<string> _prompts = new List<string>{
        "What are you passionate about, and how can you incorporate more of that into your life?",
        "How have your priorities shifted in the past year, and why?",
        "What does success mean to you, and are you currently working towards it?",
        "How do you typically react to setbacks or challenges, and how can you improve your resilience?",
        "How do you want to grow or change in the next year, and what specific steps will you take to make that happen?",
        "Are there any habits or routines in your life that no longer serve you well, and what new ones can you adopt?",
        "How do you define happiness, and what actions can you take to cultivate more of it in your life?",
        "Reflect on a time when you faced a significant failure or disappointment. How did you grow from that experience?",
        "Imagine your ideal life 10 years from now. What steps can you take today to move closer to that vision?",
        "What is your relationship with time like, and how can you better align your actions with your long-term goals?",
        };
        public ReflectionActivity()
        {
            SetName($"Reflection Activity");
            SetDescription("With this activity, it will help you reflect on past memories and help you think of things or areas that you can improve");
        }
        public string GeneratePrompt()
        {
            Random random = new Random();
            int index = random.Next(0, _prompts.Count);
            return _prompts[index];
        }
        public void PromptReflecting()
        {   
            string prompt = GeneratePrompt();
            Console.WriteLine();
            Console.WriteLine("Consider the following prompt:");
            Console.WriteLine();
            Console.WriteLine($"--- {prompt} ---");
            Console.WriteLine();
            Console.WriteLine("When you have something in mind, press enter to continue.");
            Console.ReadLine();
            Console.Clear();
        
            DateTime futureTime = GetFutureTime(GetDuration());
            DateTime currentTime = GetCurrentTime();
        
         while (currentTime <= futureTime)
            {
            string promt = GeneratePrompt();
            Console.Write(promt + " ");
            GenerateSpinner(15);
            Console.WriteLine();
            currentTime = DateTime.Now;
            }
        }
}
