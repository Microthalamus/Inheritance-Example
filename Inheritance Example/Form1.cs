using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance_Example
{
    public partial class Form1 : Form
    {
        class Hero
        {
            public string name;
            public int attack;
            public int hp;
           

            public void Printbase()
            {
                MessageBox.Show (name + Environment.NewLine + "Attack: " + attack + Environment.NewLine +"HP: " + hp ) ;
               
            }
        }

        // This is the base class

        class Warrior : Hero
        {
            public void armor()
            {
                MessageBox.Show("This class has can use heavy armor.");
            }
            
        }
        class Mage : Hero
        {
            public void mana ()
            {
                MessageBox.Show("This class can use magic staffs.");
            }
         
        }
        class Theif : Hero
        {
            public void sneak()
            {
                MessageBox.Show("This class can use light armor");
            }
               
        }

        //These three classes are the derived classes. Here is where I added the extra message specific to each class.
        public Form1()
        {
            InitializeComponent();


        }

        // Setting up parameters for when each button is clicked

        public void warriorButton_Click(object sender, EventArgs e)
        {
            Warrior warrior = new Warrior
            {
                name = "Warrior",
                attack = 100,
                hp = 1500
                
            };
            warrior.Printbase();
            warrior.armor();

        }


        public void magebutton_Click(object sender, EventArgs e)
        {
            Mage Mage = new Mage
            {
                name = "Mage",
                attack = 50,
                hp = 800
            };
            Mage.Printbase ();
            Mage.mana();

        }

        public void theifButton_Click(object sender, EventArgs e)
        {
            Theif theif = new Theif
            {
                name = "Theif",
                attack = 80,
                hp = 1000
            };
            theif.Printbase();
            theif.sneak();
        }
    }
}
