

namespace XadrezApp.Validation
{
    public class ValidationError
    {
        public string MensagemAmigavel { get; private set; }
        public string MensagemException { get; private set; }
        public string StackTrace { get; private set; }



        public ValidationError(string mensagemException)
        {
            MensagemException = mensagemException;
        }


        public ValidationError(string mensagemException, string stactTrace)
        {
            MensagemException = mensagemException;
            StackTrace = stactTrace;

        }
    }
}
