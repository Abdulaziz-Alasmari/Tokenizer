using System;
    public abstract class Tokenizable
    {
        public abstract bool tokenizable(Tokenizer t);
        public abstract Token tokenize(Tokenizer t);
    }