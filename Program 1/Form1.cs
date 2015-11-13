// Spencer Kerber
// CIS 199-01
// Program 1
// Due 10/1/14 2:30 PM
// Painting information
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float SQUARE_FEET;                                          //Square feet of wall space to be painted
            int NUMBER_OF_COATS;                                        // Number of coats of paint needed
            float PRICE_PER_GALLON;                                     // Price per gallon on paint
            float TOTAL_SQUARE_FEET;                                    // Total number of square footage that will be painted
            float NUMBER_OF_GALLONS_REQUIRED;                           // Number of gallons required for painting total square footage
            float HOURS_OF_LABOR_REQUIRED;                              // Hours of labor required for painting total square footage
            float PAINT_COST;                                           // Total cost of paint
            float LABOR_COST;                                           // Total cost of labor
            float TOTAL_COST;                                           // Cost of paing and labor combined

            const decimal SQUAURE_FEET_RATE = 325m;                     // Square footage covered by 1 gallon/ 8 labor hours    
            float SQUARE_FEET_RATE_FLOAT = (float)SQUAURE_FEET_RATE;    // Square footage covered by 1 gallon/ 8 hours variable
            const decimal TIME_RATE = 8m;                               // Hours of labor used by painting 1 gallon
            float TIME_RATE_FLOAT = (float)TIME_RATE;                   // Hours of labor used by painting 1 gallon variable
            const decimal WAGE_RATE = 10.50m;                           // Pay per hour of painting
            float WAGE_RATE_FLOAT = (float)WAGE_RATE;                   // Pay per hour of painting variable
           
            

           
            SQUARE_FEET = float.Parse(SQUARE_FEET_TEXTBOX.Text);
            NUMBER_OF_COATS = int.Parse(NUMBER_OF_COATS_TEXTBOX.Text);
            PRICE_PER_GALLON = float.Parse(PRICE_PER_GALLON_TEXTBOX.Text);
           

            TOTAL_SQUARE_FEET = SQUARE_FEET * NUMBER_OF_COATS;    
            TOTAL_SQUARE_FEET_LABEL.Text = TOTAL_SQUARE_FEET.ToString("F1");

            NUMBER_OF_GALLONS_REQUIRED = TOTAL_SQUARE_FEET / SQUARE_FEET_RATE_FLOAT;
            NUMBER_OF_GALLONS_REQUIRED_LABEL.Text = Math.Ceiling(NUMBER_OF_GALLONS_REQUIRED).ToString("F");
            float.Parse(NUMBER_OF_GALLONS_REQUIRED_LABEL.Text);

            HOURS_OF_LABOR_REQUIRED = TIME_RATE_FLOAT * NUMBER_OF_GALLONS_REQUIRED;
            HOURS_OF_LABOR_REQUIRED_LABEL.Text = HOURS_OF_LABOR_REQUIRED.ToString("F1");

            PAINT_COST = PRICE_PER_GALLON * float.Parse(NUMBER_OF_GALLONS_REQUIRED_LABEL.Text);
            PAINT_COST_LABEL.Text =PAINT_COST.ToString("C");

            LABOR_COST = HOURS_OF_LABOR_REQUIRED * WAGE_RATE_FLOAT;
            LABOR_COST_LABEL.Text = LABOR_COST.ToString("C");

            TOTAL_COST = PAINT_COST + LABOR_COST;
            TOTAL_COST_LABEL.Text =TOTAL_COST.ToString("C");
                



            







             
           




           


            

            

           



            


            





        }
    }
}
