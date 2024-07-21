using System;

class Program
{
    static void Main(string[] args)
    {
        //Lecture
        Address address1 = new Address("Rua Dos Fusileiros Navais", "Santo André", "Setúbal", "2830-291", "Portugal");
        string lectureAddress = address1.GetAddress();
        Lecture lectureActivity = new Lecture("Institute", "Presential religion classes with other members of the church", "July 27th, 2024", "7:00pm", $"{lectureAddress}", "Lecture", "Elder Michael", 30);

        // Display lecture details
        Console.WriteLine("-------------------------------------------------------------");
        lectureActivity.DisplayShortDescription();
        Console.WriteLine();
        lectureActivity.DisplayStandartDetails();
        Console.WriteLine();
        lectureActivity.DisplayLectureFullDetails();

        // Reception
        Address address2 = new Address("Av. Principal Lomas de Funval", "Valencia", "Carabobo", "0051-032", "Venezuela");
        string receptionAddress = address2.GetAddress();
        Reception receptionActivity = new Reception("Summer Party", "Enjoy this summer with your friends whit the bests Djs", "September 14/15th, 2024", "10:30pm - 5:00am", $"{receptionAddress}", "Reception", "mysummer-party@gmail.com");

        // Display reception details
        Console.WriteLine("-------------------------------------------------------------");
        receptionActivity.DisplayShortDescription();
        Console.WriteLine();
        receptionActivity.DisplayStandartDetails();
        Console.WriteLine();
        receptionActivity.DisplayReceptionFullDetails();

        // Outdoor
        Address address3 = new Address("Rua da Guarda Nacional Republicana", "Azambuja", "Lisbon", "291-262", "Portugal");
        string outdoorAddress = address3.GetAddress();
        Outdoor outdoorActivity = new Outdoor("Yoga", "Relax your mind and body", "July 23th, 2024", "9:00am", $"{outdoorAddress}", "Outdoor", "Sunny");

        // Display outdoor details
        Console.WriteLine("-------------------------------------------------------------");
        outdoorActivity.DisplayShortDescription();
        Console.WriteLine();
        outdoorActivity.DisplayStandartDetails();
        Console.WriteLine();
        outdoorActivity.DisplayOutdoorFullDetails();
    }
}