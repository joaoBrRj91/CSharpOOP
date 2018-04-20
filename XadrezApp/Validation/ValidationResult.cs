
using System;
using System.Collections.Generic;

namespace XadrezApp.Validation
{
    public class ValidationResult
    {

        public ValidationResult()
        {
            Erros = new List<ValidationError>();
        }

        public bool EhValido { get; private set; } = true;

        public List<ValidationError> Erros { get; set; }


        public void AddErro(string mensagem)
        {

            EhValido = false;
            var error = new ValidationError(mensagem);
            Erros.Add(error);

        }

        public void AddErro(string mensagemException,string stackTrace)
        {
            EhValido = false;
            var error = new ValidationError(mensagemException, stackTrace);
            Erros.Add(error);
        }

       
    }
}
