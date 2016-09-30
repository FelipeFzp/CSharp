using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    class Informations
    {
       public static decimal Height { get; set; }
       public static decimal Weight { get; set; }
       public static string Genrer { get; set; }
       private static double Result { get; set; }

        public static string ImcCalculate()
        {
            double dWeight = Convert.ToDouble(Weight);
            double dHeight = Convert.ToDouble(Height);

            dHeight = Math.Pow(dHeight, 2);
            Result = dWeight/dHeight;
            
            if (Result < 17.00)
            {
                return "Seu Indice de Massa Corporal é " + String.Format("{0:N}", Result) + ", Muito Abaixo do Peso";
            }

            if (Result >= 17.00 && Result <= 18.49)
            {
                return "Seu Indice de Massa Corporal é " + String.Format("{0:N}", Result) + ", Abaixo do Peso";
            }

            if (Result >= 18.50 && Result <= 24.99)
            {
                return "Seu Indice de Massa Corporal é " + String.Format("{0:N}", Result) + ", Peso Normal (Ideal)";
            }

            if (Result >= 25.00 && Result <= 29.99)
            {
                return "Seu Indice de Massa Corporal é " + String.Format("{0:N}", Result) + ", Acima do Peso";
            }

            if (Result >= 30 && Result <= 34.99)
            {
                return "Seu Indice de Massa Corporal é " + String.Format("{0:N}", Result) + ", Obesidade I";
            }

            if (Result >= 35 && Result <=39.99)
            {
                return "Seu Indice de Massa Corporal é " + String.Format("{0:N}", Result) + ", Obesidade II (severa)";
            }

            if (Result >= 40)
            {
                return "Seu Indice de Massa Corporal é " + String.Format("{0:N}", Result) + ", Obesidade III (mórbida)";
            }
            return "Erro ao Calcular !!";
        }
    }
}
