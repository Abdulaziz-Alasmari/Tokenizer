using System;


namespace Project
{
    
    public class Program
    {

        static void Main(string[] args)
        {
            // Tokenizer t = new Tokenizer("234 ! && &&& | || ||| hello /***this\n is\n multi\n line\n comments/ //helo this is commnets\n this ");
            Tokenizer t = new Tokenizer("234  && && 335<5 <= == >= || ||| hello /***this\n is\n multi\n line\n comments/ //helo this is commnets\n this ");

            Tokenizable [] handlers = new Tokenizable [] 
            { 
                // new NumberTokenizer(),
                // new IdTokenizer(),
                // new WhiteSpace(),
                // new OneLineComments(),
                // new MultiLineComments(),
                // new LogicalOperator(),
                // new BitWiseOperator(),
            };

            Token tkn =  t.tokenize( handlers );
            while( tkn != null )
            {
                Console.WriteLine("(" + tkn.type + ", " + tkn.value + ")");
                tkn = t.tokenize(handlers);
            }
        }
    }
}
