using System;
using Microsoft.VisualBasic;
class Program
{
    static void Main()
    {
        Console.Title = "BMI Calculator";
        double weight, height;
        for (; ; )
        {
            string inputWeight = Interaction.InputBox("Enter your weight (kg): ", "Weight");
            if (Information.IsNumeric(inputWeight))
            {
                weight = Convert.ToDouble(inputWeight); 
                break;
            }
            else
            {
                Interaction.MsgBox("ERROR: NaN entered!", MsgBoxStyle.Critical, "Invalid Input"); // всплывает окно с ошибкой 
            }
        }
        for (; ; )
        {
            string inputHeight = Interaction.InputBox("Enter your height (cm): ", "Height");
            if (Information.IsNumeric(inputHeight))
            {
                height = Convert.ToDouble(inputHeight) / 100;
                break;
            }
            else
            {
                Interaction.MsgBox("ERROR: NaN entered!", MsgBoxStyle.Critical, "Invalid Input");
            }

        }

        double bmi = weight / (height*height);
        string category;
        if (bmi < 18.5) category = "Underweight";
        else if (bmi < 25) category = "healthy range";
        else if (bmi < 30) category = "overweight";
        else if (bmi < 40) category = "obesity";
        else category = "severe obesity";

        string result = "Date: " + DateTime.Now.ToShortDateString() +  "\n" + 
            "Your BMI: " + bmi.ToString("F2") + "\n" + // F2  знаков после запятой
            "Category: " + category;
        // ИНТЕРПОЛЯЦИЯ
        //string result = $"Date: {DateTime.Now.ToShortDateString()}\n" +
        //      $"Your BMI: {bmi:F2}\n" +
        //    $"Category: {category}";
        Interaction.MsgBox(result, MsgBoxStyle.Information, "Result BMI");
    }
}

