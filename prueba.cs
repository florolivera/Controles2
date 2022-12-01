using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;
using System.Windows.Controls;
using System.Windows;
using Label = System.Reflection.Emit.Label;

namespace Controles
{
    class prueba
    {
        private System.Reflection.Emit.Label firsNameLabel;
        private Label lastNameLabel;
        TextBox firstName;
        TextBox lastName;
        Button submit;
        Button clear;
        

        void CreateControls()
        { 
            firstName = new TextBox();
            firstName.Margin = new Thickness(0, 5, 10, 5);
            Grid.SetColumn(firstName, 1);

            lastName = new TextBox();
            lastName.Margin = new Thickness(0, 5, 10, 5);
            Grid.SetColumn(lastName, 1);
            Grid.SetRow(lastName, 1);

            submit = new Button();
            submit.Content = "View message";
            Grid.SetRow(submit, 2);

            clear = new Button();
            clear.Content = "Clear Name";
            Grid.SetRow(clear, 2);
            Grid.SetColumn(clear, 1);
        }       
    }
}
