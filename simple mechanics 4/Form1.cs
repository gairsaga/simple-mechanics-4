//form1.cs
// CS-1181
// Sagar Gaire
// 9/21/2017
// Anil Mandal
//from this simple mechanics we can know how coding are done using while, do while and other different loops
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_mechanics_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //WHILE LOOP
            //1
            int wStepA = 0;
            while (wStepA < 4)
            {
                wStepA++;
            }
            //3
            int wStepC = 0;
            while (wStepC < 10)
            {
                wStepC++;
            }
            //5
            int wStepE = 1;
            while (wStepE < 21)
            {
                wStepE++;
            }
            //7
            int wStepG = 1;
            while (wStepG <=100)
            {
                wStepG++;
            }
            //9
            int wStepJ = 3;
            while (wStepJ < 101)
            {
                wStepJ += 3;
            }
            //11
            int wStepL = 8;
            while (wStepL < 89)
            {
                wStepL += 8;
            }
            //13
            int wStepN = 7;
            while (wStepN < 71)
            {
                wStepN += 3;
            }
            //15
            int wStepP = 5;
            while (wStepP > 0)
            {
                wStepP--;
            }
            //17
            int wStepR = 10;
            while (wStepR > 1)
            {
                wStepR-=2;
            }
            //19
            int wStepU = 100;
            while (wStepU > 1)
            {
                wStepU-=3;
            }

            //Sentinel Controlled While Loops
            //21
            bool sentleA = true;
            int wStopA = 0;
            while (sentleA)
            {
                wStopA++;
                if (wStopA == 3 ) {
                    sentleA = false;
                }
            }
            //23
            bool sentleC = true;
            int wStopC = 3;
            while (sentleC)
            {
                wStopA++;
                if (wStopC == 66 ) {
                    sentleC = false;
                }
            }
            //25

            bool sentleE = true;
            int wStopE = -340;
            while (sentleA)
            {
                wStopA++;
                if (wStopE >= 10 ) {
                    sentleE = false;
                }
            }

            //Do-While Loops
            //27
            int dwStepB = 0;
            do
            {
                dwStepB++;
            } while (dwStepB < 5);

            //29
            int dwStepD = 1;
            do
            {
                dwStepD++;
            } while (dwStepD < 11);
            //31
            int dwStepF = 1;
            do
            {
                dwStepF++;
            } while (dwStepF<= 20);

            //33
            int dwStepH = 2;
            do
            {
                dwStepH += 2;
            } while (dwStepH < 101);

            //35
            int dwStepK = 4;
            do
            {
                dwStepK += 4;
            } while (dwStepK < 101);

            //37
            int dwStepM = 8;
            do
            {
                dwStepM += 8;
            } while (dwStepM < 90);

            //39
            int dwStepO = 5;
            do
            {
                dwStepO-- ;
            } while (dwStepO >= 0);

            //41
            int dwStepQ = 10;
            do
            {
                dwStepQ--;
            } while (dwStepQ > 0);

            //43
            int dwStepS = 100;
            do
            {
                dwStepS-=2;
            } while (dwStepS > 1);
            //45
            int dwStepU = 38;
            do
            {
                dwStepU-=7;
            } while (dwStepU > 1);

            //For Loops
            //47
            for (int fStepB = 0; fStepB < 5; fStepB++)
            {
            }
            //49
            for (int fStepD = 1; fStepD < 11; fStepD++)
            {
            }
            //51
            for (int fStepF = 1; fStepF <= 20; fStepF++)
            {
            }
            //53
            for (int fStepH = 2; fStepH < 101; fStepH += 2)
            {
            }

            //55
            for (int fStepK = 4; fStepK >=0 ; fStepK += 4)
            {
            }
            //57
            for (int fStepM = 8; fStepM < 90; fStepM+=8) 
            {
            }
            //59
            for (int fStepO = 5; fStepO >= 0; fStepO--)
            {
            }
            //61
            for (int fStepQ = 10; fStepQ > 0; fStepQ--)
            {
            }
            //63
            for (int fStepS = 100; fStepS >1; fStepS-=2)
            {
            }
            //65
            for (int fStepU = 38; fStepU > 1; fStepU-=7)
            {
            }






        }
    }
}
