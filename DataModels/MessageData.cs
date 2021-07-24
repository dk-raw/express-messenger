namespace express_messenger.DataModels
{
    public class MessageData
    {
        private string _message;
        private int _repeat;
        private int _delay;
        private int _initialDelay;

        public MessageData(string message, int repeat, int delay, int initalDelay)
        {
            _message = message;
            _repeat = repeat;
            _delay = delay;
            _initialDelay = initalDelay;
        }

        public MessageData() { }

        public string Message { get => _message; set => _message = value; }
        public int Repeat { get => _repeat; set => _repeat = value; }
        public int Delay { get => _delay; set => _delay = value; }
        public int InitialDelay { get => _initialDelay; set => _initialDelay = value; }
        public bool Valid { get => Verify(); }

        private bool Verify()
        {
            if (_delay > 0 && _initialDelay > 0 && _repeat > 0 || _message != string.Empty)
                return true;

            return false;
        }
    }
}
