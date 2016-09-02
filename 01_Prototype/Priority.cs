namespace _01_Prototype
{
    class Priority
    {
        private int priority = -1;
        
        public Priority Hight()
        {
            priority = 1;
            return this;
        }       

        public Priority Low()
        {
            priority = 2;
            return this;
        }

        public int Prior
        {
            get { return priority; }
        }
    }
}
