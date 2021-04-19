    public class Tokenizer
    {
        public string input;
        public int currentPosition;
        public int lineNumber;

        public Tokenizer(string source)
        {
            this.input = source;
            this.currentPosition = -1;
            this.lineNumber = 1;
        }
        public char peak(int pos = 1)
        {

            if (hasMore())
            {
                return this.input[this.currentPosition + pos];
            }
            else
            {
                return '\0';
            }
        }

        public char next()
        {
            char currentChar = this.input[++this.currentPosition];
            if (currentChar == '\n')
                this.lineNumber++;
            return currentChar;

        }
        public bool hasMore() { return (this.currentPosition + 1) < input.Length; }
        public Token tokenize(Tokenizable[] handlers)
        {
            foreach (var t in handlers)
            {
                if (t.tokenizable(this))
                {
                    return t.tokenize(this);
                }
            }
            // throw new Exception("Unexpected token");
            return null;
        }
    }