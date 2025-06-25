namespace Langua.Models
{
    public class Question
    {
        public int Id { get; set; }

        public int TextId { get; set; }
        public Text Text { get; set; }


        public string Content { get; set; }

        public string option1 { get; set; }
        public string option2 { get; set; }
        public string option3 { get; set; }
        public string option4 { get; set; }


        public int CorrectOption { get; set; }


    }
}
