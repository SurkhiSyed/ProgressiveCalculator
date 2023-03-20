//Syed Kaab Surkhi
//March 13, 2023
//Mr. A. Mayer
//A simple calculator through Windows Forms App
using System;
using System.Windows.Forms;

namespace C_SharpCalculator
{
    public partial class Complex_Calculator : Form
    {

        public static Complex_Calculator instance;
        public string num1;         //Create a string variable named "num" that stores the first number
        public string num2;        //Create a string variable named "num2" that stores the second number
        public string display;        //Create a string variable named "display" that stores the value that will be outputted
        public string condition = "num1";        //Create a string variable named "condition" that decides if user input is num1 or num2
        public string operation;        //Create a string variable named "operation" that stores the operation selected
        public bool flag = false;        //Create a boolean variable named "flag" that is set to false and decides if decimal is pressed or not
        public string Operator;        //Create a string variable named "Operator" that stores the operator selected
        public bool equal = false;      //Create a boolean variable named "equal" that is set to false and decides if the equal button is pressed
        public bool pi = false;     //Create a boolean variable named "pi" that is set to false and decides if the pi button is pressed
        public bool numPress = false;       //Create a boolean variable named "numPress" that decides if a number is pressed
        public bool operationPress = false; //Create a  boolean variable named "operationPress" that decides if an operation button is pressed
        public bool percentagePress = false; //Create a boolean variable named "percentagePress" that decies if the percent button is pressed

        public Complex_Calculator()
        {
            InitializeComponent();
        }

        private void Equal_btn_Click(object sender, EventArgs e)        //When the Equal button is pressed
        {
            if(num2 == "" && operation != "") //Check if num2 is empty and if an operation is selected after selecting num1
            {
                Output_txt.Text = "Invalid"; //Output "Invalid"
            }
            else if (num1 == ".")//Check if num1 contains only decimal (no numbers) 
            {
                Output_txt.Text = "Invalid"; //Output "Invalid"
            }
            else if (num2 == ".") //Check if num2 contains only decimal (no numbers)
            {
                Output_txt.Text = "Invalid"; //Output "Invalid"
            }
            else //Else everything else
            {
                SavedAnswer_txt.Text += num2 + " = ";       //Add num2 and "=" to the SavedAnswer (History) textbox 
                num1 = operations(operation, num1, num2);       //Set num1 to the return value of the operations function
                num1 = Convert.ToString(Math.Round(Convert.ToDouble(num1), 5));     //Round num1 to 5 decimals
                SavedAnswer_txt.Text += num1;       //Add num1 to the SavedAnswer (History) textbox
                Output_txt.Text = num1;     //Set the output box to the value of num1
            }

            Input_txt.Text = "";      //Set the Input box to empty
            display = "";       //Set the display variable to empty
            operation = "";     //Set the operation varuable to empty
            condition = "num1";      //Reset condition to "num"
            num1 = "";      //Set num1 vairable to empty
            num2 = "";      //Set num2 variable to empty
            flag = false;   //Set flag to false

            //Disable all the operation buttons
            Equal_btn.Enabled = false;     
            Addition_btn.Enabled = false;
            Subtraction_btn.Enabled = false;
            Division_btn.Enabled = false;
            Multiplication_btn.Enabled = false;
            Percentage_btn.Enabled = true; //Enable Pecentage button
            PlusMinus_btn.Enabled = false;
            Root_btn.Enabled = false;
            Power_btn.Enabled = false;
            Decimal_btn.Enabled = false;

            equal = true;       //Set equal boolean to true
            pi = false;         //Set pi boolean to false
            numPress = false;   //Set numPress boolean to false
            percentagePress = false;
        }

        //Operations function that takes in the operation, num1 value, num2 value, and does the operation to them and returns the num1 value
        static string operations(string operation, string num1, string num_2)  
        { 
            //If the operation is equal to any of the following operations, do the respective operations and equal them to num1
            if (operation == "sum")
            {
                num1 = Convert.ToString(Convert.ToDouble(num1) + Convert.ToDouble(num_2));
            }
            else if (operation == "difference")
            {
                num1 = Convert.ToString(Convert.ToDouble(num1) - Convert.ToDouble(num_2));
            }
            else if (operation == "product")
            {
                num1 = Convert.ToString(Convert.ToDouble(num1) * Convert.ToDouble(num_2));
            }
            else if (operation == "quotient")
            {
                num1 = Convert.ToString(Convert.ToDouble(num1) / Convert.ToDouble(num_2));
            }
            else if(operation == "power")
            {
                num1 = Convert.ToString(Math.Pow(Convert.ToDouble(num1), Convert.ToDouble(num_2)));
            }
            else if(operation == "root")
            {
                num1 = Convert.ToString(Math.Pow(Convert.ToDouble(num_2), (1.0/ Convert.ToDouble(num1))));
            }
            //return the num1 variable
            return num1;

        }

        //If clear button (C) is pressed
        private void Clear_btn_Click(object sender, EventArgs e)
        {
            //Clear all of the textboxes and vairables
            Input_txt.Text = "";
            Output_txt.Text = "";
            display = "";
            operation = "";
            SavedAnswer_txt.Text = "";
            condition = "num1";     //Reset the condition to "num1"
            num1 = "";      //Set num1 variable to empty
            num2 = "";      //Set the num2 variable to empty
            flag = false;   //Set the flag boolean to false
            pi = false;     //Set the pi boolean to false
            numPress = false;   //Set the numPress bolean to false
        }

        private void Decimal_btn_Click(object sender, EventArgs e) //If the Decmial button is clicked
        {
            if(flag == false) //If flag boolean = "false"
            {
                if(pi == false)
                {
                    if (condition == "num1") //If the condition = "num1"
                    {
                        num1 += "."; //Add decminal to the end of num1 variable
                    }
                    else if (condition == "num2") //If the condition is equal to "num2"
                    {
                        num2 += ".";    //Add decimal to the end of num2 variable
                    }
                    display += "."; //Add a deciaml to the end of the tdisplay variable
                    flag = true;    //Set flag boolean to true
                }
            }
            Input_txt.Text = display;   //Set the Input box text value to equal display variable
        }

        private void Percentage_btn_Click(object sender, EventArgs e) //If the Percentage button is clicked
        {
            if(percentagePress == false) //If the percent button was not pressed before
            {
                Output_txt.Text = Convert.ToString(Convert.ToDouble(Output_txt.Text) * 100) + "%"; //Multiply the Output box's value by 100 and add "%" after
                percentagePress = true; //Set percentagePress to true to display that the percentButton was pressed
            }
        }

        private void Pi_btn_Click(object sender, EventArgs e) //If the Pi button is clicked
        {
            if(numPress == false) //If numPress boolean is equal to false
            {
                if(flag == false && pi == false) //Check if both decimal and pi button are not pressed
                {
                    if (condition == "num1")     //If condition is equal to "num1"
                    {
                        num1 = Convert.ToString(Math.PI);   //Set num1 variable to the value of Pi
                    }
                    else if (condition == "num2") //If condition variable is equal to "num2"
                    {
                        num2 = Convert.ToString(Math.PI);   //Set num2 vairable to the value of Pi
                    }
                    display += " π "; //Add "π" to the end of display
                    Input_txt.Text = display;   //Set the input box to the value of display

                    //Enable the following operation buttons
                    Equal_btn.Enabled = true;
                    Addition_btn.Enabled = true;
                    Subtraction_btn.Enabled = true;
                    Division_btn.Enabled = true;
                    Multiplication_btn.Enabled = true;
                    Percentage_btn.Enabled = false; //Disable percentage button
                    PlusMinus_btn.Enabled = true;
                    Root_btn.Enabled = true;
                    Power_btn.Enabled = true;
                    pi = true; //Set Pi boolean to true
                    operationPress = false;
                }
            }
        }

        private void Erase_btn_Click(object sender, EventArgs e) //If the Earse button (CE) is pressed
        {
            if(Input_txt.Text.Length > 0) //If the length of the input box is greater than 0
            {
                if (condition == "num1") //If condition variable is equal to "num1"
                {
                    if(num1.Length > 0) //If the length of num1 variable is greater than 0
                    {
                        char decimalCheck = num1[num1.Length - 1]; //Create acharacter named "decimalCheck" and set it to the last digit of num1
                        if(decimalCheck == '.') //Check if decmalcheck is equal to '.'
                        {
                            flag = false; //Set flag to false
                        }
                        num1 = num1.Substring(0, (num1.Length - 1)); //Set num1 to equal to the start of num1 till 1 less than the length of num1
                        Input_txt.Text = (Input_txt.Text).Substring(0, ((Input_txt.Text).Length - 1)); //Set the input box to equal the start of the box till 1 less than the length of the value in the box
                        if(num1.Length == 0) //Check if num1 is empty
                        {
                            operationPress = true; //Set operationPress to true
                        }
                    }
                }
                else if (condition == "num2") //If the condition is equal to "num2"
                {
                    if(num2.Length > 0) //If the length of num2 is greater than 0
                    {
                        char decimalCheck = num2[num2.Length - 1]; //Create acharacter named "decimalCheck" and set it to the last digit of num2
                        if (decimalCheck == '.') //Check if decimalcheck is equal to '.'
                        {
                            flag = false; //Set flag to false
                        }
                        num2 = num2.Substring(0, (num2.Length - 1)); //Set num2 to equal the range of num2 from the start till 1 less than the length of num2
                        Input_txt.Text = (Input_txt.Text).Substring(0, ((Input_txt.Text).Length - 1)); //Set Input box to equal from the start of the input box till 1 less than the length of the box
                        if(num2.Length == 0) //Check if num2 is empty
                        {
                            operationPress = true; //Set operationPress to true
                        }
                    }
                }
            }
            display = Input_txt.Text;
        }

        private void Quit_btn_Click(object sender, EventArgs e) //If the quit button is pressed
        {
            this.Close(); //Close this calculator
        }

        private void Operations_btn(object sender, EventArgs e) //When any of the operation buttons are clicked, they will run through this function
        {
            if(equal == true) //If the equal boolean is equal true
            {
                SavedAnswer_txt.Text = ""; //Set the SavedAnswer textbox (History Box) to emtpy
                equal = false; //Set the equal boolean to false
            }
            pi = false;  //Set pi boolean to false
            numPress = false; //Set numPress boolean to false
            Button operationHolder = (Button)sender;  //Create a button named operationHolder that stores the value of the operation button pressed
            if(operationHolder.Text == "±")  //If the operationHolder button is equal to "±"
            {
                if((condition == "num1") && (num1.Length > 0))  //If the condition is equal to "num1" and num1 length is greater than 0
                {
                    num1 = Convert.ToString(Convert.ToDouble(num1) * -1); //Multiply the value of num1 by -1 to change the sign of the value
                    Input_txt.Text = num1;  //Set the unput box to equal to the num1 value
                }
                else if((condition == "num2") && (num2.Length > 0)) //If the condition is equal to "num2" and num2 length is greater than 0
                {
                    num2 = Convert.ToString(Convert.ToDouble(num2) * -1); //Multiply the value of num2 by -1 to change the sings of the value
                    Input_txt.Text = num1 + " " + Operator + " " + num2;  //Set the value of the input box to num1 plus the operator plus num2
                }
            }
            else //Else everything else
            {
                if(num1 == ".") //If num1 is equal to "."
                {
                    Output_txt.Text = "Invalid"; //Output displays "Invalid"
                }
                else if(num2 == ".") //If num2 is equal to "."
                {
                    Output_txt.Text = "Invalid"; //Output displays "Invalid"
                }
                else if(operationPress == false) //If operationPress is false
                {
                    Operator = operationHolder.Text; //Set the Operator variable to equal to the balue of the operationHolder button
                    num1 = operations(operation, num1, num2); //Set num1 variable to the return value of the operation function based on the operation variable, num1, and num2
                    //If the Operator vairable equal to specific operators, set the operation variable to the resepective operations based on the Operator variable
                    if (Operator == "+")
                    {
                        operation = "sum";
                    }
                    else if (Operator == "-")
                    {
                        operation = "difference";
                    }
                    else if (Operator == "x")
                    {
                        operation = "product";
                    }
                    else if (Operator == "÷")
                    {
                        operation = "quotient";
                    }
                    else if (Operator == "^")
                    {
                        operation = "power";
                    }
                    else if (Operator == "√")
                    {
                        operation = "root";
                    }
                    if (condition == "num1") //If confition is equal to "num1"
                    {
                        SavedAnswer_txt.Text += num1; //Add num1 variable to the SavedAnswer box (history box)
                    }
                    else if (condition == "num2") //If condition is equal to "num2"
                    {
                        SavedAnswer_txt.Text += num2;  //Add num2 variable to the SavedAnswer box (history box)
                    }
                    SavedAnswer_txt.Text += " " + Operator + " "; //Add the Operator variable to the SavedAnswer
                    num2 = ""; //Set num2 variable to empty
                    condition = "num2"; //Set condition to "num2"
                    display = Convert.ToString(Math.Round(Convert.ToDouble(num1), 5)) + " " + Operator + " "; //Set display to num1 variable rounded to 5 decimals and the Operator variable
                    Input_txt.Text = display; //Set the input box to equal the display variable
                    flag = false; //Set flag boolean to false
                                  //Disable all the operation buttons
                    Equal_btn.Enabled = false;
                    Addition_btn.Enabled = false;
                    Subtraction_btn.Enabled = false;
                    Division_btn.Enabled = false;
                    Multiplication_btn.Enabled = false;
                    Percentage_btn.Enabled = false; //Disable the Percentage button
                    PlusMinus_btn.Enabled = false;
                    Root_btn.Enabled = false;
                    Power_btn.Enabled = false;
                    operationPress = true;
                }
            }
        }

        private void Num_btn(object sender, EventArgs e) //When any of the number buttons are clicked, they will run through this function
        {
            Button num = (Button)sender; //Create a button named num that stores the value of the number button clicked
            if (pi == false) //If pi boolean is equal to false
            {
                if (condition == "num1") //If condition variable is equal to "num1"
                {
                    num1 += num.Text; //Add the value of num button to num1 variable
                }
                else if (condition == "num2") //If condition variable is equal to "num2"
                {
                    num2 += num.Text; //Add the value of num button to num2  variable
                }
                display += num.Text; //Add the value of num button to the display variable
                Input_txt.Text += num.Text; //Add the value of num button to the Input box
                //Enable all the operation buttons
                Equal_btn.Enabled = true;
                Addition_btn.Enabled = true;
                Subtraction_btn.Enabled = true;
                Division_btn.Enabled = true;
                Multiplication_btn.Enabled = true;
                Percentage_btn.Enabled = false; //Disable the percentage button
                PlusMinus_btn.Enabled = true;
                Root_btn.Enabled = true;
                Power_btn.Enabled = true;
                numPress = true; //Set numPress boolean to true
                operationPress = false;
                Decimal_btn.Enabled = true;
            }
        }
    }
}
