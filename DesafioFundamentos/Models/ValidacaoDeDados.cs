using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class ValidacaoDeDados
    {
        public static bool ValidacaoDePlaca(string placa)
        {
            string padraoRegex = @"^[A-Za-z]{3}-\d{4}$";
            return Regex.IsMatch(placa, padraoRegex);
        }
    }
}
