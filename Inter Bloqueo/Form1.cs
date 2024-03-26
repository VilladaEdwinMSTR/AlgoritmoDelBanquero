using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inter_Bloqueo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int result;
        int result2;
        int result3;
        bool aproba1 = false;
        bool aproba2 = false;
        bool aproba3 = false;

        private void E1_TextChanged(object sender, EventArgs e)
        {
        }
        public void Fila1()
        {
            aproba1 = false;
            result = int.Parse(A1.Text) - (int.Parse(C1.Text) + int.Parse(C21.Text) + int.Parse(C31.Text)
                    + int.Parse(C41.Text));
           
            if (result <= int.Parse(A1.Text) && result >= 0)
            {
                E1.Text = result.ToString();
                aproba1 = true;
            }
            else
            {
                MessageBox.Show("Ingrese datos validos en columna 1");
            } 
        }
        public void Fila2()
        {
            aproba2 = false;
            result2 = int.Parse(A2.Text) - (int.Parse(C2.Text) + int.Parse(C22.Text) + int.Parse(C32.Text)
                    + int.Parse(C42.Text));

            if (result2 <= int.Parse(A2.Text) && result2 >= 0)
            {
                E2.Text = result.ToString();
                aproba2 = true;
            }
            else
            {
                MessageBox.Show("Ingrese datos validos en la columna 2");
            }
        }
        public void Fila3()
        {
            aproba3 = false;
            result3 = int.Parse(A3.Text) - (int.Parse(C3.Text) + int.Parse(C23.Text) + int.Parse(C33.Text)
                    + int.Parse(C43.Text));

            if (result3 <= int.Parse(A3.Text) && result3 >= 0)
            {
                E3.Text = result3.ToString();
                aproba3 = true;
            }
            else
            {
                MessageBox.Show("Ingrese datos validos en columna 3");
            }
        }
        private void C1_TextChanged(object sender, EventArgs e)
        {

        }

        private void C21_TextChanged(object sender, EventArgs e)
        {
        }

        private void C31_TextChanged(object sender, EventArgs e)
        {
        }

        private void C41_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fila1();
            Fila2();
            Fila3();
            if(aproba1 && aproba2 && aproba3)
            {
                button2.Enabled = true;
            }
            int d1 = int.Parse(B1.Text) - int.Parse(C1.Text);
            int d2 = int.Parse(B2.Text) - int.Parse(C2.Text);
            int d3 = int.Parse(B3.Text) - int.Parse(C3.Text);

            int d21 = int.Parse(B21.Text) - int.Parse(C21.Text);
            int d22 = int.Parse(B22.Text) - int.Parse(C22.Text);
            int d23 = int.Parse(B23.Text) - int.Parse(C23.Text);

            int d31 = int.Parse(B31.Text) - int.Parse(C31.Text);
            int d32 = int.Parse(B32.Text) - int.Parse(C32.Text);
            int d33 = int.Parse(B33.Text) - int.Parse(C33.Text);

            int d41 = int.Parse(B41.Text) - int.Parse(C41.Text);
            int d42 = int.Parse(B42.Text) - int.Parse(C42.Text);
            int d43 = int.Parse(B43.Text) - int.Parse(C43.Text);

            D1.Text = d1.ToString();
            D2.Text = d2.ToString();
            D3.Text = d3.ToString();

            D21.Text = d21.ToString();
            D22.Text = d22.ToString();
            D23.Text = d23.ToString();

            D31.Text = d31.ToString();
            D32.Text = d32.ToString();
            D33.Text = d33.ToString();

            D41.Text = d41.ToString();
            D42.Text = d42.ToString();
            D43.Text = d43.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int e1 = int.Parse(E1.Text) - int.Parse(F1.Text);
            int e2 = int.Parse(E2.Text) - int.Parse(F2.Text);
            int e3 = int.Parse(E3.Text) - int.Parse(F3.Text);
            E1.Text = e1.ToString();
            E2.Text = e2.ToString();
            E3.Text = e3.ToString();
            int P = int.Parse(P1.Text);

            if(P == 1)
            {
                int d1 = int.Parse(C1.Text) + int.Parse(F1.Text);
                int d2 = int.Parse(C2.Text) + int.Parse(F2.Text);
                int d3 = int.Parse(C3.Text) + int.Parse(F3.Text);
                C1.Text = d1.ToString();
                C2.Text = d2.ToString();
                C3.Text = d3.ToString();

                int c1 = int.Parse(D1.Text) - int.Parse(F1.Text);
                int c2 = int.Parse(D2.Text) - int.Parse(F2.Text);
                int c3 = int.Parse(D3.Text) - int.Parse(F3.Text);
                D1.Text = c1.ToString();
                D2.Text = c2.ToString();
                D3.Text = c3.ToString();
            }
            else if(P == 2)
            {
                int d21 = int.Parse(C21.Text) + int.Parse(F1.Text);
                int d22 = int.Parse(C22.Text) + int.Parse(F2.Text);
                int d23 = int.Parse(C23.Text) + int.Parse(F3.Text);
                C21.Text = d21.ToString();
                C22.Text = d22.ToString();
                C23.Text = d23.ToString();

                int c21 = int.Parse(D21.Text) - int.Parse(F1.Text);
                int c22 = int.Parse(D22.Text) - int.Parse(F2.Text);
                int c23 = int.Parse(D23.Text) - int.Parse(F3.Text);
                D21.Text = c21.ToString();
                D22.Text = c22.ToString();
                D23.Text = c23.ToString();
            }
            else if (P == 3)
            {
                int d31 = int.Parse(C31.Text) + int.Parse(F1.Text);
                int d32 = int.Parse(C32.Text) + int.Parse(F2.Text);
                int d33 = int.Parse(C33.Text) + int.Parse(F3.Text);
                C31.Text = d31.ToString();
                C32.Text = d32.ToString();
                C33.Text = d33.ToString();

                int c31 = int.Parse(D31.Text) - int.Parse(F1.Text);
                int c32 = int.Parse(D32.Text) - int.Parse(F2.Text);
                int c33 = int.Parse(D33.Text) - int.Parse(F3.Text);
                D31.Text = c31.ToString();
                D32.Text = c32.ToString();
                D33.Text = c33.ToString();
            }
            else if (P == 4)
            {
                int d41 = int.Parse(C41.Text) + int.Parse(F1.Text);
                int d42 = int.Parse(C42.Text) + int.Parse(F2.Text);
                int d43 = int.Parse(C43.Text) + int.Parse(F3.Text);
                C41.Text = d41.ToString();
                C42.Text = d42.ToString();
                C43.Text = d43.ToString();

                int c41 = int.Parse(D1.Text) - int.Parse(F1.Text);
                int c42 = int.Parse(D2.Text) - int.Parse(F2.Text);
                int c43 = int.Parse(D3.Text) - int.Parse(F3.Text);
                D41.Text = c41.ToString();
                D42.Text = c42.ToString();
                D43.Text = c43.ToString();
            }
            InterBloqueo();
        }

        public void InterBloqueo()
        {
            int d1 = int.Parse(D1.Text);
            int d2 = int.Parse(D2.Text);
            int d3 = int.Parse(D3.Text);

            int d21 = int.Parse(D21.Text);
            int d22 = int.Parse(D22.Text);
            int d23 = int.Parse(D23.Text);

            int d31 = int.Parse(D31.Text);
            int d32 =  int.Parse(D32.Text);
            int d33 = int.Parse(D33.Text);

            int d41 = int.Parse(D41.Text);
            int d42 = int.Parse(D42.Text);
            int d43 = int.Parse(D43.Text);

            int I1 = int.Parse(E1.Text);
            int I2 = int.Parse(E2.Text);
            int I3 = int.Parse(E3.Text);

            int con1 = d1 - I1;
            int con2 = d2 - I2;
            int con3 = d3 - I3;

            int con4 = d21 - I1;
            int con5 = d22 - I2;
            int con6 = d23 - I3;

            int con7 = d31 - I1;
            int con8 = d32 - I2;
            int con9 = d33 - I1;

            int con10 = d41 - I2;
            int con11 = d42 - I3;
            int con12 = d43 - I3;

            if (con1 <= 0 && con2 <= 0 && con3 <= 0)
            {
                MessageBox.Show("No hay INTERBLOQUEO");
            }
            else if(con4 <= 0 && con5 <= 0 && con6 <= 0)
            {
                MessageBox.Show("No hay INTERBLOQUEO");
            }
            else if (con7 == 0 && con8 == 0 && con9 <= 0)
            {
                MessageBox.Show("No hay INTERBLOQUEO");
            }
            else if (con10 <= 0 && con11 <= 0 && con12 <= 0)
            {
                MessageBox.Show("No hay INTERBLOQUEO");
            }
            else
            {
                MessageBox.Show("INTERBLOQUEO!!!");
            }


        }
    }
}
