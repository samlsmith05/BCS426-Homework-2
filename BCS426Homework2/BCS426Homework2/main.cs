//****************************************************
// File: main.cs
//
// Purpose: Utilize the dynamic link library and the 
//          serialization and deserialization code
//
// Written By: Samantha Smith
//
// Compiler: Visual Studio 2019
// 
// Update Information
// ------------------
//
// 
//****************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.IO;
using BCS426Homework2DLL;

namespace BCS426Homework2
{
    //****************************************************
    // Class: main{}
    //
    // Purpose: entry point for the program
    //
    // Update Information
    // ------------------
    // 
    //
    //****************************************************
    class main
    {
        static void Main(string[] args)
        {
            #region Class Instances
            Category c = new Category();        //instance of Category class
            Assignment a = new Assignment();    //instance of Assignment class
            Submission s = new Submission();    //instance of Submission class
            #endregion
            /*
            //initialize category
            c.Name = "Homework";
            c.Percentage = 35.0;

            //initialize assignment
            a.Name = "Homework 2";
            a.Description = "Create the submission class. Add serialization to all classes";
            a.CategoryName = "Homework";

            //initialize submission
            s.CategoryName = "Homework";
            s.AssignmentName = "Homework 2";
            s.Grade = 90.0;
            */

            //Variables
            string userInput;
            int intUserInput;

            //loops until the user inputs a 16
            do
            {
                //Menu
                System.Console.WriteLine("CourseWork Menu");
                System.Console.WriteLine("---------------");
                System.Console.WriteLine("1 - Read Category from JSON file");
                System.Console.WriteLine("2 - Read Category from XML file");
                System.Console.WriteLine("3 - Write Category to JSON file");
                System.Console.WriteLine("4 - Write Category to XML file");
                System.Console.WriteLine("5 - Display Category data on screen");
                System.Console.WriteLine("6 - Read Assignment from JSON file");
                System.Console.WriteLine("7 - Read Assignment from XML file");
                System.Console.WriteLine("8 - Write Assignment to JSON file");
                System.Console.WriteLine("9 - Write Assignment to XML file");
                System.Console.WriteLine("10 - Display Assignment data on screen");
                System.Console.WriteLine("11 - Read Submission from JSON file");
                System.Console.WriteLine("12 - Read Submission from XML file");
                System.Console.WriteLine("13 - Write Submission to JSON file");
                System.Console.WriteLine("14 - Write Submission to XML file");
                System.Console.WriteLine("15 - Display Submission data on screen");
                System.Console.WriteLine("16 - Exit");
                System.Console.Write("Enter Choice: ");

                userInput = System.Console.ReadLine();      //reads the userInput in string
                intUserInput = Convert.ToInt32(userInput);  //converts the userInput to an int

                if (intUserInput == 1)      //goes into this option if the user entered 1
                {
                    string fileName;
                    System.Console.WriteLine("Please enter a filename");
                    fileName = System.Console.ReadLine();           //gets the file name
                    
                    FileStream reader = new FileStream(fileName, FileMode.Open, FileAccess.Read);   //opens the FileStream to read the JSON from 

                    DataContractJsonSerializer serializer;          //creates an instance of DataContractJsonSerializer          
                    serializer = new DataContractJsonSerializer(typeof(Category));

                    c = (Category)serializer.ReadObject(reader);    //reads from the file
                    
                    reader.Close();                                 //closes the file
                }
                else if (intUserInput == 2)     //goes into this option if the user entered 2
                {
                    string fileName;
                    System.Console.WriteLine("Please enter a filename");
                    fileName = System.Console.ReadLine();   //gets the file name

                    FileStream reader = new FileStream(fileName, FileMode.Open, FileAccess.Read);   //opens the FileStream to read the XML from 

                    DataContractSerializer serializer;     //creates an instance of DataContractSerializer
                    serializer = new DataContractSerializer(typeof(Category)); 

                    c = (Category)serializer.ReadObject(reader);   //reads from the file
                    reader.Close();                                     //closes the file
                }
                else if (intUserInput == 3)    //goes into this option if the user entered 3
                {
                    string fileName;
                    System.Console.WriteLine("Please enter a filename");
                    fileName = System.Console.ReadLine();   //gets the file name

                    FileStream writer = new FileStream(fileName, FileMode.Create, FileAccess.Write);    //creates the file to write the JSON to

                    DataContractJsonSerializer serializer;      //creates a DataContractJsonSerializer instance for Category
                    serializer = new DataContractJsonSerializer(typeof(Category));  //specify the type to serialize

                    serializer.WriteObject(writer, c);      //writes to the file
                    writer.Close();                         //closes the file
                }   
                else if (intUserInput == 4)
                {
                    string fileName;
                    System.Console.WriteLine("Please enter a filename");
                    fileName = System.Console.ReadLine();   //gets the file name


                    FileStream writer = new FileStream(fileName, FileMode.Create, FileAccess.Write);   //creates the file to write the XML to

                    DataContractSerializer serializer;      //creates a DataContractSerializer instance for Category
                    serializer = new DataContractSerializer(typeof(Category));      //specifies the type to serialize

                    serializer.WriteObject(writer, c);      //writes to the file
                    writer.Close();                         //closes the file
                }
                else if (intUserInput == 5)     //goes into this option if the user enters 5
                {
                    //c.Name = "Test 3";               //test value
                    System.Console.WriteLine(c);       //uses the ToString method to display the data for Category
                }
                else if (intUserInput == 6)     //goes into this option if the user enters 6
                {
                    string fileName;
                    System.Console.WriteLine("Please enter a filename");
                    fileName = System.Console.ReadLine();           //gets the file name

                    FileStream reader = new FileStream(fileName, FileMode.Open, FileAccess.Read);   //opens the FileStream to read the JSON from 

                    DataContractJsonSerializer serializer;          //creates an instance of DataContractJsonSerializer          
                    serializer = new DataContractJsonSerializer(typeof(Assignment));

                    a = (Assignment)serializer.ReadObject(reader);    //reads from the file

                    reader.Close();                                 //closes the file
                }
                else if (intUserInput == 7)     //goes into this option if the user enters 7
                {
                    string fileName;
                    System.Console.WriteLine("Please enter a filename");
                    fileName = System.Console.ReadLine();   //gets the file name

                    FileStream reader = new FileStream(fileName, FileMode.Open, FileAccess.Read);   //opens the FileStream to read the XML from 

                    DataContractSerializer serializer;     //creates an instance of DataContractSerializer
                    serializer = new DataContractSerializer(typeof(Assignment));

                    a = (Assignment)serializer.ReadObject(reader);   //reads from the file
                    reader.Close();                                     //closes the file
                }
                else if (intUserInput == 8)     //goes into this option if the user enters 8
                {
                    string fileName;
                    System.Console.WriteLine("Please enter a filename");
                    fileName = System.Console.ReadLine();   //gets the file name


                    FileStream writer = new FileStream(fileName, FileMode.Create, FileAccess.Write);    //creates the file to write the JSON to

                    DataContractJsonSerializer serializer;      //creates a DataContractJsonSerializer instance for Assignment
                    serializer = new DataContractJsonSerializer(typeof(Assignment));  //specify the type to serialize

                    serializer.WriteObject(writer, a);      //writes to the file
                    writer.Close();                         //closes the file
                }
                else if (intUserInput == 9)     //goes into this option if the user enters 9
                {
                    string fileName;
                    System.Console.WriteLine("Please enter a filename");
                    fileName = System.Console.ReadLine();   //gets the file name

                    FileStream writer = new FileStream(fileName, FileMode.Create, FileAccess.Write);    //creates the file to write the XML to

                    DataContractSerializer serializer;      //creates a DataContractSerializer instance for Assingment
                    serializer = new DataContractSerializer(typeof(Assignment));  //specify the type to serialize

                    serializer.WriteObject(writer, a);      //writes to the file
                    writer.Close();                         //closes the file
                }
                else if (intUserInput == 10)    //goes into this option if the user enters 10
                {
                    Console.WriteLine(a);       //displays all the data for Assignment
                }
                else if (intUserInput == 11)    //goes into this option if the user enters 11
                {
                    string fileName;
                    System.Console.WriteLine("Please enter a filename");
                    fileName = System.Console.ReadLine();           //gets the file name

                    FileStream reader = new FileStream(fileName, FileMode.Open, FileAccess.Read);   //opens the FileStream to read the JSON from 

                    DataContractJsonSerializer serializer;          //creates an instance of DataContractJsonSerializer          
                    serializer = new DataContractJsonSerializer(typeof(Submission));

                    s = (Submission)serializer.ReadObject(reader);    //reads from the file

                    reader.Close();                                 //closes the file
                }
                else if (intUserInput == 12)    //goes into this option if the user enters 12
                {
                    string fileName;
                    System.Console.WriteLine("Please enter a filename");
                    fileName = System.Console.ReadLine();           //gets the file name

                    FileStream reader = new FileStream(fileName, FileMode.Open, FileAccess.Read);   //opens the FileStream to read the XML from 

                    DataContractSerializer serializer;          //creates an instance of DataContractSerializer          
                    serializer = new DataContractSerializer(typeof(Submission));

                    s = (Submission)serializer.ReadObject(reader);    //reads from the file

                    reader.Close();                                 //closes the file
                }
                else if (intUserInput == 13)    //goes into this option if the user enters 13
                {
                    string fileName;
                    System.Console.WriteLine("Please enter a filename");
                    fileName = System.Console.ReadLine();   //gets the file name


                    FileStream writer = new FileStream(fileName, FileMode.Create, FileAccess.Write);    //creates the file to write the JSON to

                    DataContractJsonSerializer serializer;      //creates a DataContractJsonSerializer instance for Submission
                    serializer = new DataContractJsonSerializer(typeof(Submission));  //specify the type to serialize

                    serializer.WriteObject(writer, s);      //writes to the file
                    writer.Close();                         //closes the file
                }
                else if (intUserInput == 14)    //goes into this option if the user enters 14
                {

                    string fileName;
                    System.Console.WriteLine("Please enter a filename");
                    fileName = System.Console.ReadLine();   //gets the file name


                    FileStream writer = new FileStream(fileName, FileMode.Create, FileAccess.Write);    //creates the file to write the XML to

                    DataContractSerializer serializer;      //creates a DataContractSerializer instance for Submission
                    serializer = new DataContractSerializer(typeof(Submission));  //specify the type to serialize

                    serializer.WriteObject(writer, s);      //writes to the file
                    writer.Close();                         //closes the file
                }
                else if (intUserInput == 15)    //goes into this option if the user enters 15
                {
                    Console.WriteLine(s);       //displays all the data for Submission
                }
                else if (intUserInput != 16)    //goes into this option if the user enters 16
                {
                    System.Console.WriteLine("Invalid input");  //prints if the user inputed anything besides 1, 2, ..., 16
                }
                System.Console.WriteLine();
            } while (intUserInput != 16);
        }
    }
}
