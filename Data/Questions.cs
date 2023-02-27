public class Questions
{
    public List<Participant> GetQuestions()
    {
        List<Participant> data = new List<Participant>();
        data.Add(new Participant { Id = 1, Question = " The language of Lakshadweep a Union Territory of India", Answer = "1.Tamil 2.Hindi 3.Malyalam 4.Punjabi", CorrectAns = 3 });

        data.Add(new Participant { Id = 2, Question = "Nandyal is situated in", Answer = "1.Karnataka 2.Punjab 3.Manipur 4.Himachal", CorrectAns = 1 });
        data.Add(new Participant { Id = 3, Question = " Which of the followiing is a folk dance of India?", Answer = "1.Kathakali 2.Mohiniattam 3.Garba 4.Manipuri", CorrectAns = 3 });
         data.Add(new Participant { Id = 4, Question = " Ghototkach in Mahabharat was the son of", Answer = "1.Duryodhana 2.Arjuna 3.Yudhishthir 4.Bhima", CorrectAns = 4 });
        data.Add(new Participant { Id = 5, Question = "Which city of India was first of all affected by plague?", Answer = "1.Jaipur 2.Surat 3.Mohali 4.Banglore", CorrectAns = 2 });
        data.Add(new Participant { Id = 6, Question = " Dogri is spoken in which of the following states ", Answer = "1.Punjab 2.kerela 3.Andhra Pradesh 4.Jammu & Kashmir", CorrectAns = 4 });
         data.Add(new Participant { Id = 7, Question = "The festival celebrated to commemorate the ordeal of Islamics is", Answer = "1.Id-ul-Zuha 2.Moharram 3.Id-i-Milad 4.Id-ul-Fitr", CorrectAns = 1 });
        data.Add(new Participant { Id = 8, Question = " Meenakshi Temple is in", Answer = "1.Puri 2.Trivandrum 3.Chennai 4.Madurai", CorrectAns = 4 });
        data.Add(new Participant { Id = 9, Question = "September 27 is celebrated every year as ", Answer = "1.Teachers'Day 2.National Integration Day 3.World Tourism Day 4.International Literacy Day", CorrectAns = 3 });


        return data;

    }
}
