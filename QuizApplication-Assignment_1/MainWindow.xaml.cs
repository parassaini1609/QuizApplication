using System.Windows;

namespace QuizApplication_Assignment_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int attempted = 0; //Counts the number of questions attempted by the user. This variable has been implemented in the option unlock method
        int enables = 1;
        int score = 0; //This variable counts the score
        int questionCount = 0; // This variable counts the question number
        //Array of 30 Questions
        string[] questions = { "1. Who is the president of the US?", "2. which car is the fastest?", "3. Who is the fastest runner in the world?",
"4. You're 4th place right now in a race. What place will you be in when you pass the person in 3rd place?", "5. Divide 30 by half and add ten.",
            "6. There are two clocks of different colors: The green clock is broken and doesn't run at all, but the yellow clock loses one second every 24 hours. Which clock is more accurate? ",
        "7. Jimmy's father has three sons- Paul I and Paul II. Can you guess the name of the third son? ", "8. If there are 3 apples on the table and you take 2 of them, how many will you have?",
            "9. It was Emily's first day at school. The teacher suggested that it would be a good idea for each child to meet every other child in the class. The teacher said, \"When you meet, please shake hands" +
                " and introduce yourself by name.\" If there were 10 children in the class, how many were the total handshakes?", "10. Which one of these characters is not friends with Harry Potter?",
        "11. Which planet is the hottest?", "12. In Pirates of the Caribbean, what was Captain Jack Sparrow’s ship’s name?","13. How many bones are there in the human body?",
        "14. Fe is the chemical symbol for…", "15. What is Shakespeare’s shortest tragedy?", "16. How many hearts does an octopus have?", "17. Which city is known as the City of Love?",
        "18. What does the “U” stand for in “UFO”?", "19. What is the complementary color of green?", "20. Han Solo is a character from which movie series:",
        "21. In Men and Black, what are the two FBI agents hunting?", "22.  How many Harry Potter books are there?",
        "23. Which rapper was known for his album Blue Slide Park?", "24. The UK is made up of the following countries: England, Ireland, Wales, and…",
        "25. How many elements are there on the periodic table?", "26. Where is the United Nations Headquarters?", "27. What does “FBI” stand for?",
        "28. What is the deadliest snake?", "29. How many degrees are in a circle?", "30. In Greek Mythology, who is the Queen of the Underworld?"};

        //Array of array of options
        string[,] options =  { { "Joe Biden", "Donald Trump", "Barak Obama", "Winston Churchil" }, { "Toyota", "Honda", "Nissan", "Subaru" },
            { "Justin Gatlin","Usain Bolt", "Jesse Owens","Carl Lewis"},{ "1st","2nd","3rd","None of the above"},{"40.5", "50", "70", "I Know this is a trick question, so NONE!"},
            { "The Green Clock", "The Yellow Clock","Neither","Both"},{ "PaulIII","Jerin","Jimmy","None"},{"Five", "Two", "Three", "Four" }, { "45", "50", "100", "55"},
        {"Ron Weasley", "Neville Longbottom", "Draco Malfoy","Hermione Granger" },{ "Venus", "Saturn", "Mercury", "Mars"},{ "The Marauder", "The Black Pearl", "The black Python", "The Slytherin"},
        { "206", "205", "201", "209"}, { "Zinc", "Hydrogen", "Flourine", "Iron"},{ "Macbeth", "Hamlet", "Romeo & Juliet", "Othello"}, { "1", "2", "3", "4"},
        { "Rome", "Barcelona", "New York City", "Paris"}, { "Unidentified", "Under", "United", "Unique"}, {"Blue", "Yellow", "Red", "Purple" }, {"Harry Potter", "Star Wars", "Lord Of The Rings", "Indiana Jones" },
        {"Serial Killers", "Ghosts", "Aliens", "Time Travellers" }, { "7", "8", "6", "10"}, {"J Cole", "Post Malone", "Eminem", "Mac Miller" },
        {"France", "Hungary", "Scotland", "Austria" }, { "112", "118", "120", "143"}, { "D.C", "NYC", "Philadelphia", "Orlando"},
        {"Federal Bureau of Investigation", "Federal Bureau of Inspection", "Federal Business of Investigation", "Fedral Bureau of Intoxication" },
        { "Python", "Cobra", "Black Mamba", "Rattle Snake"}, { "360", "180", "150", "359"},{ "Pandora", "Medusa", "Helen", "Persephone"} };

        //Array of answers
        string[] answers = { "A", "C", "B", "C","C","A","C", "B", "A","C", "A", "B", "A", "D","A", "C", "D", "A","C", "B", "C", "A", "D", "C", "B", "B",
        "A", "C","A", "D"};
        string userAns;
        public MainWindow()
        {
            InitializeComponent();


        }

        //Method to start the quiz. This method sets the visibility property of the following components to visible. It has been called inside the Start button click method
        public void BackgroundChange()
        {
            quizImg.Visibility = Visibility.Visible;
            questionBox.Visibility = Visibility.Visible;
            nextBnt.Visibility = Visibility.Visible;
            btnA.Visibility = Visibility.Visible;
            btnB.Visibility = Visibility.Visible;
            btnC.Visibility = Visibility.Visible;
            btnD.Visibility = Visibility.Visible;
            optA.Visibility = Visibility.Visible;
            optB.Visibility = Visibility.Visible;
            optC.Visibility = Visibility.Visible;
            optD.Visibility = Visibility.Visible;
            scoreCounter.Visibility = Visibility.Visible;
            scoreTxt.Visibility = Visibility.Visible;
            //The code below shows a message box displaying the quiz instructions when the user starts the quiz
            MessageBox.Show("The game has 30 questions and each questions is of one point\n" +
                "Once you have clicked on next, You can go back to the previous question, however you can't" +
                " answer again\n\n" + "All The Best!!", "Game Instructions", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        //Start Button method
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BackgroundChange();
            CycleQuestion();
            CycleOptions();
        }

        //Code for next button
        private void nxtClick(object sender, RoutedEventArgs e)
        {

            questionCount++;
            prevBtn.Visibility = Visibility.Visible;
            CycleQuestion();
            CycleOptions();
            GetAnswer();
            IncreamentScore();
            ClearSelection();
            OptionUnlock();
            enables++;
            if (btnA.IsEnabled == true)
            {
                attempted++;
            }
            Finisher();

        }
        private void Finisher()
        {
            if (questionCount == 29)
            {
                nextBnt.Visibility = Visibility.Hidden;
                finishButton.Visibility = Visibility.Visible;

            }
        }

        //A method which enables the radio buttons when the user clicks Next button
        public void OptionUnlock()
        {
            if (enables >= attempted)
            {
                btnA.IsEnabled = true;
                btnB.IsEnabled = true;
                btnC.IsEnabled = true;
                btnD.IsEnabled = true;
            }
        }

        //Method for previous button
        private void prevClick(object sender, RoutedEventArgs e)
        {
            questionCount--;
            CycleQuestion();
            RemovePrevious(questionCount);
            CycleOptions();
            ClearSelection();
            OptionLock();
            enables--;
            scoreCounter.Text = $"{score}/{questionCount}";
        }

        //Method which changes the questions
        public void CycleQuestion()
        {
            questionBox.Text = questions[questionCount];
        }

        //Method which removes the previous button when on the first question.
        public void RemovePrevious(int quesCount)
        {
            if (quesCount == 0)
                prevBtn.Visibility = Visibility.Hidden;
        }

        //Method which displays the options
        public void CycleOptions()
        {
            optA.Text = options[questionCount, 0];
            optB.Text = options[questionCount, 1];
            optC.Text = options[questionCount, 2];
            optD.Text = options[questionCount, 3];
        }

        //Method which clears the radio button selection
        public void ClearSelection()
        {

            btnA.IsChecked = false;
            btnB.IsChecked = false;
            btnC.IsChecked = false;
            btnD.IsChecked = false;

        }

        //Method to get the user selected answer in form of A, B, C or D
        public void GetAnswer()
        {

            if (btnA.IsChecked == true)
            {
                userAns = "A";
            }
            else if (btnB.IsChecked == true)
            {
                userAns = "B";
            }
            else if (btnC.IsChecked == true)
            {
                userAns = "C";
            }
            else if (btnD.IsChecked == true)
            {
                userAns = "D";
            }

        }

        //A method to disable the radio buttons when the user clicks the previous button so they cannot change the answer once attempted
        public void OptionLock()
        {
            btnA.IsEnabled = false;
            btnB.IsEnabled = false;
            btnC.IsEnabled = false;
            btnD.IsEnabled = false;
        }

        //Method to increament and display the score variable
        public void IncreamentScore()
        {
            if (userAns == answers[questionCount - 1])//This if statement validates the answer and if the answer is correct, the value of score variable gets increased by 1.36
            {
                score++;
            }

            scoreCounter.Text = $"{score}/{questionCount}";
            //changed
            userAns = "";
        }

        private void btn_fin(object sender, RoutedEventArgs e)
        {
            IncreamentScore();
            string messageBoxText = $"Congractulations your final score is {score}";
            MessageBox.Show(messageBoxText, "Finished", MessageBoxButton.OK, MessageBoxImage.Information);
            Close();
        }
    }
}
