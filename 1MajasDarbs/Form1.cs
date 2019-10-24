using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1MajasDarbs
{
    public partial class RandomNumberGenerator : Form
    {
        // declare variables
        // fromInteger --> value from
        // toInteger --> value to
        // currentInteger generated int
        //rnd --> random number generator
        private int fromInteger;
        private int toInteger;
        private int currentInteger;
        private Random rnd;
        StreamWriter log;

        public RandomNumberGenerator()
        {
            // initiliaze variables
            rnd = new Random();
            fromInteger = 0;
            toInteger = 0;

            InitializeComponent();
        }

        // methods for monitoring when user input leaves textboxes. Calls for a method TexBoxInputCheck
        private void textBoxFrom_TextChanged(object sender, EventArgs e)
        {
            TextBoxInputCheck(textBoxFrom.Text,false);
        }

        private void textBoxTo_TextChanged(object sender, EventArgs e)
        {
            TextBoxInputCheck(textBoxTo.Text, true);
        }


        // method for error checking input and storing inputBox values into variables
        private void TextBoxInputCheck(String text, Boolean valueTo)
        {
            try
            {
                int number = int.Parse(text);
                if (valueTo)
                {
                    toInteger = number;
                    fromInteger = (number > fromInteger) ? fromInteger : number;
                    textBoxFrom.Text = fromInteger.ToString();
                }
                if (!valueTo)
                {
                    fromInteger = number;
                    toInteger = (number < toInteger) ? toInteger : number;
                    textBoxTo.Text = toInteger.ToString();
                }
            }
            catch
            {
                if (text != "")
                {
                    MessageBox.Show("Enter whole number!");
                    if(valueTo)
                    {
                        textBoxTo.Text = toInteger.ToString();
                    }
                    else
                    {
                        textBoxFrom.Text = fromInteger.ToString(); ;
                    }
                }
            }
        }

        // method for logging (saving) generated values into logfile.txt
        private void NumberLogger(int generatedInteger)
        {
            if (!File.Exists("logfile.txt"))
            {
                log = new StreamWriter("logfile.txt");
            }
            else
            {
                log = File.AppendText("logfile.txt");
            }

            String entry = (DateTime.Now + " " + fromInteger.ToString() + " " + toInteger.ToString() + " " + generatedInteger.ToString());
            log.WriteLine(entry);
            log.Close();
        }

        // method that is called when button is pushed. Displays on the label generated value and calls for method to log the values
        private void buttonGenerateRandomNumber_Click(object sender, EventArgs e)
        {
            currentInteger = rnd.Next(fromInteger, toInteger);
            labelRandomNumber.Text = currentInteger.ToString();
            NumberLogger(currentInteger);
        }
    }
}
