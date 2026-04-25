using System;

namespace ConsoleApp1;

public class Program
{
    static void Main(string[] args)
    {
        // Develop a console application for each of the points in the list below. //
        // When a input is requested, the same must be provided by the user.

        //                            Birthdate
        DateTime birthDate = new DateTime(1999, 10, 30);
        DateTime Today = DateTime.Now;

        //                            primitive data types
        int userAge = Today.Year - birthDate.Year;
        if(Today < birthDate.AddYears(userAge))
        {
            userAge--;
        }

        // trade-off
        var ageInMonths = userAge * 12;

        /// <summary>
        /// local variables (usage) = camelCase for best practices
        /// </summary>
        string firstName = "Hudson";
        string middleName = "Ferraz";
        string lastName = "Souza";
        string fullName = $"{firstName} {middleName} {lastName}";

        char genderLetter = 'M';
        float heightInMeters = 1.80f;

        bool isProgramming = true;
        string programmingStudent = isProgramming
            ? "I'm a programming student!"
            : "No, I´m not in training";

        string eyeColour = "Brown";

        Console.WriteLine($"Name: {fullName}\nAge: {userAge}\nGender: {genderLetter}\nHeight: {heightInMeters}\nAre you studying programming? {programmingStudent}\nEyeColour: {eyeColour}");

        Console.ReadKey();
    }
}